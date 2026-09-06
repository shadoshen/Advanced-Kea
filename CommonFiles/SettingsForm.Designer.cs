using System.Drawing;

namespace Kea
{
    partial class SettingsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.handleBar = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.gbUserAgent = new System.Windows.Forms.GroupBox();
            this.rbFirefox = new System.Windows.Forms.RadioButton();
            this.lblFirefox = new System.Windows.Forms.Label();
            this.txtFirefox = new System.Windows.Forms.TextBox();
            this.rbChrome = new System.Windows.Forms.RadioButton();
            this.lblChrome = new System.Windows.Forms.Label();
            this.txtChrome = new System.Windows.Forms.TextBox();
            this.btnUpdateGitHub = new System.Windows.Forms.Button();
            this.lblGlobeIcon = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.handleBar.SuspendLayout();
            this.gbUserAgent.SuspendLayout();
            this.btnUpdateGitHub.SuspendLayout();
            this.SuspendLayout();
            // 
            // handleBar
            // 
            this.handleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(14)))));
            this.handleBar.Controls.Add(this.titleLabel);
            this.handleBar.Controls.Add(this.exitBtn);
            this.handleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.handleBar.Location = new System.Drawing.Point(0, 0);
            this.handleBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.handleBar.Name = "handleBar";
            this.handleBar.Size = new System.Drawing.Size(975, 54);
            this.handleBar.TabIndex = 0;
            this.handleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HandleBar_MouseDown);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(15, 12);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(349, 28);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "AdvancedKea - User-Agent Settings";
            this.titleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HandleBar_MouseDown);
            // 
            // exitBtn
            // 
            this.exitBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(923, 0);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(52, 54);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "✕";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // gbUserAgent
            // 
            this.gbUserAgent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(193)))), ((int)(((byte)(185)))));
            this.gbUserAgent.Controls.Add(this.rbFirefox);
            this.gbUserAgent.Controls.Add(this.lblFirefox);
            this.gbUserAgent.Controls.Add(this.txtFirefox);
            this.gbUserAgent.Controls.Add(this.rbChrome);
            this.gbUserAgent.Controls.Add(this.lblChrome);
            this.gbUserAgent.Controls.Add(this.txtChrome);
            this.gbUserAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.gbUserAgent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.gbUserAgent.Location = new System.Drawing.Point(30, 77);
            this.gbUserAgent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbUserAgent.Name = "gbUserAgent";
            this.gbUserAgent.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbUserAgent.Size = new System.Drawing.Size(915, 338);
            this.gbUserAgent.TabIndex = 1;
            this.gbUserAgent.TabStop = false;
            this.gbUserAgent.Text = "User-Agent Spoofing Setting";
            // 
            // rbFirefox
            // 
            this.rbFirefox.AutoSize = true;
            this.rbFirefox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.rbFirefox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.rbFirefox.Location = new System.Drawing.Point(30, 46);
            this.rbFirefox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbFirefox.Name = "rbFirefox";
            this.rbFirefox.Size = new System.Drawing.Size(273, 29);
            this.rbFirefox.TabIndex = 0;
            this.rbFirefox.TabStop = true;
            this.rbFirefox.Text = "Use the Firefox User-Agent";
            this.rbFirefox.UseVisualStyleBackColor = true;
            // 
            // lblFirefox
            // 
            this.lblFirefox.AutoSize = true;
            this.lblFirefox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.lblFirefox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.lblFirefox.Location = new System.Drawing.Point(30, 85);
            this.lblFirefox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirefox.Name = "lblFirefox";
            this.lblFirefox.Size = new System.Drawing.Size(129, 25);
            this.lblFirefox.TabIndex = 1;
            this.lblFirefox.Text = "Firefox string:";
            // 
            // txtFirefox
            // 
            this.txtFirefox.BackColor = System.Drawing.SystemColors.Control;
            this.txtFirefox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirefox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.txtFirefox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFirefox.Location = new System.Drawing.Point(30, 115);
            this.txtFirefox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFirefox.Name = "txtFirefox";
            this.txtFirefox.Size = new System.Drawing.Size(854, 30);
            this.txtFirefox.TabIndex = 2;
            // 
            // rbChrome
            // 
            this.rbChrome.AutoSize = true;
            this.rbChrome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.rbChrome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.rbChrome.Location = new System.Drawing.Point(30, 177);
            this.rbChrome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbChrome.Name = "rbChrome";
            this.rbChrome.Size = new System.Drawing.Size(284, 29);
            this.rbChrome.TabIndex = 3;
            this.rbChrome.TabStop = true;
            this.rbChrome.Text = "Use the Chrome User-Agent";
            this.rbChrome.UseVisualStyleBackColor = true;
            // 
            // lblChrome
            // 
            this.lblChrome.AutoSize = true;
            this.lblChrome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.lblChrome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(36)))));
            this.lblChrome.Location = new System.Drawing.Point(30, 215);
            this.lblChrome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChrome.Name = "lblChrome";
            this.lblChrome.Size = new System.Drawing.Size(140, 25);
            this.lblChrome.TabIndex = 4;
            this.lblChrome.Text = "Chrome string:";
            // 
            // txtChrome
            // 
            this.txtChrome.BackColor = System.Drawing.SystemColors.Control;
            this.txtChrome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChrome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.txtChrome.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtChrome.Location = new System.Drawing.Point(30, 246);
            this.txtChrome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChrome.Name = "txtChrome";
            this.txtChrome.Size = new System.Drawing.Size(854, 30);
            this.txtChrome.TabIndex = 5;
            // 
            // btnUpdateGitHub
            // 
            this.btnUpdateGitHub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(165)))), ((int)(((byte)(157)))));
            this.btnUpdateGitHub.Controls.Add(this.lblGlobeIcon);
            this.btnUpdateGitHub.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(50)))));
            this.btnUpdateGitHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateGitHub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.btnUpdateGitHub.ForeColor = System.Drawing.Color.White;
            this.btnUpdateGitHub.Location = new System.Drawing.Point(30, 446);
            this.btnUpdateGitHub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateGitHub.Name = "btnUpdateGitHub";
            this.btnUpdateGitHub.Padding = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.btnUpdateGitHub.Size = new System.Drawing.Size(270, 62);
            this.btnUpdateGitHub.TabIndex = 2;
            this.btnUpdateGitHub.Text = "GitHub Update!";
            this.btnUpdateGitHub.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateGitHub.UseVisualStyleBackColor = false;
            this.btnUpdateGitHub.Click += new System.EventHandler(this.BtnUpdateGitHub_Click);
            // 
            // lblGlobeIcon
            // 
            this.lblGlobeIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblGlobeIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGlobeIcon.ForeColor = System.Drawing.Color.White;
            this.lblGlobeIcon.Location = new System.Drawing.Point(20, 5);
            this.lblGlobeIcon.Name = "lblGlobeIcon";
            this.lblGlobeIcon.Size = new System.Drawing.Size(42, 42);
            this.lblGlobeIcon.TabIndex = 6;
            this.lblGlobeIcon.Text = "🌐";
            this.lblGlobeIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGlobeIcon.Click += new System.EventHandler(this.BtnUpdateGitHub_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.LightGray;
            this.lblStatus.Location = new System.Drawing.Point(308, 446);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(300, 62);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(165)))), ((int)(((byte)(157)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(60)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(615, 446);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(165, 62);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(138)))), ((int)(((byte)(130)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(795, 446);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 62);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(193)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(975, 554);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdateGitHub);
            this.Controls.Add(this.gbUserAgent);
            this.Controls.Add(this.handleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SettingsForm";
            this.handleBar.ResumeLayout(false);
            this.handleBar.PerformLayout();
            this.gbUserAgent.ResumeLayout(false);
            this.gbUserAgent.PerformLayout();
            this.btnUpdateGitHub.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel handleBar;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.GroupBox gbUserAgent;
        private System.Windows.Forms.RadioButton rbFirefox;
        private System.Windows.Forms.Label lblFirefox;
        private System.Windows.Forms.TextBox txtFirefox;
        private System.Windows.Forms.RadioButton rbChrome;
        private System.Windows.Forms.Label lblChrome;
        private System.Windows.Forms.TextBox txtChrome;
        private System.Windows.Forms.Button btnUpdateGitHub;
        private System.Windows.Forms.Label lblGlobeIcon;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
