using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kea.CommonFiles;

namespace Kea
{
    public partial class SettingsForm : Form
    {
        // Win32 DLL import for borderless moving
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public const int WmNclButtonDown = 0xA1;
        public const int HtCaption = 0x2;

        public SettingsForm()
        {
            InitializeComponent();
            LoadCurrentSettings();
        }

        private void LoadCurrentSettings()
        {
            txtFirefox.Text = Globals.FirefoxUserAgent;
            txtChrome.Text = Globals.ChromeUserAgent;
            rbFirefox.Checked = Globals.UseFirefox;
            rbChrome.Checked = !Globals.UseFirefox;
        }

        private void HandleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WmNclButtonDown, HtCaption, 0);
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            Globals.FirefoxUserAgent = txtFirefox.Text.Trim();
            Globals.ChromeUserAgent = txtChrome.Text.Trim();
            Globals.UseFirefox = rbFirefox.Checked;

            Globals.SaveSettings();

            lblStatus.ForeColor = Color.FromArgb(33, 89, 64);
            lblStatus.Text = "Settings saved !";

            await Task.Delay(1500);
            Close();
        }

        private async void BtnUpdateGitHub_Click(object sender, EventArgs e)
        {
            btnUpdateGitHub.Enabled = false;
            lblGlobeIcon.Enabled = false;
            btnUpdateGitHub.Text = "Search...";

            lblStatus.ForeColor = Color.FromArgb(33, 89, 64);
            lblStatus.Text = "Connect to GitHub...";

            bool updated = await Globals.UpdateFromGitHubAsync();

            if (updated)
            {
                LoadCurrentSettings();
                lblStatus.ForeColor = Color.FromArgb(33, 89, 64);
                lblStatus.Text = "User-Agents updated!";
            }
            else
            {
                lblStatus.ForeColor = Color.FromArgb(255, 100, 100);
                lblStatus.Text = "Update failed.";
            }

            btnUpdateGitHub.Text = "GitHub Update!";
            btnUpdateGitHub.Enabled = true;
            lblGlobeIcon.Enabled = true;
        }
    }
}
