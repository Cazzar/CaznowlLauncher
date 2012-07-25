using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.IO;

namespace CaznowlLauncher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Text = "Logging in...";
            btnLogin.Enabled = false;

            try
            {
                string[] LoginData = Login(txtUsername.Text, txtPassword.Text);
                Launch(".minecraft", LoginData[0], LoginData[1]);
            }
            catch(BadLoginException ex)
            {
                    MessageBox.Show("Bad Username or Password!");
            }
            catch (UserNotPremiumException ex)
            {
                    MessageBox.Show("User \"" + ex.Username + "\" is not Premium");
            }
            catch(UserMigratedException ex)
            {
                MessageBox.Show("The username \"" + ex.Username + "\" has a migrated account, Use your e-mail as your username");
            }
            btnLogin.Text = "Login";
            btnLogin.Enabled = true;
        }

        protected static string[] Login(string Username, string Password)
        {
            string URL = "https://login.minecraft.net/?user={0}&password={1}&version={2}";
            int Version = 13;

            string result = (new WebClient()).DownloadString(String.Format(URL, Username, Password, Version));
            if (result == "Bad login")
                throw new BadLoginException(Username);
            else if (result == "User not premium")
                throw new UserNotPremiumException(Username);
            else if (result == "Account migrated, use e-mail as username.")
                throw new UserMigratedException(Username);

            string[] split = result.Split(':');

            if (split.Length == 4)
            {
                string[] r = { split[2], split[3] };
                return r;
            }
            return null;
        }

        internal static Process Launch(string Folder, string Username, string SessionKey)
        {
            string args = String.Format("-Xms512m -Xmx1024m " +
    "-cp \"{0}\\{1}\\bin\\minecraft.jar;{0}\\{1}\\bin\\jinput.jar;{0}\\{1}\\bin\\lwjgl.jar;{0}\\{1}\\bin\\lwjgl_util.jar\" " +
    "-Djava.library.path=\"{0}\\{1}\\bin\\natives\" net.minecraft.client.Minecraft {2} {3}",
    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
    Folder, Username, SessionKey);

            Process p = new Process();
            p.StartInfo.Arguments = args;
            //p.StartInfo.FileName = "java";
            p.StartInfo.FileName = ImportantFunctions.GetJavaPath();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.ErrorDialog = true;
            p.StartInfo.CreateNoWindow = true;

            p.Start();

            return p;
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.Text = "Logging in...";
                btnLogin.Enabled = false;

                try
                {
                    string[] LoginData = Login(txtUsername.Text, txtPassword.Text);
                    Launch(".minecraft", LoginData[0], LoginData[1]);
                }
                catch (BadLoginException ex)
                {
                    MessageBox.Show("Bad Username or Password!");
                }
                catch (UserNotPremiumException ex)
                {
                    MessageBox.Show("User \"" + ex.Username + "\" is not Premium");
                }
                catch (UserMigratedException ex)
                {
                    MessageBox.Show("The username \"" + ex.Username + "\" has a migrated account, Use your e-mail as your username");
                }
                btnLogin.Text = "Login";
                btnLogin.Enabled = true;
            }
        }
    }
}
