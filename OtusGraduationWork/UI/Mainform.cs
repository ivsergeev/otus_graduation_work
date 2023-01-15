using OtusGraduationWork.KvStore.diagnostic;
using OtusGraduationWork.KvStore.service;
using OtusGraduationWork.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace OtusGraduationWork
{
    public partial class Mainform : Form
    {
        private LsmKvStore _store;
        private List<byte[]> _images;
        private byte[] _addValue;

        public Mainform()
        {
            InitializeComponent();

            RefreshStoreInfo();
        }

        private void btInitStorage_Click(object sender, EventArgs e)
        {
            if (_store != null)
                _store.Dispose();

            _store = new LsmKvStore(tbStoragePath.Text,
                                    (int)nmPartSize.Value,
                                    (int)nmIndexLimit.Value,
                                    (int)nmLogLimit.Value);

            RefreshStoreInfo();
        }

        private void RefreshStoreInfo()
        {
            if (_store == null)
            {
                lbPartSize.Text = "-";
                lbIndexLimit.Text = "-";
                lbLogLimit.Text = "-";
                lbIndexSize.Text = "-";
                lbIndexCount.Text = "-";
                lbTableCount.Text = "-";
                lbTablesSize.Text = "-";
            }
            else
            {
                lbPartSize.Text = _store.PartSize.ToString();
                lbIndexLimit.Text = _store.IndexLimit.ToString();
                lbLogLimit.Text = _store.LogLimit.ToString();
                lbIndexSize.Text = _store.IndexSize.ToString();
                lbIndexCount.Text = _store.IndexCount.ToString();
                lbTableCount.Text = _store.TableCount.ToString();
                lbTablesSize.Text = _store.TablesSize.ToString();
            }
        }

        private void btSelectStorageFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                tbStoragePath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btSelectImagesFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                tbImages.Text = folderBrowserDialog.SelectedPath;

                _images = LoadImages();
            }
        }

        private void btAddRecords_Click(object sender, EventArgs e)
        {
            var count = nmAddRecordCount.Value;
            var randomKeys = cbAddRandomKeys.Checked;
            var randomKeysInterval = (int)nmAddKeysInterval.Value;
            var rnd = new Random();
            var milliseconds = 0L;

            using (OperationContext.Create())
            {
                var sw = Stopwatch.StartNew();

                for (int i = 0; i < count; i++)
                {
                    var key = randomKeys ? rnd.Next(randomKeysInterval).ToString() : i.ToString();
                    var value = _images[rnd.Next(_images.Count)];

                    _store.Set(key, value);
                }

                milliseconds = sw.ElapsedMilliseconds;
            }

            RefreshStoreInfo();
        }

        private List<byte[]> LoadImages()
        {
            var images = new List<byte[]>();

            foreach (var file in Directory.GetFiles(tbImages.Text).OrderBy(x => x))
            {
                try
                {
                    Image.FromFile(file);
                    images.Add(File.ReadAllBytes(file));
                }
                catch (Exception e)
                {
                    //
                }
            }

            return images;
        }

        private void cbAddRandomKeys_CheckedChanged(object sender, EventArgs e)
        {
            nmAddKeysInterval.Enabled = cbAddRandomKeys.Checked;
        }

        private void btRemoveRecords_Click(object sender, EventArgs e)
        {
            var count = nmRemoveRecordCount.Value;
            var randomKeys = cbRemoveRandomKeys.Checked;
            var randomKeysInterval = (int)nmRemoveKeysInterval.Value;
            var rnd = new Random();
            var milliseconds = 0L;

            using (OperationContext.Create())
            {
                var sw = Stopwatch.StartNew();

                for (int i = 0; i < count; i++)
                {
                    var key = randomKeys ? rnd.Next(randomKeysInterval).ToString() : i.ToString();

                    _store.Remove(key);
                }

                milliseconds = sw.ElapsedMilliseconds;
            }

            RefreshStoreInfo();
        }

        private void cbRemoveRandomKeys_CheckedChanged(object sender, EventArgs e)
        {
            nmRemoveKeysInterval.Enabled = cbRemoveRandomKeys.Checked;
        }

        private void btSelectAddValue_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbAddValue.Image = Image.FromFile(openFileDialog.FileName);
                _addValue = File.ReadAllBytes(openFileDialog.FileName);
            }
        }

        private void btAddRecord_Click(object sender, EventArgs e)
        {
            var key = tbAddKey.Text;
            var value = _addValue;

            _store.Set(key, value);

            RefreshStoreInfo();
        }

        private void btFindRecord_Click(object sender, EventArgs e)
        {
            var key = tbFindKey.Text;
            var filter = cbFilter.Checked;

            using (OperationContext.Create())
            {
                var sw = Stopwatch.StartNew();

                var bytes = _store.Get(key, filter);
                if (bytes == null)
                {
                    pbFindValue.Image = null;
                }
                else
                {
                    pbFindValue.Image = Image.FromStream(new MemoryStream(bytes));
                }

                using (var frm = new OperationResult(sw.ElapsedMilliseconds))
                {
                    frm.ShowDialog();
                }
            }

            RefreshStoreInfo();
        }

        private void btFindRecords_Click(object sender, EventArgs e)
        {
            var count = nmFindRecordCount.Value;
            var randomKeys = cbFindRandomKeys.Checked;
            var randomKeysInterval = (int)nmFindKeysInterval.Value;
            var rnd = new Random();
            var filter = cbFilter.Checked;

            using (OperationContext.Create())
            {
                var sw = Stopwatch.StartNew();

                for (int i = 0; i < count; i++)
                {
                    var key = randomKeys ? rnd.Next(randomKeysInterval).ToString() : i.ToString();

                    _store.Get(key, filter);
                }

                using(var frm = new OperationResult(sw.ElapsedMilliseconds))
                {
                    frm.ShowDialog();
                }
            }

            RefreshStoreInfo();
        }

        private void cbFindRandomKeys_CheckedChanged(object sender, EventArgs e)
        {
            nmFindKeysInterval.Enabled = cbFindRandomKeys.Checked;
        }

        private void btRemoveKey_Click(object sender, EventArgs e)
        {
            var key = tbRemoveKey.Text;

            _store.Remove(key);

            RefreshStoreInfo();
        }
    }
}
