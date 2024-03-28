using Microsoft.Win32;
using System;
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
        }

        CultureInfo cultureInfo;
        StreamWriter streamWriter;

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string timestampFormat = cultureInfo.DateTimeFormat.SortableDateTimePattern;

            // If the username or password textboxes are empty, an error message is displayed using the current UI language (EN, ES)
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                switch (CultureInfo.CurrentCulture.ToString())
                {
                    case "es-US":
                        MessageBox.Show("Debes ingresar un nombre de usuario y contraseña para continuar.", "sbCalendar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default:
                        MessageBox.Show("You must enter a username and password to continue.", "sbCalendar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {
                try
                {
                    // Try authenticating the user, if successful, write success message to log; if failed, an error message is displayed in the current UI language (EN, ES)

                    ClientScheduleRepository clientScheduleRepository = new ClientScheduleRepository();
                    if (clientScheduleRepository.AuthenticateUser(username, password))
                    {
                        if (File.Exists("../login.log"))
                        {
                            var fileStream = new FileStream("../login.log", FileMode.Append, FileAccess.Write);
                            using (streamWriter = new StreamWriter(fileStream))
                            {
                                streamWriter.WriteLine($"{DateTime.Now.ToString(timestampFormat)} | {username} has logged in successfully");
                            }
                        }
                        else
                        {
                            var fileStream = new FileStream("../login.log", FileMode.OpenOrCreate, FileAccess.ReadWrite);

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
                                MessageBox.Show("El nombre de usuario y/o contraseña es incorrecto.", "sbCalendar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            default:
                                MessageBox.Show("The username and/or password is incorrect.", "sbCalendar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // Controls on form load text using current culture
            CultureInfo.CurrentCulture.ClearCachedData();
            cultureInfo = CultureInfo.CurrentCulture;
            if (cultureInfo.Name.Contains("es-"))
            {
                usernameLabel.Text = "Usuario";
                passwordLabel.Text = "Contraseña";
                loginButton.Text = "Acceso";
            }
            else
            {
                usernameLabel.Text = "Username";
                passwordLabel.Text = "Password";
                loginButton.Text = "Log In";
            }
        }
    }
}