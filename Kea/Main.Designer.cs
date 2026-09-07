namespace Kea
{
    partial class Main
    {
        /// <summary>
        /// Variable required by the designer.
        /// </summary>
        private System.ComponentModel.IContainer Components = null;

        /// <summary>
        /// Cleaning up used resources.
        /// </summary>
        /// <param name="disposing">true if the managed resources should be deleted; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (Components != null))
            {
                Components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Method required for developer support—do not modify
        /// the contents of this method using the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.HandleBar = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.URLTextbox = new System.Windows.Forms.RichTextBox();
            this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitBtn = new System.Windows.Forms.PictureBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.AddToQueueBtn = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.ProcessInfo = new System.Windows.Forms.TextBox();
            this.QueueGrid = new System.Windows.Forms.DataGridView();
            this.TitleNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleEpBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleEpEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleTranslationLanguageCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleTranslationTeamVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueueTextbox = new System.Windows.Forms.RichTextBox();
            this.SavepathTB = new System.Windows.Forms.TextBox();
            this.SelectFolderBtn = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.CartoonFoldersCB = new System.Windows.Forms.CheckBox();
            this.ChapterFoldersCB = new System.Windows.Forms.CheckBox();
            this.MinimizeBtn = new System.Windows.Forms.PictureBox();
            this.RemoveAllBtn = new System.Windows.Forms.Button();
            this.RemoveSelectedBtn = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.HelpBtn = new System.Windows.Forms.Button();
            this.ToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.SaveAsOption = new System.Windows.Forms.ComboBox();
            this.HighestQualityCB = new System.Windows.Forms.CheckBox();
            this.SkipDownloadedChaptersCB = new System.Windows.Forms.CheckBox();
            this.SettingsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HandleBar)).BeginInit();
            this.ContextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueueGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
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
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.Label1.Location = new System.Drawing.Point(18, 65);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(165, 25);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "enter URLs below";
            // 
            // URLTextbox
            // 
            this.URLTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.URLTextbox.ContextMenuStrip = this.ContextMenuStrip1;
            this.URLTextbox.Location = new System.Drawing.Point(18, 95);
            this.URLTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.URLTextbox.Name = "URLTextbox";
            this.URLTextbox.Size = new System.Drawing.Size(780, 148);
            this.URLTextbox.TabIndex = 3;
            this.URLTextbox.Text = "";
            // 
            // ContextMenuStrip1
            // 
            this.ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PasteToolStripMenuItem});
            this.ContextMenuStrip1.Name = "ContextMenuStrip1";
            this.ContextMenuStrip1.Size = new System.Drawing.Size(137, 40);
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(136, 36);
            this.PasteToolStripMenuItem.Text = "Paste";
            this.PasteToolStripMenuItem.Click += new System.EventHandler(this.CollerToolStripMenuItem_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(14)))));
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.Location = new System.Drawing.Point(765, 0);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(51, 46);
            this.ExitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitBtn.TabIndex = 4;
            this.ExitBtn.TabStop = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            this.ExitBtn.MouseEnter += new System.EventHandler(this.ExitBtn_MouseEnter);
            this.ExitBtn.MouseLeave += new System.EventHandler(this.ExitBtn_MouseLeave);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.Label3.Location = new System.Drawing.Point(14, 312);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(67, 25);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "queue";
            // 
            // StartBtn
            // 
            this.StartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(165)))), ((int)(((byte)(157)))));
            this.StartBtn.FlatAppearance.BorderSize = 0;
            this.StartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.StartBtn.ForeColor = System.Drawing.Color.White;
            this.StartBtn.Location = new System.Drawing.Point(18, 798);
            this.StartBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(780, 40);
            this.StartBtn.TabIndex = 8;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.BackColor = System.Drawing.Color.White;
            this.ProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProgressBar.Location = new System.Drawing.Point(0, 884);
            this.ProgressBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(816, 31);
            this.ProgressBar.Step = 1;
            this.ProgressBar.TabIndex = 10;
            // 
            // AddToQueueBtn
            // 
            this.AddToQueueBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(165)))), ((int)(((byte)(157)))));
            this.AddToQueueBtn.FlatAppearance.BorderSize = 0;
            this.AddToQueueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddToQueueBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToQueueBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.AddToQueueBtn.Location = new System.Drawing.Point(18, 252);
            this.AddToQueueBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddToQueueBtn.Name = "AddToQueueBtn";
            this.AddToQueueBtn.Size = new System.Drawing.Size(183, 40);
            this.AddToQueueBtn.TabIndex = 11;
            this.AddToQueueBtn.Text = "add all to queue";
            this.AddToQueueBtn.UseVisualStyleBackColor = false;
            this.AddToQueueBtn.Click += new System.EventHandler(this.AddToQueueBtn_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.Label4.Location = new System.Drawing.Point(14, 851);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(192, 25);
            this.Label4.TabIndex = 12;
            this.Label4.Text = "currently processing:";
            // 
            // ProcessInfo
            // 
            this.ProcessInfo.Location = new System.Drawing.Point(205, 848);
            this.ProcessInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProcessInfo.Name = "ProcessInfo";
            this.ProcessInfo.ReadOnly = true;
            this.ProcessInfo.Size = new System.Drawing.Size(591, 26);
            this.ProcessInfo.TabIndex = 13;
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
            this.TitleNo,
            this.TitleName,
            this.TitleEpBegin,
            this.TitleEpEnd,
            this.TitleTranslationLanguageCode,
            this.TitleTranslationTeamVersion,
            this.TitleUrl});
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
            // TitleNo
            // 
            this.TitleNo.HeaderText = "Title No.";
            this.TitleNo.MinimumWidth = 8;
            this.TitleNo.Name = "TitleNo";
            this.TitleNo.ReadOnly = true;
            this.TitleNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TitleNo.Width = 80;
            // 
            // TitleName
            // 
            this.TitleName.HeaderText = "Name";
            this.TitleName.MinimumWidth = 8;
            this.TitleName.Name = "TitleName";
            this.TitleName.ReadOnly = true;
            this.TitleName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TitleName.Width = 160;
            // 
            // TitleEpBegin
            // 
            this.TitleEpBegin.HeaderText = "Start at chapter";
            this.TitleEpBegin.MinimumWidth = 8;
            this.TitleEpBegin.Name = "TitleEpBegin";
            this.TitleEpBegin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TitleEpBegin.Width = 150;
            // 
            // TitleEpEnd
            // 
            this.TitleEpEnd.HeaderText = "End at chapter";
            this.TitleEpEnd.MinimumWidth = 8;
            this.TitleEpEnd.Name = "TitleEpEnd";
            this.TitleEpEnd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TitleEpEnd.Width = 150;
            // 
            // TitleTranslationLanguageCode
            // 
            this.TitleTranslationLanguageCode.HeaderText = "Language Code";
            this.TitleTranslationLanguageCode.MinimumWidth = 8;
            this.TitleTranslationLanguageCode.Name = "TitleTranslationLanguageCode";
            this.TitleTranslationLanguageCode.ReadOnly = true;
            this.TitleTranslationLanguageCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TitleTranslationLanguageCode.Width = 150;
            // 
            // TitleTranslationTeamVersion
            // 
            this.TitleTranslationTeamVersion.HeaderText = "Team Version";
            this.TitleTranslationTeamVersion.MinimumWidth = 8;
            this.TitleTranslationTeamVersion.Name = "TitleTranslationTeamVersion";
            this.TitleTranslationTeamVersion.ReadOnly = true;
            this.TitleTranslationTeamVersion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TitleTranslationTeamVersion.Width = 160;
            // 
            // TitleUrl
            // 
            this.TitleUrl.HeaderText = "url";
            this.TitleUrl.MinimumWidth = 8;
            this.TitleUrl.Name = "TitleUrl";
            this.TitleUrl.ReadOnly = true;
            this.TitleUrl.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TitleUrl.Visible = false;
            this.TitleUrl.Width = 150;
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
            // SavepathTB
            // 
            this.SavepathTB.Location = new System.Drawing.Point(18, 611);
            this.SavepathTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SavepathTB.Name = "SavepathTB";
            this.SavepathTB.ReadOnly = true;
            this.SavepathTB.Size = new System.Drawing.Size(722, 26);
            this.SavepathTB.TabIndex = 15;
            // 
            // SelectFolderBtn
            // 
            this.SelectFolderBtn.BackColor = System.Drawing.Color.White;
            this.SelectFolderBtn.FlatAppearance.BorderSize = 0;
            this.SelectFolderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectFolderBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14F, System.Drawing.FontStyle.Bold);
            this.SelectFolderBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SelectFolderBtn.Location = new System.Drawing.Point(752, 606);
            this.SelectFolderBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SelectFolderBtn.Name = "SelectFolderBtn";
            this.SelectFolderBtn.Size = new System.Drawing.Size(46, 40);
            this.SelectFolderBtn.TabIndex = 16;
            this.SelectFolderBtn.Text = "";
            this.SelectFolderBtn.UseVisualStyleBackColor = false;
            this.SelectFolderBtn.Click += new System.EventHandler(this.SelectFolderBtn_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.Label2.Location = new System.Drawing.Point(14, 662);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(179, 25);
            this.Label2.TabIndex = 17;
            this.Label2.Text = "use sub-folders for:";
            // 
            // CartoonFoldersCB
            // 
            this.CartoonFoldersCB.AutoSize = true;
            this.CartoonFoldersCB.Checked = true;
            this.CartoonFoldersCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CartoonFoldersCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartoonFoldersCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.CartoonFoldersCB.Location = new System.Drawing.Point(231, 660);
            this.CartoonFoldersCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CartoonFoldersCB.Name = "CartoonFoldersCB";
            this.CartoonFoldersCB.Size = new System.Drawing.Size(151, 29);
            this.CartoonFoldersCB.TabIndex = 18;
            this.CartoonFoldersCB.Text = "each cartoon";
            this.CartoonFoldersCB.UseVisualStyleBackColor = true;
            // 
            // ChapterFoldersCB
            // 
            this.ChapterFoldersCB.AutoSize = true;
            this.ChapterFoldersCB.Enabled = false;
            this.ChapterFoldersCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChapterFoldersCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.ChapterFoldersCB.Location = new System.Drawing.Point(420, 660);
            this.ChapterFoldersCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChapterFoldersCB.Name = "ChapterFoldersCB";
            this.ChapterFoldersCB.Size = new System.Drawing.Size(151, 29);
            this.ChapterFoldersCB.TabIndex = 19;
            this.ChapterFoldersCB.Text = "each chapter";
            this.ChapterFoldersCB.UseVisualStyleBackColor = true;
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(14)))));
            this.MinimizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MinimizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeBtn.Image")));
            this.MinimizeBtn.Location = new System.Drawing.Point(716, 0);
            this.MinimizeBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(51, 46);
            this.MinimizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizeBtn.TabIndex = 20;
            this.MinimizeBtn.TabStop = false;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            this.MinimizeBtn.MouseEnter += new System.EventHandler(this.MinimizeBtn_MouseEnter);
            this.MinimizeBtn.MouseLeave += new System.EventHandler(this.MinimizeBtn_MouseLeave);
            // 
            // RemoveAllBtn
            // 
            this.RemoveAllBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(165)))), ((int)(((byte)(157)))));
            this.RemoveAllBtn.FlatAppearance.BorderSize = 0;
            this.RemoveAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveAllBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.RemoveAllBtn.Location = new System.Drawing.Point(614, 252);
            this.RemoveAllBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RemoveAllBtn.Name = "RemoveAllBtn";
            this.RemoveAllBtn.Size = new System.Drawing.Size(184, 40);
            this.RemoveAllBtn.TabIndex = 21;
            this.RemoveAllBtn.Text = "remove all";
            this.RemoveAllBtn.UseVisualStyleBackColor = false;
            this.RemoveAllBtn.Click += new System.EventHandler(this.RemoveAllBtn_Click);
            // 
            // RemoveSelectedBtn
            // 
            this.RemoveSelectedBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(165)))), ((int)(((byte)(157)))));
            this.RemoveSelectedBtn.FlatAppearance.BorderSize = 0;
            this.RemoveSelectedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveSelectedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveSelectedBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.RemoveSelectedBtn.Location = new System.Drawing.Point(420, 252);
            this.RemoveSelectedBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RemoveSelectedBtn.Name = "RemoveSelectedBtn";
            this.RemoveSelectedBtn.Size = new System.Drawing.Size(184, 40);
            this.RemoveSelectedBtn.TabIndex = 22;
            this.RemoveSelectedBtn.Text = "remove selected";
            this.RemoveSelectedBtn.UseVisualStyleBackColor = false;
            this.RemoveSelectedBtn.Click += new System.EventHandler(this.RemoveSelectedBtn_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.Label5.Location = new System.Drawing.Point(14, 703);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(166, 25);
            this.Label5.TabIndex = 23;
            this.Label5.Text = "save chapters as:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.Label6.Location = new System.Drawing.Point(14, 583);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(75, 25);
            this.Label6.TabIndex = 26;
            this.Label6.Text = "options";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(14)))));
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(66, 9);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(148, 25);
            this.Label7.TabIndex = 27;
            this.Label7.Text = "AdvancedKea";
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(14)))));
            this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(12, 0);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(45, 46);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 28;
            this.PictureBox1.TabStop = false;
            // 
            // HelpBtn
            // 
            this.HelpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(193)))), ((int)(((byte)(185)))));
            this.HelpBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.HelpBtn.FlatAppearance.BorderSize = 0;
            this.HelpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.HelpBtn.Location = new System.Drawing.Point(566, 55);
            this.HelpBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HelpBtn.Size = new System.Drawing.Size(232, 40);
            this.HelpBtn.TabIndex = 29;
            this.HelpBtn.Text = "help, how do I use this ?";
            this.HelpBtn.UseVisualStyleBackColor = false;
            this.HelpBtn.Click += new System.EventHandler(this.HelpBtn_Click);
            // 
            // SaveAsOption
            // 
            this.SaveAsOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.SaveAsOption.FormattingEnabled = true;
            this.SaveAsOption.Items.AddRange(new object[] {
            "PDF file",
            "CBZ file",
            "multiple images",
            "one image (may be lower in quality)"});
            this.SaveAsOption.Location = new System.Drawing.Point(231, 700);
            this.SaveAsOption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveAsOption.Name = "SaveAsOption";
            this.SaveAsOption.Size = new System.Drawing.Size(343, 32);
            this.SaveAsOption.TabIndex = 30;
            this.SaveAsOption.Text = "PDF file";
            this.SaveAsOption.SelectedIndexChanged += new System.EventHandler(this.SaveAsOption_SelectedIndexChanged);
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
            // SkipDownloadedChaptersCB
            // 
            this.SkipDownloadedChaptersCB.AutoSize = true;
            this.SkipDownloadedChaptersCB.Checked = true;
            this.SkipDownloadedChaptersCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SkipDownloadedChaptersCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkipDownloadedChaptersCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.SkipDownloadedChaptersCB.Location = new System.Drawing.Point(231, 746);
            this.SkipDownloadedChaptersCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SkipDownloadedChaptersCB.Name = "SkipDownloadedChaptersCB";
            this.SkipDownloadedChaptersCB.Size = new System.Drawing.Size(268, 29);
            this.SkipDownloadedChaptersCB.TabIndex = 32;
            this.SkipDownloadedChaptersCB.Text = "Skip downloaded chapters";
            this.SkipDownloadedChaptersCB.UseVisualStyleBackColor = true;
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.BackColor = System.Drawing.Color.White;
            this.SettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14F);
            this.SettingsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SettingsBtn.Location = new System.Drawing.Point(752, 654);
            this.SettingsBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.SettingsBtn.Size = new System.Drawing.Size(46, 46);
            this.SettingsBtn.TabIndex = 33;
            this.SettingsBtn.Text = "";
            this.SettingsBtn.UseVisualStyleBackColor = false;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(193)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(816, 915);
            this.Controls.Add(this.SettingsBtn);
            this.Controls.Add(this.SkipDownloadedChaptersCB);
            this.Controls.Add(this.HighestQualityCB);
            this.Controls.Add(this.SaveAsOption);
            this.Controls.Add(this.HelpBtn);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.RemoveSelectedBtn);
            this.Controls.Add(this.RemoveAllBtn);
            this.Controls.Add(this.MinimizeBtn);
            this.Controls.Add(this.ChapterFoldersCB);
            this.Controls.Add(this.CartoonFoldersCB);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.SelectFolderBtn);
            this.Controls.Add(this.SavepathTB);
            this.Controls.Add(this.QueueGrid);
            this.Controls.Add(this.ProcessInfo);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.AddToQueueBtn);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.QueueTextbox);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.URLTextbox);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.HandleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "Kea";
            ((System.ComponentModel.ISupportInitialize)(this.HandleBar)).EndInit();
            this.ContextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueueGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox HandleBar;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.RichTextBox URLTextbox;
        private System.Windows.Forms.PictureBox ExitBtn;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Button AddToQueueBtn;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.TextBox ProcessInfo;
        private System.Windows.Forms.DataGridView QueueGrid;
        private System.Windows.Forms.RichTextBox QueueTextbox;
        private System.Windows.Forms.TextBox SavepathTB;
        private System.Windows.Forms.Button SelectFolderBtn;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.CheckBox CartoonFoldersCB;
        private System.Windows.Forms.CheckBox ChapterFoldersCB;
        private System.Windows.Forms.PictureBox MinimizeBtn;
        private System.Windows.Forms.Button RemoveAllBtn;
        private System.Windows.Forms.Button RemoveSelectedBtn;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Button HelpBtn;
        private System.Windows.Forms.ToolTip ToolTips;
        private System.Windows.Forms.ComboBox SaveAsOption;
        private System.Windows.Forms.CheckBox HighestQualityCB;
        private System.Windows.Forms.CheckBox SkipDownloadedChaptersCB;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Button SettingsBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleEpBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleEpEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleTranslationLanguageCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleTranslationTeamVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleUrl;
    }
}
