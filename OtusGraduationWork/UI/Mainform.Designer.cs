
namespace OtusGraduationWork
{
    partial class Mainform
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbFolders = new System.Windows.Forms.GroupBox();
            this.lbTableCount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbIndexCount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbIndexSize = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbLogLimit = new System.Windows.Forms.Label();
            this.lbIndexLimit = new System.Windows.Forms.Label();
            this.lbPartSize = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btInitStorage = new System.Windows.Forms.Button();
            this.cbFilter = new System.Windows.Forms.CheckBox();
            this.nmLogLimit = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nmIndexLimit = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nmPartSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btSelectImagesFolder = new System.Windows.Forms.Button();
            this.btSelectStorageFolder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbImages = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbStoragePath = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.nmAddKeysInterval = new System.Windows.Forms.NumericUpDown();
            this.cbAddRandomKeys = new System.Windows.Forms.CheckBox();
            this.btAddRecords = new System.Windows.Forms.Button();
            this.nmAddRecordCount = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.nmRemoveKeysInterval = new System.Windows.Forms.NumericUpDown();
            this.cbRemoveRandomKeys = new System.Windows.Forms.CheckBox();
            this.btRemoveRecords = new System.Windows.Forms.Button();
            this.nmRemoveRecordCount = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btAddRecord = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tbAddKey = new System.Windows.Forms.TextBox();
            this.pbAddValue = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btSelectAddValue = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.nmFindKeysInterval = new System.Windows.Forms.NumericUpDown();
            this.cbFindRandomKeys = new System.Windows.Forms.CheckBox();
            this.btFindRecords = new System.Windows.Forms.Button();
            this.nmFindRecordCount = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pbFindValue = new System.Windows.Forms.PictureBox();
            this.tbFindKey = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btFindRecord = new System.Windows.Forms.Button();
            this.lbTablesSize = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tbRemoveKey = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btRemoveKey = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbFolders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmLogLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmIndexLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPartSize)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmAddKeysInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmAddRecordCount)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmRemoveKeysInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmRemoveRecordCount)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFindKeysInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFindRecordCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFindValue)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gbFolders, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 650F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1521, 974);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gbFolders
            // 
            this.gbFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFolders.Controls.Add(this.lbTablesSize);
            this.gbFolders.Controls.Add(this.label18);
            this.gbFolders.Controls.Add(this.lbTableCount);
            this.gbFolders.Controls.Add(this.label10);
            this.gbFolders.Controls.Add(this.lbIndexCount);
            this.gbFolders.Controls.Add(this.label9);
            this.gbFolders.Controls.Add(this.lbIndexSize);
            this.gbFolders.Controls.Add(this.label7);
            this.gbFolders.Controls.Add(this.lbLogLimit);
            this.gbFolders.Controls.Add(this.lbIndexLimit);
            this.gbFolders.Controls.Add(this.lbPartSize);
            this.gbFolders.Controls.Add(this.label6);
            this.gbFolders.Controls.Add(this.btInitStorage);
            this.gbFolders.Controls.Add(this.cbFilter);
            this.gbFolders.Controls.Add(this.nmLogLimit);
            this.gbFolders.Controls.Add(this.label5);
            this.gbFolders.Controls.Add(this.nmIndexLimit);
            this.gbFolders.Controls.Add(this.label4);
            this.gbFolders.Controls.Add(this.nmPartSize);
            this.gbFolders.Controls.Add(this.label3);
            this.gbFolders.Controls.Add(this.btSelectImagesFolder);
            this.gbFolders.Controls.Add(this.btSelectStorageFolder);
            this.gbFolders.Controls.Add(this.label2);
            this.gbFolders.Controls.Add(this.tbImages);
            this.gbFolders.Controls.Add(this.label1);
            this.gbFolders.Controls.Add(this.tbStoragePath);
            this.gbFolders.ForeColor = System.Drawing.Color.Black;
            this.gbFolders.Location = new System.Drawing.Point(3, 3);
            this.gbFolders.Name = "gbFolders";
            this.gbFolders.Size = new System.Drawing.Size(1515, 644);
            this.gbFolders.TabIndex = 0;
            this.gbFolders.TabStop = false;
            // 
            // lbTableCount
            // 
            this.lbTableCount.AutoSize = true;
            this.lbTableCount.ForeColor = System.Drawing.Color.Gray;
            this.lbTableCount.Location = new System.Drawing.Point(747, 477);
            this.lbTableCount.Name = "lbTableCount";
            this.lbTableCount.Size = new System.Drawing.Size(0, 32);
            this.lbTableCount.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 477);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(271, 32);
            this.label10.TabIndex = 25;
            this.label10.Text = "Количество таблиц";
            // 
            // lbIndexCount
            // 
            this.lbIndexCount.AutoSize = true;
            this.lbIndexCount.ForeColor = System.Drawing.Color.Gray;
            this.lbIndexCount.Location = new System.Drawing.Point(747, 436);
            this.lbIndexCount.Name = "lbIndexCount";
            this.lbIndexCount.Size = new System.Drawing.Size(0, 32);
            this.lbIndexCount.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 436);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(370, 32);
            this.label9.TabIndex = 23;
            this.label9.Text = "Кол-во элементов индекса";
            // 
            // lbIndexSize
            // 
            this.lbIndexSize.AutoSize = true;
            this.lbIndexSize.ForeColor = System.Drawing.Color.Gray;
            this.lbIndexSize.Location = new System.Drawing.Point(747, 352);
            this.lbIndexSize.Name = "lbIndexSize";
            this.lbIndexSize.Size = new System.Drawing.Size(0, 32);
            this.lbIndexSize.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(307, 32);
            this.label7.TabIndex = 21;
            this.label7.Text = "Размер индекса, байт";
            // 
            // lbLogLimit
            // 
            this.lbLogLimit.AutoSize = true;
            this.lbLogLimit.ForeColor = System.Drawing.Color.Gray;
            this.lbLogLimit.Location = new System.Drawing.Point(747, 302);
            this.lbLogLimit.Name = "lbLogLimit";
            this.lbLogLimit.Size = new System.Drawing.Size(0, 32);
            this.lbLogLimit.TabIndex = 19;
            // 
            // lbIndexLimit
            // 
            this.lbIndexLimit.AutoSize = true;
            this.lbIndexLimit.ForeColor = System.Drawing.Color.Gray;
            this.lbIndexLimit.Location = new System.Drawing.Point(747, 251);
            this.lbIndexLimit.Name = "lbIndexLimit";
            this.lbIndexLimit.Size = new System.Drawing.Size(0, 32);
            this.lbIndexLimit.TabIndex = 18;
            // 
            // lbPartSize
            // 
            this.lbPartSize.AutoSize = true;
            this.lbPartSize.ForeColor = System.Drawing.Color.Gray;
            this.lbPartSize.Location = new System.Drawing.Point(747, 202);
            this.lbPartSize.Name = "lbPartSize";
            this.lbPartSize.Size = new System.Drawing.Size(0, 32);
            this.lbPartSize.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 609);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(396, 32);
            this.label6.TabIndex = 16;
            this.label6.Text = "Использовать фильтр блума";
            // 
            // btInitStorage
            // 
            this.btInitStorage.Location = new System.Drawing.Point(526, 553);
            this.btInitStorage.Name = "btInitStorage";
            this.btInitStorage.Size = new System.Drawing.Size(215, 50);
            this.btInitStorage.TabIndex = 15;
            this.btInitStorage.Text = "Создать";
            this.btInitStorage.UseVisualStyleBackColor = true;
            this.btInitStorage.Click += new System.EventHandler(this.btInitStorage_Click);
            // 
            // cbFilter
            // 
            this.cbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbFilter.AutoSize = true;
            this.cbFilter.Checked = true;
            this.cbFilter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFilter.Location = new System.Drawing.Point(518, 609);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(34, 33);
            this.cbFilter.TabIndex = 14;
            this.cbFilter.UseVisualStyleBackColor = true;
            // 
            // nmLogLimit
            // 
            this.nmLogLimit.Location = new System.Drawing.Point(526, 300);
            this.nmLogLimit.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nmLogLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmLogLimit.Name = "nmLogLimit";
            this.nmLogLimit.Size = new System.Drawing.Size(215, 38);
            this.nmLogLimit.TabIndex = 12;
            this.nmLogLimit.Value = new decimal(new int[] {
            200000000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(454, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ограничение размера лога, байт";
            // 
            // nmIndexLimit
            // 
            this.nmIndexLimit.Location = new System.Drawing.Point(526, 249);
            this.nmIndexLimit.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nmIndexLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmIndexLimit.Name = "nmIndexLimit";
            this.nmIndexLimit.Size = new System.Drawing.Size(215, 38);
            this.nmIndexLimit.TabIndex = 10;
            this.nmIndexLimit.Value = new decimal(new int[] {
            50000000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(503, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ограничение размера индекса, байт";
            // 
            // nmPartSize
            // 
            this.nmPartSize.Location = new System.Drawing.Point(526, 200);
            this.nmPartSize.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nmPartSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmPartSize.Name = "nmPartSize";
            this.nmPartSize.Size = new System.Drawing.Size(215, 38);
            this.nmPartSize.TabIndex = 8;
            this.nmPartSize.Value = new decimal(new int[] {
            64000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(426, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Размер сегмента данных, байт";
            // 
            // btSelectImagesFolder
            // 
            this.btSelectImagesFolder.Location = new System.Drawing.Point(1323, 113);
            this.btSelectImagesFolder.Name = "btSelectImagesFolder";
            this.btSelectImagesFolder.Size = new System.Drawing.Size(161, 50);
            this.btSelectImagesFolder.TabIndex = 5;
            this.btSelectImagesFolder.Text = "обзор";
            this.btSelectImagesFolder.UseVisualStyleBackColor = true;
            this.btSelectImagesFolder.Click += new System.EventHandler(this.btSelectImagesFolder_Click);
            // 
            // btSelectStorageFolder
            // 
            this.btSelectStorageFolder.Location = new System.Drawing.Point(1323, 59);
            this.btSelectStorageFolder.Name = "btSelectStorageFolder";
            this.btSelectStorageFolder.Size = new System.Drawing.Size(161, 50);
            this.btSelectStorageFolder.TabIndex = 4;
            this.btSelectStorageFolder.Text = "обзор";
            this.btSelectStorageFolder.UseVisualStyleBackColor = true;
            this.btSelectStorageFolder.Click += new System.EventHandler(this.btSelectStorageFolder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Каталог изображений";
            // 
            // tbImages
            // 
            this.tbImages.Location = new System.Drawing.Point(526, 120);
            this.tbImages.Name = "tbImages";
            this.tbImages.ReadOnly = true;
            this.tbImages.Size = new System.Drawing.Size(791, 38);
            this.tbImages.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Каталог хранилища";
            // 
            // tbStoragePath
            // 
            this.tbStoragePath.Location = new System.Drawing.Point(526, 63);
            this.tbStoragePath.Name = "tbStoragePath";
            this.tbStoragePath.ReadOnly = true;
            this.tbStoragePath.Size = new System.Drawing.Size(791, 38);
            this.tbStoragePath.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 653);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1515, 318);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btSelectAddValue);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.pbAddValue);
            this.tabPage1.Controls.Add(this.tbAddKey);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.btAddRecord);
            this.tabPage1.Controls.Add(this.nmAddKeysInterval);
            this.tabPage1.Controls.Add(this.cbAddRandomKeys);
            this.tabPage1.Controls.Add(this.btAddRecords);
            this.tabPage1.Controls.Add(this.nmAddRecordCount);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Location = new System.Drawing.Point(10, 48);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1495, 260);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавление";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // nmAddKeysInterval
            // 
            this.nmAddKeysInterval.Enabled = false;
            this.nmAddKeysInterval.Location = new System.Drawing.Point(1049, 35);
            this.nmAddKeysInterval.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nmAddKeysInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmAddKeysInterval.Name = "nmAddKeysInterval";
            this.nmAddKeysInterval.Size = new System.Drawing.Size(234, 38);
            this.nmAddKeysInterval.TabIndex = 4;
            this.nmAddKeysInterval.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // cbAddRandomKeys
            // 
            this.cbAddRandomKeys.AutoSize = true;
            this.cbAddRandomKeys.Location = new System.Drawing.Point(563, 35);
            this.cbAddRandomKeys.Name = "cbAddRandomKeys";
            this.cbAddRandomKeys.Size = new System.Drawing.Size(471, 36);
            this.cbAddRandomKeys.TabIndex = 3;
            this.cbAddRandomKeys.Text = "случайные ключи из диапазона";
            this.cbAddRandomKeys.UseVisualStyleBackColor = true;
            this.cbAddRandomKeys.CheckedChanged += new System.EventHandler(this.cbAddRandomKeys_CheckedChanged);
            // 
            // btAddRecords
            // 
            this.btAddRecords.Location = new System.Drawing.Point(1289, 28);
            this.btAddRecords.Name = "btAddRecords";
            this.btAddRecords.Size = new System.Drawing.Size(196, 50);
            this.btAddRecords.TabIndex = 2;
            this.btAddRecords.Text = "Добавить";
            this.btAddRecords.UseVisualStyleBackColor = true;
            this.btAddRecords.Click += new System.EventHandler(this.btAddRecords_Click);
            // 
            // nmAddRecordCount
            // 
            this.nmAddRecordCount.Location = new System.Drawing.Point(331, 35);
            this.nmAddRecordCount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nmAddRecordCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmAddRecordCount.Name = "nmAddRecordCount";
            this.nmAddRecordCount.Size = new System.Drawing.Size(211, 38);
            this.nmAddRecordCount.TabIndex = 1;
            this.nmAddRecordCount.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(306, 32);
            this.label8.TabIndex = 0;
            this.label8.Text = "Количество операций";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbRemoveKey);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.btRemoveKey);
            this.tabPage2.Controls.Add(this.nmRemoveKeysInterval);
            this.tabPage2.Controls.Add(this.cbRemoveRandomKeys);
            this.tabPage2.Controls.Add(this.btRemoveRecords);
            this.tabPage2.Controls.Add(this.nmRemoveRecordCount);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Location = new System.Drawing.Point(10, 48);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1495, 260);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Удаление";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // nmRemoveKeysInterval
            // 
            this.nmRemoveKeysInterval.Enabled = false;
            this.nmRemoveKeysInterval.Location = new System.Drawing.Point(1049, 35);
            this.nmRemoveKeysInterval.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nmRemoveKeysInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmRemoveKeysInterval.Name = "nmRemoveKeysInterval";
            this.nmRemoveKeysInterval.Size = new System.Drawing.Size(234, 38);
            this.nmRemoveKeysInterval.TabIndex = 9;
            this.nmRemoveKeysInterval.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // cbRemoveRandomKeys
            // 
            this.cbRemoveRandomKeys.AutoSize = true;
            this.cbRemoveRandomKeys.Location = new System.Drawing.Point(563, 35);
            this.cbRemoveRandomKeys.Name = "cbRemoveRandomKeys";
            this.cbRemoveRandomKeys.Size = new System.Drawing.Size(471, 36);
            this.cbRemoveRandomKeys.TabIndex = 8;
            this.cbRemoveRandomKeys.Text = "случайные ключи из диапазона";
            this.cbRemoveRandomKeys.UseVisualStyleBackColor = true;
            this.cbRemoveRandomKeys.CheckedChanged += new System.EventHandler(this.cbRemoveRandomKeys_CheckedChanged);
            // 
            // btRemoveRecords
            // 
            this.btRemoveRecords.Location = new System.Drawing.Point(1289, 28);
            this.btRemoveRecords.Name = "btRemoveRecords";
            this.btRemoveRecords.Size = new System.Drawing.Size(196, 50);
            this.btRemoveRecords.TabIndex = 7;
            this.btRemoveRecords.Text = "Удалить";
            this.btRemoveRecords.UseVisualStyleBackColor = true;
            this.btRemoveRecords.Click += new System.EventHandler(this.btRemoveRecords_Click);
            // 
            // nmRemoveRecordCount
            // 
            this.nmRemoveRecordCount.Location = new System.Drawing.Point(324, 35);
            this.nmRemoveRecordCount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nmRemoveRecordCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmRemoveRecordCount.Name = "nmRemoveRecordCount";
            this.nmRemoveRecordCount.Size = new System.Drawing.Size(214, 38);
            this.nmRemoveRecordCount.TabIndex = 6;
            this.nmRemoveRecordCount.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(306, 32);
            this.label11.TabIndex = 5;
            this.label11.Text = "Количество операций";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.pbFindValue);
            this.tabPage3.Controls.Add(this.tbFindKey);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.btFindRecord);
            this.tabPage3.Controls.Add(this.nmFindKeysInterval);
            this.tabPage3.Controls.Add(this.cbFindRandomKeys);
            this.tabPage3.Controls.Add(this.btFindRecords);
            this.tabPage3.Controls.Add(this.nmFindRecordCount);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Location = new System.Drawing.Point(10, 48);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1495, 260);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Поиск";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btAddRecord
            // 
            this.btAddRecord.Location = new System.Drawing.Point(1289, 91);
            this.btAddRecord.Name = "btAddRecord";
            this.btAddRecord.Size = new System.Drawing.Size(196, 50);
            this.btAddRecord.TabIndex = 5;
            this.btAddRecord.Text = "Добавить";
            this.btAddRecord.UseVisualStyleBackColor = true;
            this.btAddRecord.Click += new System.EventHandler(this.btAddRecord_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(753, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 32);
            this.label12.TabIndex = 6;
            this.label12.Text = "Ключ";
            // 
            // tbAddKey
            // 
            this.tbAddKey.Location = new System.Drawing.Point(845, 98);
            this.tbAddKey.Name = "tbAddKey";
            this.tbAddKey.Size = new System.Drawing.Size(438, 38);
            this.tbAddKey.TabIndex = 7;
            // 
            // pbAddValue
            // 
            this.pbAddValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAddValue.Location = new System.Drawing.Point(442, 79);
            this.pbAddValue.Name = "pbAddValue";
            this.pbAddValue.Size = new System.Drawing.Size(100, 92);
            this.pbAddValue.TabIndex = 8;
            this.pbAddValue.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(279, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 32);
            this.label13.TabIndex = 9;
            this.label13.Text = "Значение";
            // 
            // btSelectAddValue
            // 
            this.btSelectAddValue.Location = new System.Drawing.Point(563, 91);
            this.btSelectAddValue.Name = "btSelectAddValue";
            this.btSelectAddValue.Size = new System.Drawing.Size(161, 50);
            this.btSelectAddValue.TabIndex = 10;
            this.btSelectAddValue.Text = "обзор";
            this.btSelectAddValue.UseVisualStyleBackColor = true;
            this.btSelectAddValue.Click += new System.EventHandler(this.btSelectAddValue_Click);
            // 
            // nmFindKeysInterval
            // 
            this.nmFindKeysInterval.Enabled = false;
            this.nmFindKeysInterval.Location = new System.Drawing.Point(1049, 34);
            this.nmFindKeysInterval.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nmFindKeysInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmFindKeysInterval.Name = "nmFindKeysInterval";
            this.nmFindKeysInterval.Size = new System.Drawing.Size(234, 38);
            this.nmFindKeysInterval.TabIndex = 9;
            this.nmFindKeysInterval.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // cbFindRandomKeys
            // 
            this.cbFindRandomKeys.AutoSize = true;
            this.cbFindRandomKeys.Location = new System.Drawing.Point(563, 34);
            this.cbFindRandomKeys.Name = "cbFindRandomKeys";
            this.cbFindRandomKeys.Size = new System.Drawing.Size(471, 36);
            this.cbFindRandomKeys.TabIndex = 8;
            this.cbFindRandomKeys.Text = "случайные ключи из диапазона";
            this.cbFindRandomKeys.UseVisualStyleBackColor = true;
            this.cbFindRandomKeys.CheckedChanged += new System.EventHandler(this.cbFindRandomKeys_CheckedChanged);
            // 
            // btFindRecords
            // 
            this.btFindRecords.Location = new System.Drawing.Point(1289, 27);
            this.btFindRecords.Name = "btFindRecords";
            this.btFindRecords.Size = new System.Drawing.Size(196, 50);
            this.btFindRecords.TabIndex = 7;
            this.btFindRecords.Text = "Найти";
            this.btFindRecords.UseVisualStyleBackColor = true;
            this.btFindRecords.Click += new System.EventHandler(this.btFindRecords_Click);
            // 
            // nmFindRecordCount
            // 
            this.nmFindRecordCount.Location = new System.Drawing.Point(324, 34);
            this.nmFindRecordCount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nmFindRecordCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmFindRecordCount.Name = "nmFindRecordCount";
            this.nmFindRecordCount.Size = new System.Drawing.Size(218, 38);
            this.nmFindRecordCount.TabIndex = 6;
            this.nmFindRecordCount.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(306, 32);
            this.label14.TabIndex = 5;
            this.label14.Text = "Количество операций";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(279, 100);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(144, 32);
            this.label15.TabIndex = 15;
            this.label15.Text = "Значение";
            // 
            // pbFindValue
            // 
            this.pbFindValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFindValue.Location = new System.Drawing.Point(442, 78);
            this.pbFindValue.Name = "pbFindValue";
            this.pbFindValue.Size = new System.Drawing.Size(100, 92);
            this.pbFindValue.TabIndex = 14;
            this.pbFindValue.TabStop = false;
            // 
            // tbFindKey
            // 
            this.tbFindKey.Location = new System.Drawing.Point(845, 104);
            this.tbFindKey.Name = "tbFindKey";
            this.tbFindKey.Size = new System.Drawing.Size(438, 38);
            this.tbFindKey.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(753, 107);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 32);
            this.label16.TabIndex = 12;
            this.label16.Text = "Ключ";
            // 
            // btFindRecord
            // 
            this.btFindRecord.Location = new System.Drawing.Point(1289, 97);
            this.btFindRecord.Name = "btFindRecord";
            this.btFindRecord.Size = new System.Drawing.Size(196, 50);
            this.btFindRecord.TabIndex = 11;
            this.btFindRecord.Text = "Найти";
            this.btFindRecord.UseVisualStyleBackColor = true;
            this.btFindRecord.Click += new System.EventHandler(this.btFindRecord_Click);
            // 
            // lbTablesSize
            // 
            this.lbTablesSize.AutoSize = true;
            this.lbTablesSize.ForeColor = System.Drawing.Color.Gray;
            this.lbTablesSize.Location = new System.Drawing.Point(747, 396);
            this.lbTablesSize.Name = "lbTablesSize";
            this.lbTablesSize.Size = new System.Drawing.Size(0, 32);
            this.lbTablesSize.TabIndex = 28;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(22, 396);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(292, 32);
            this.label18.TabIndex = 27;
            this.label18.Text = "Размер таблиц, байт";
            // 
            // tbRemoveKey
            // 
            this.tbRemoveKey.Location = new System.Drawing.Point(845, 101);
            this.tbRemoveKey.Name = "tbRemoveKey";
            this.tbRemoveKey.Size = new System.Drawing.Size(438, 38);
            this.tbRemoveKey.TabIndex = 16;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(753, 104);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 32);
            this.label17.TabIndex = 15;
            this.label17.Text = "Ключ";
            // 
            // btRemoveKey
            // 
            this.btRemoveKey.Location = new System.Drawing.Point(1287, 94);
            this.btRemoveKey.Name = "btRemoveKey";
            this.btRemoveKey.Size = new System.Drawing.Size(196, 50);
            this.btRemoveKey.TabIndex = 14;
            this.btRemoveKey.Text = "Удалить";
            this.btRemoveKey.UseVisualStyleBackColor = true;
            this.btRemoveKey.Click += new System.EventHandler(this.btRemoveKey_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1521, 974);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KvStorage";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbFolders.ResumeLayout(false);
            this.gbFolders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmLogLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmIndexLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPartSize)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmAddKeysInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmAddRecordCount)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmRemoveKeysInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmRemoveRecordCount)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFindKeysInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFindRecordCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFindValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbFolders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbImages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbStoragePath;
        private System.Windows.Forms.Button btSelectImagesFolder;
        private System.Windows.Forms.Button btSelectStorageFolder;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.NumericUpDown nmIndexLimit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmPartSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmLogLimit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbFilter;
        private System.Windows.Forms.Button btInitStorage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbLogLimit;
        private System.Windows.Forms.Label lbIndexLimit;
        private System.Windows.Forms.Label lbPartSize;
        private System.Windows.Forms.Label lbIndexSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbIndexCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbTableCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btAddRecords;
        private System.Windows.Forms.NumericUpDown nmAddRecordCount;
        private System.Windows.Forms.CheckBox cbAddRandomKeys;
        private System.Windows.Forms.NumericUpDown nmAddKeysInterval;
        private System.Windows.Forms.NumericUpDown nmRemoveKeysInterval;
        private System.Windows.Forms.CheckBox cbRemoveRandomKeys;
        private System.Windows.Forms.Button btRemoveRecords;
        private System.Windows.Forms.NumericUpDown nmRemoveRecordCount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbAddKey;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btAddRecord;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pbAddValue;
        private System.Windows.Forms.Button btSelectAddValue;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.NumericUpDown nmFindKeysInterval;
        private System.Windows.Forms.CheckBox cbFindRandomKeys;
        private System.Windows.Forms.Button btFindRecords;
        private System.Windows.Forms.NumericUpDown nmFindRecordCount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pbFindValue;
        private System.Windows.Forms.TextBox tbFindKey;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btFindRecord;
        private System.Windows.Forms.Label lbTablesSize;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbRemoveKey;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btRemoveKey;
    }
}

