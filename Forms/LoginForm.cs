using Microsoft.Win32;
using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Security.Authentication;
using System.Windows.Forms;

namespace sbCalendar.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            SystemEvents.UserPreferenceChanged += SystemEvents_UserPreferenceChanged;
            CreateErrorForm(errorForm1, textBox1);
            CreateErrorForm(errorForm2, textBox2);
        }

        RegionInfo regionInfo;
        CultureInfo cultureInfo;
        StreamWriter streamWriter;

        Form errorForm1 = new Form();
        Form errorForm2 = new Form();
        TextBox textBox1 = new TextBox();
        TextBox textBox2 = new TextBox();

        public void CreateErrorForm(Form errorForm, TextBox textBox)
        {            
            textBox.Multiline = true;
            textBox.Size = new Size(errorForm.Width - 24, errorForm.Height - 48);
            textBox.Location = new Point(4, 4);
            Button button = new Button();
            button.Text = "OK";
            button.Location = new Point(110, 200);
            button.DialogResult = DialogResult.OK;
            errorForm.Text = "sbCalendar";
            errorForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            errorForm.AcceptButton = button;
            errorForm.StartPosition = FormStartPosition.CenterScreen;
            errorForm.Controls.Add(button);
            errorForm.Controls.Add(textBox);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string timestampFormat = cultureInfo.DateTimeFormat.SortableDateTimePattern;

            // If the username or password textboxes are empty, an error message is displayed in es-US or en-US
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                switch (CultureInfo.CurrentCulture.ToString())
                {
                    case "es-US":
                        textBox1.Text = "Debes ingresar un nombre de usuario y contraseña para continuar.";
                        errorForm1.ShowDialog();
                        break;
                    default:
                        textBox1.Text = "You must enter a username and password to continue.";
                        errorForm1.ShowDialog();
                        break;
                }
            }
            else
            {
                try
                {
                    // Try authenticating the user, if successful, write success message to log; if failed, an error message is displayed in es-US or en-US

                    ClientScheduleRepository clientScheduleRepository = new ClientScheduleRepository();
                    if (clientScheduleRepository.AuthenticateUser(username, password))
                    {
                        if (File.Exists("../Login_History.txt"))
                        {
                            var fileStream = new FileStream("../Login_History.txt", FileMode.Append, FileAccess.Write);
                            using (streamWriter = new StreamWriter(fileStream))
                            {
                                streamWriter.WriteLine($"{DateTime.Now.ToString(timestampFormat)} | {username} has logged in successfully");
                            }
                        }
                        else
                        {
                            var fileStream = new FileStream("../Login_History.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

                            using (streamWriter = new StreamWriter(fileStream))
                            {
                                streamWriter.WriteLine($"{DateTime.Now.ToString(timestampFormat)} | {username} has logged in successfully");
                            }
                        }

                        Hide();
                        HomeForm homeForm = new HomeForm();
                        homeForm.ShowDialog();
                        Close();
                    }
                    else
                    {
                        switch (CultureInfo.CurrentCulture.ToString())
                        {                            
                            case "es-US":
                                textBox2.Text = "El nombre de usuario y/o contraseña es incorrecto.";
                                errorForm2.ShowDialog();
                                break;
                            default:
                                textBox2.Text = "The username and/or password is incorrect.";
                                errorForm2.ShowDialog();
                                break;
                        }
                    }
                }
                catch (InvalidCredentialException ex)
                {
                    MessageBox.Show(ex.ToString(), "sbCalendar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            // Controls on form load text using current culture and region
            CultureInfo.CurrentCulture.ClearCachedData();
            cultureInfo = CultureInfo.CurrentCulture;
            regionInfo = RegionInfo.CurrentRegion;
            if (cultureInfo.Name == "es-US")
            {
                usernameLabel.Text = "Usuario";
                passwordLabel.Text = "Contraseña";
                loginButton.Text = "Acceso";
                regionLabel.Text = $"Usted está aquí: {regionInfo.NativeName}";
                infoLabel.Text = "Esta página de inicio de sesión se traduce entre es-US y en-US.";                
            }
            else
            {
                usernameLabel.Text = "Username";
                passwordLabel.Text = "Password";
                loginButton.Text = "Log In";
                regionLabel.Text = $"You are here: {regionInfo.EnglishName}";
                infoLabel.Text = "This login page translates between en-US and es-US.";
            }
        }

        void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
        {
            // Controls on form load text using current culture and region
            CultureInfo.CurrentCulture.ClearCachedData();
            cultureInfo = CultureInfo.CurrentCulture;
            regionInfo = RegionInfo.CurrentRegion;
            if (cultureInfo.Name == "es-US")
            {
                usernameLabel.Text = "Usuario";
                passwordLabel.Text = "Contraseña";
                loginButton.Text = "Acceso";
                regionLabel.Text = $"Usted está aquí: {regionInfo.NativeName}";
                infoLabel.Text = "Esta página de inicio de sesión se traduce entre es-US y en-US.";
                textBox1.Text = "Debes ingresar un nombre de usuario y contraseña para continuar.";
                textBox2.Text = "El nombre de usuario y/o contraseña es incorrecto.";
            }
            else
            {
                usernameLabel.Text = "Username";
                passwordLabel.Text = "Password";
                loginButton.Text = "Log In";
                regionLabel.Text = $"You are here: {regionInfo.EnglishName}";
                infoLabel.Text = "This login page translates between en-US and es-US.";
                textBox1.Text = "You must enter a username and password to continue.";
                textBox2.Text = "The username and/or password is incorrect.";
            }
        }
    }
}