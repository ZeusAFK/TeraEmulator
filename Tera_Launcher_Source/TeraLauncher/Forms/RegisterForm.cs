using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeraLauncher
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        #region Button Controls
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnMinimize_Enter(object sender, EventArgs e)
        {
            _btnMinimize.Image = Image.FromFile(LoginForm.dataDir + LoginForm._btn_minimize_hv); 
        }
        private void btnMinimize_Leave(object sender, EventArgs e)
        {
            _btnMinimize.Image = Image.FromFile(LoginForm.dataDir + LoginForm._btn_minimize_nm); 
        }
        //
        private void btnClose_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.Show();
            this.Hide();
        }
        private void btnClose_Enter(object sender, EventArgs e)
        {
            _btnClose.Image = Image.FromFile(LoginForm.dataDir + LoginForm._btn_close_hv); 
        }
        private void btnClose_Leave(object sender, EventArgs e)
        {
            _btnClose.Image = Image.FromFile(LoginForm.dataDir + LoginForm._btn_close_nm); 
        }
        //
        //registration undone yet! to be rebuild
        private void btnRegister_Click(object sender, EventArgs e)
        {

            /*
            Form1.user = WebAPI._register_Callback<UserData>(Form1.webApiUrl, tbUsername.Text, tbPassword.Text, 
               tbRPassword.Text, tbEmail.Text);

           if (!Form1.user.success)
           {
               MessageBox.Show(Form1.user.error);
           }
           else
           {
               MessageBox.Show("You have been registered " + tbUsername.Text + "!");
               Form1 frm = new Form1();
               frm.Show();
               this.Close();
           }
           */
        }
        private void btnRegister_Enter(object sender, EventArgs e)
        {
            _btnRegister.Image = Image.FromFile(LoginForm.dataDir + LoginForm._btn_register_hv);
        }
        private void btnRegister_Leave(object sender, EventArgs e)
        {
            _btnRegister.Image = Image.FromFile(LoginForm.dataDir + LoginForm._btn_register_nm);
        }
        
        #endregion Button Controls

        #region GUIoverride
        // Form mit Maus überall greifen und verschieben
        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x84;
            const int HTCAPTION = 0x02;

            if (m.Msg == WM_NCHITTEST)
            {
                m.Result = (IntPtr)HTCAPTION;
            }
            else
            {
                base.WndProc(ref m);
            }
        }
        #endregion GUIoverride

        private void Register_Load(object sender, EventArgs e)
        {
            // Change reg-background img if Needed!
            if (LoginForm._launcher_background_img != null)
            { this.BackgroundImage = Image.FromFile(LoginForm.dataDir + LoginForm._register_background_img); }

            // Passwords
            textboxPassword.PasswordChar = '*';
            textboxRePassword.PasswordChar = '*';

            // Close / Minimize Buttons, Style CSS
            _btnMinimize.Image = Image.FromFile(LoginForm.dataDir + LoginForm._btn_minimize_nm);
            _btnMinimize.MouseEnter += new EventHandler(btnMinimize_Enter);
            _btnMinimize.MouseLeave += new EventHandler(btnMinimize_Leave);
            _btnMinimize.FlatStyle = FlatStyle.Flat;
            _btnMinimize.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            _btnMinimize.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 255, 255, 255);
            _btnMinimize.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 255, 255, 255);
            _btnMinimize.FlatAppearance.BorderSize = 0;
            _btnMinimize.BackColor = Color.FromArgb(0, 255, 255, 255);

            _btnClose.Image = Image.FromFile(LoginForm.dataDir + LoginForm._btn_close_nm);
            _btnClose.MouseEnter += new EventHandler(btnClose_Enter);
            _btnClose.MouseLeave += new EventHandler(btnClose_Leave);
            _btnClose.FlatStyle = FlatStyle.Flat;
            _btnClose.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            _btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 255, 255, 255);
            _btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 255, 255, 255);
            _btnClose.FlatAppearance.BorderSize = 0;
            _btnClose.BackColor = Color.FromArgb(0, 255, 255, 255);

            // Register Button
            _btnRegister.Image = Image.FromFile(LoginForm.dataDir + LoginForm._btn_register_nm);
            _btnRegister.MouseEnter += new EventHandler(btnRegister_Enter);
            _btnRegister.MouseLeave += new EventHandler(btnRegister_Leave);
            _btnRegister.FlatStyle = FlatStyle.Flat;
            _btnRegister.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            _btnRegister.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 255, 255, 255);
            _btnRegister.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 255, 255, 255);
            _btnRegister.FlatAppearance.BorderSize = 0;
            _btnRegister.BackColor = Color.FromArgb(0, 255, 255, 255);

        }

    }
}
