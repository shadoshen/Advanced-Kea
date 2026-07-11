namespace Kea
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.HandleBar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.URLTextbox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.collerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitBtn = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.addToQueueBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.processInfo = new System.Windows.Forms.TextBox();
            this.QueueGrid = new System.Windows.Forms.DataGridView();
            this.titleNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleEpBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleEpEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleTranslationLanguageCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleTranslationTeamVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueueTextbox = new System.Windows.Forms.RichTextBox();
            this.savepathTB = new System.Windows.Forms.TextBox();
            this.selectFolderBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cartoonFoldersCB = new System.Windows.Forms.CheckBox();
            this.chapterFoldersCB = new System.Windows.Forms.CheckBox();
            this.minimizeBtn = new System.Windows.Forms.PictureBox();
            this.removeAllBtn = new System.Windows.Forms.Button();
            this.removeSelectedBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.helpBtn = new System.Windows.Forms.Button();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.saveAsOption = new System.Windows.Forms.ComboBox();
            this.HighestQualityCB = new System.Windows.Forms.CheckBox();
            this.skipDownloadedChaptersCB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.HandleBar)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueueGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HandleBar
            // 
            this.HandleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(14)))));
            this.HandleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.HandleBar.Location = new System.Drawing.Point(0, 0);
            this.HandleBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HandleBar.Name = "HandleBar";
            this.HandleBar.Size = new System.Drawing.Size(816, 46);
            this.HandleBar.TabIndex = 0;
            this.HandleBar.TabStop = false;
            this.HandleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HandleBar_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(18, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "enter URLs below";
            // 
            // URLTextbox
            // 
            this.URLTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.URLTextbox.ContextMenuStrip = this.contextMenuStrip1;
            this.URLTextbox.Location = new System.Drawing.Point(18, 95);
            this.URLTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.URLTextbox.Name = "URLTextbox";
            this.URLTextbox.Size = new System.Drawing.Size(780, 148);
            this.URLTextbox.TabIndex = 3;
            this.URLTextbox.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.collerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(144, 40);
            // 
            // collerToolStripMenuItem
            // 
            this.collerToolStripMenuItem.Name = "collerToolStripMenuItem";
            this.collerToolStripMenuItem.Size = new System.Drawing.Size(143, 36);
            this.collerToolStripMenuItem.Text = "Coller";
            this.collerToolStripMenuItem.Click += new System.EventHandler(this.collerToolStripMenuItem_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(14)))));
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.Location = new System.Drawing.Point(765, 0);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(51, 46);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.TabStop = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            this.exitBtn.MouseEnter += new System.EventHandler(this.exitBtn_MouseEnter);
            this.exitBtn.MouseLeave += new System.EventHandler(this.exitBtn_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.label3.Location = new System.Drawing.Point(14, 312);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "queue";
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(165)))), ((int)(((byte)(157)))));
            this.startBtn.FlatAppearance.BorderSize = 0;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.startBtn.Location = new System.Drawing.Point(18, 798);
            this.startBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(780, 40);
            this.startBtn.TabIndex = 8;
            this.startBtn.Text = "start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.White;
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(0, 884);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(816, 31);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 10;
            // 
            // addToQueueBtn
            // 
            this.addToQueueBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(165)))), ((int)(((byte)(157)))));
            this.addToQueueBtn.FlatAppearance.BorderSize = 0;
            this.addToQueueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToQueueBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToQueueBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.addToQueueBtn.Location = new System.Drawing.Point(18, 252);
            this.addToQueueBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addToQueueBtn.Name = "addToQueueBtn";
            this.addToQueueBtn.Size = new System.Drawing.Size(183, 40);
            this.addToQueueBtn.TabIndex = 11;
            this.addToQueueBtn.Text = "add all to queue";
            this.addToQueueBtn.UseVisualStyleBackColor = false;
            this.addToQueueBtn.Click += new System.EventHandler(this.addToQueueBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.label4.Location = new System.Drawing.Point(14, 851);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "currently processing:";
            // 
            // processInfo
            // 
            this.processInfo.Location = new System.Drawing.Point(231, 848);
            this.processInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.processInfo.Name = "processInfo";
            this.processInfo.ReadOnly = true;
            this.processInfo.Size = new System.Drawing.Size(565, 26);
            this.processInfo.TabIndex = 13;
            // 
            // QueueGrid
            // 
            this.QueueGrid.AllowUserToAddRows = false;
            this.QueueGrid.AllowUserToDeleteRows = false;
            this.QueueGrid.AllowUserToResizeRows = false;
            this.QueueGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(165)))), ((int)(((byte)(157)))));
            this.QueueGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QueueGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.QueueGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QueueGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleNo,
            this.titleName,
            this.titleEpBegin,
            this.titleEpEnd,
            this.titleTranslationLanguageCode,
            this.titleTranslationTeamVersion,
            this.titleUrl});
            this.QueueGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.QueueGrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.QueueGrid.Location = new System.Drawing.Point(18, 340);
            this.QueueGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.QueueGrid.MultiSelect = false;
            this.QueueGrid.Name = "QueueGrid";
            this.QueueGrid.RowHeadersWidth = 62;
            this.QueueGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.QueueGrid.Size = new System.Drawing.Size(780, 225);
            this.QueueGrid.TabIndex = 14;
            // 
            // titleNo
            // 
            this.titleNo.HeaderText = "Title No.";
            this.titleNo.MinimumWidth = 8;
            this.titleNo.Name = "titleNo";
            this.titleNo.ReadOnly = true;
            this.titleNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.titleNo.Width = 80;
            // 
            // titleName
            // 
            this.titleName.HeaderText = "Name";
            this.titleName.MinimumWidth = 8;
            this.titleName.Name = "titleName";
            this.titleName.ReadOnly = true;
            this.titleName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.titleName.Width = 160;
            // 
            // titleEpBegin
            // 
            this.titleEpBegin.HeaderText = "start at chapter";
            this.titleEpBegin.MinimumWidth = 8;
            this.titleEpBegin.Name = "titleEpBegin";
            this.titleEpBegin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.titleEpBegin.Width = 150;
            // 
            // titleEpEnd
            // 
            this.titleEpEnd.HeaderText = "End at chapter";
            this.titleEpEnd.MinimumWidth = 8;
            this.titleEpEnd.Name = "titleEpEnd";
            this.titleEpEnd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.titleEpEnd.Width = 150;
            // 
            // titleTranslationLanguageCode
            // 
            this.titleTranslationLanguageCode.HeaderText = "Language Code";
            this.titleTranslationLanguageCode.MinimumWidth = 8;
            this.titleTranslationLanguageCode.Name = "titleTranslationLanguageCode";
            this.titleTranslationLanguageCode.ReadOnly = true;
            this.titleTranslationLanguageCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.titleTranslationLanguageCode.Width = 150;
            // 
            // titleTranslationTeamVersion
            // 
            this.titleTranslationTeamVersion.HeaderText = "Team Version";
            this.titleTranslationTeamVersion.MinimumWidth = 8;
            this.titleTranslationTeamVersion.Name = "titleTranslationTeamVersion";
            this.titleTranslationTeamVersion.ReadOnly = true;
            this.titleTranslationTeamVersion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.titleTranslationTeamVersion.Width = 160;
            // 
            // titleUrl
            // 
            this.titleUrl.HeaderText = "url";
            this.titleUrl.MinimumWidth = 8;
            this.titleUrl.Name = "titleUrl";
            this.titleUrl.ReadOnly = true;
            this.titleUrl.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.titleUrl.Visible = false;
            this.titleUrl.Width = 150;
            // 
            // QueueTextbox
            // 
            this.QueueTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QueueTextbox.Location = new System.Drawing.Point(18, 340);
            this.QueueTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.QueueTextbox.Name = "QueueTextbox";
            this.QueueTextbox.ReadOnly = true;
            this.QueueTextbox.Size = new System.Drawing.Size(780, 97);
            this.QueueTextbox.TabIndex = 7;
            this.QueueTextbox.Text = "";
            this.QueueTextbox.Visible = false;
            // 
            // savepathTB
            // 
            this.savepathTB.Location = new System.Drawing.Point(18, 611);
            this.savepathTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.savepathTB.Name = "savepathTB";
            this.savepathTB.ReadOnly = true;
            this.savepathTB.Size = new System.Drawing.Size(722, 26);
            this.savepathTB.TabIndex = 15;
            // 
            // selectFolderBtn
            // 
            this.selectFolderBtn.BackColor = System.Drawing.Color.White;
            this.selectFolderBtn.FlatAppearance.BorderSize = 0;
            this.selectFolderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectFolderBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11.25F, System.Drawing.FontStyle.Bold);
            this.selectFolderBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.selectFolderBtn.Image = ((System.Drawing.Image)(resources.GetObject("selectFolderBtn.Image")));
            this.selectFolderBtn.Location = new System.Drawing.Point(752, 606);
            this.selectFolderBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selectFolderBtn.Name = "selectFolderBtn";
            this.selectFolderBtn.Size = new System.Drawing.Size(46, 40);
            this.selectFolderBtn.TabIndex = 16;
            this.selectFolderBtn.UseVisualStyleBackColor = false;
            this.selectFolderBtn.Click += new System.EventHandler(this.selectFolderBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.label2.Location = new System.Drawing.Point(14, 662);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "use sub-folders for:";
            // 
            // cartoonFoldersCB
            // 
            this.cartoonFoldersCB.AutoSize = true;
            this.cartoonFoldersCB.Checked = true;
            this.cartoonFoldersCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cartoonFoldersCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartoonFoldersCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.cartoonFoldersCB.Location = new System.Drawing.Point(231, 660);
            this.cartoonFoldersCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cartoonFoldersCB.Name = "cartoonFoldersCB";
            this.cartoonFoldersCB.Size = new System.Drawing.Size(151, 29);
            this.cartoonFoldersCB.TabIndex = 18;
            this.cartoonFoldersCB.Text = "each cartoon";
            this.cartoonFoldersCB.UseVisualStyleBackColor = true;
            // 
            // chapterFoldersCB
            // 
            this.chapterFoldersCB.AutoSize = true;
            this.chapterFoldersCB.Enabled = false;
            this.chapterFoldersCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chapterFoldersCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.chapterFoldersCB.Location = new System.Drawing.Point(420, 660);
            this.chapterFoldersCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chapterFoldersCB.Name = "chapterFoldersCB";
            this.chapterFoldersCB.Size = new System.Drawing.Size(151, 29);
            this.chapterFoldersCB.TabIndex = 19;
            this.chapterFoldersCB.Text = "each chapter";
            this.chapterFoldersCB.UseVisualStyleBackColor = true;
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(14)))));
            this.minimizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.minimizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("minimizeBtn.Image")));
            this.minimizeBtn.Location = new System.Drawing.Point(716, 0);
            this.minimizeBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(51, 46);
            this.minimizeBtn.TabIndex = 20;
            this.minimizeBtn.TabStop = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            this.minimizeBtn.MouseEnter += new System.EventHandler(this.minimizeBtn_MouseEnter);
            this.minimizeBtn.MouseLeave += new System.EventHandler(this.minimizeBtn_MouseLeave);
            // 
            // removeAllBtn
            // 
            this.removeAllBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(165)))), ((int)(((byte)(157)))));
            this.removeAllBtn.FlatAppearance.BorderSize = 0;
            this.removeAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeAllBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.removeAllBtn.Location = new System.Drawing.Point(614, 252);
            this.removeAllBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.removeAllBtn.Name = "removeAllBtn";
            this.removeAllBtn.Size = new System.Drawing.Size(184, 40);
            this.removeAllBtn.TabIndex = 21;
            this.removeAllBtn.Text = "remove all";
            this.removeAllBtn.UseVisualStyleBackColor = false;
            this.removeAllBtn.Click += new System.EventHandler(this.removeAllBtn_Click);
            // 
            // removeSelectedBtn
            // 
            this.removeSelectedBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(165)))), ((int)(((byte)(157)))));
            this.removeSelectedBtn.FlatAppearance.BorderSize = 0;
            this.removeSelectedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSelectedBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.removeSelectedBtn.Location = new System.Drawing.Point(420, 252);
            this.removeSelectedBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.removeSelectedBtn.Name = "removeSelectedBtn";
            this.removeSelectedBtn.Size = new System.Drawing.Size(184, 40);
            this.removeSelectedBtn.TabIndex = 22;
            this.removeSelectedBtn.Text = "remove selected";
            this.removeSelectedBtn.UseVisualStyleBackColor = false;
            this.removeSelectedBtn.Click += new System.EventHandler(this.removeSelectedBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.label5.Location = new System.Drawing.Point(14, 703);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "save chapters as:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.label6.Location = new System.Drawing.Point(14, 583);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "options";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(14)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(66, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 25);
            this.label7.TabIndex = 27;
            this.label7.Text = "AdvancedKea";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(14)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 46);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // helpBtn
            // 
            this.helpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(193)))), ((int)(((byte)(185)))));
            this.helpBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.helpBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.helpBtn.FlatAppearance.BorderSize = 0;
            this.helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.helpBtn.Location = new System.Drawing.Point(566, 55);
            this.helpBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.helpBtn.Size = new System.Drawing.Size(232, 40);
            this.helpBtn.TabIndex = 29;
            this.helpBtn.Text = "help, how do I use this ?";
            this.helpBtn.UseVisualStyleBackColor = false;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // saveAsOption
            // 
            this.saveAsOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.saveAsOption.FormattingEnabled = true;
            this.saveAsOption.Items.AddRange(new object[] {
            "PDF file",
            "CBZ file",
            "multiple images",
            "one image (may be lower in quality)"});
            this.saveAsOption.Location = new System.Drawing.Point(231, 700);
            this.saveAsOption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveAsOption.Name = "saveAsOption";
            this.saveAsOption.Size = new System.Drawing.Size(343, 32);
            this.saveAsOption.TabIndex = 30;
            this.saveAsOption.Text = "PDF file";
            this.saveAsOption.SelectedIndexChanged += new System.EventHandler(this.saveAsOption_SelectedIndexChanged);
            // 
            // HighestQualityCB
            // 
            this.HighestQualityCB.AutoSize = true;
            this.HighestQualityCB.Checked = true;
            this.HighestQualityCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HighestQualityCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighestQualityCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.HighestQualityCB.Location = new System.Drawing.Point(585, 705);
            this.HighestQualityCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HighestQualityCB.Name = "HighestQualityCB";
            this.HighestQualityCB.Size = new System.Drawing.Size(170, 29);
            this.HighestQualityCB.TabIndex = 31;
            this.HighestQualityCB.Text = "Highest Quality";
            this.HighestQualityCB.UseVisualStyleBackColor = true;
            // 
            // skipDownloadedChaptersCB
            // 
            this.skipDownloadedChaptersCB.AutoSize = true;
            this.skipDownloadedChaptersCB.Checked = true;
            this.skipDownloadedChaptersCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.skipDownloadedChaptersCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skipDownloadedChaptersCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.skipDownloadedChaptersCB.Location = new System.Drawing.Point(231, 746);
            this.skipDownloadedChaptersCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.skipDownloadedChaptersCB.Name = "skipDownloadedChaptersCB";
            this.skipDownloadedChaptersCB.Size = new System.Drawing.Size(268, 29);
            this.skipDownloadedChaptersCB.TabIndex = 32;
            this.skipDownloadedChaptersCB.Text = "Skip downloaded chapters";
            this.skipDownloadedChaptersCB.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(193)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(816, 915);
            this.Controls.Add(this.skipDownloadedChaptersCB);
            this.Controls.Add(this.HighestQualityCB);
            this.Controls.Add(this.saveAsOption);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.removeSelectedBtn);
            this.Controls.Add(this.removeAllBtn);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.chapterFoldersCB);
            this.Controls.Add(this.cartoonFoldersCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectFolderBtn);
            this.Controls.Add(this.savepathTB);
            this.Controls.Add(this.QueueGrid);
            this.Controls.Add(this.processInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addToQueueBtn);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.QueueTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.URLTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HandleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "Kea";
            ((System.ComponentModel.ISupportInitialize)(this.HandleBar)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueueGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox HandleBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox URLTextbox;
        private System.Windows.Forms.PictureBox exitBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button addToQueueBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox processInfo;
        private System.Windows.Forms.DataGridView QueueGrid;
        private System.Windows.Forms.RichTextBox QueueTextbox;
        private System.Windows.Forms.TextBox savepathTB;
        private System.Windows.Forms.Button selectFolderBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cartoonFoldersCB;
        private System.Windows.Forms.CheckBox chapterFoldersCB;
        private System.Windows.Forms.PictureBox minimizeBtn;
        private System.Windows.Forms.Button removeAllBtn;
        private System.Windows.Forms.Button removeSelectedBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.ToolTip toolTips;
        private System.Windows.Forms.ComboBox saveAsOption;
        private System.Windows.Forms.CheckBox HighestQualityCB;
        private System.Windows.Forms.CheckBox skipDownloadedChaptersCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleTranslationLanguageCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleTranslationTeamVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleEpEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleEpBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleNo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem collerToolStripMenuItem;
    }
}

