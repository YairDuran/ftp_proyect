using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace FTPproyect2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button_FormBackUp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_FileName_Click(object sender, EventArgs e)
        {
        }

        private void button_Load_Click(object sender, EventArgs e)
        {
            try
            {

                using (OpenFileDialog selectFile = new OpenFileDialog() { Multiselect = false, ValidateNames = true, Filter = "SQL *.sql|*.sql" })
                {
                    label_status.Text = "0%";
                    progressBar.Value = 0;
                    //progressBar.Update();

                    MessageBox.Show("Una vez subido el archivo sera eliminado de manera local");
                    if (selectFile.ShowDialog() == DialogResult.OK)
                    {
                        FileInfo info = new FileInfo(selectFile.FileName);

                        _inputParameter.Server = txt_pathFTP.Text;
                        _inputParameter.User = txt_userFTP.Text;
                        _inputParameter.Password = txt_passFTP.Text;
                        _inputParameter.FileName = info.Name;
                        _inputParameter.FullName = info.FullName;
                        backgroundWorker.RunWorkerAsync(_inputParameter);

                        label_FileName.Text = info.Name;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        struct FTP_Setting
        {
            public string Server { get; set; }
            public string User { get; set; }
            public string Password { get; set; }
            public string FileName { get; set; }
            public string FullName { get; set; }
        }

        FTP_Setting _inputParameter;

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string server = ((FTP_Setting)e.Argument).Server;
                string user = ((FTP_Setting)e.Argument).User;
                string password = ((FTP_Setting)e.Argument).Password;
                string fileName = ((FTP_Setting)e.Argument).FileName;
                string fullName = ((FTP_Setting)e.Argument).FullName;

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri(string.Format("{0}/{1}", server, fileName)));
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential(user, password);
                Stream ftpStream = request.GetRequestStream();
                FileStream fileStream = File.OpenRead(fullName);

                byte[] buffer = new byte[1024];
                double total = (double)fileStream.Length;
                int byteRead = 0;
                double read = 0;

                do
                {
                    if (!backgroundWorker.CancellationPending)
                    {
                        byteRead = fileStream.Read(buffer, 0, 1024);
                        ftpStream.Write(buffer, 0, byteRead);
                        read += (double)byteRead;
                        double percentage = read / total * 100;
                        backgroundWorker.ReportProgress((int)percentage);
                    }
                } while (byteRead != 0);
                fileStream.Close();
                ftpStream.Close();

                File.Delete(fullName);
            }
            catch (Exception ex)
            {
                label_status.Text = "0%";
                progressBar.Value = 0;
                //progressBar.Update();
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                label_status.Text = $"Subiendo archivo {e.ProgressPercentage}%";
                progressBar.Value = e.ProgressPercentage;
                progressBar.Update();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void Validate_Text()
        {
            try
            {
                if (txt_pathFTP.Text != string.Empty && txt_userFTP.Text != string.Empty && txt_passFTP.Text != string.Empty)
                {
                    button_Load.Enabled = true;
                }
                else
                {
                    button_Load.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void txt_pathFTP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Validate_Text();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void txt_userFTP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Validate_Text();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void txt_passFTP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Validate_Text();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
