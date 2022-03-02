using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTPproyect2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string data = "server=localhost; user=root; pwd=1qaz2wsx3edc4rfv5tgb;";

                MySqlConnection connection = new MySqlConnection(data);
                MySqlCommand command = new MySqlCommand();
                MySqlBackup backup = new MySqlBackup(command);

                command.Connection = connection;
                connection.Open();

                command.CommandType = CommandType.Text;
                command.CommandText = "select SCHEMA_NAME from information_schema.SCHEMATA";

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);

                DataTable dtDataBase = dataset.Tables[0];

                for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
                {
                    databaseSelect.Items.Add(dataset.Tables[0].Rows[i][0].ToString());
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveSelection = new SaveFileDialog();
                saveSelection.Filter = "Archivo SQL(*.sql)|*.sql";

                if (saveSelection.ShowDialog() == DialogResult.OK)
                {
                    string ruta = saveSelection.FileName;

                    string data = "server=localhost; user=root; pwd=1qaz2wsx3edc4rfv5tgb; database=" + databaseSelect.Text + ";";
                    data += "charset=utf8; convertzerodatetime=true";

                    MySqlConnection connection = new MySqlConnection(data);
                    MySqlCommand command = new MySqlCommand();
                    MySqlBackup backup = new MySqlBackup(command);

                    command.Connection = connection;
                    connection.Open();

                    backup.ExportToFile(ruta);

                    connection.Close();

                    MessageBox.Show("Copia Realizada");

                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void Validate_Box() {
            try
            {
                if (databaseSelect.Text != string.Empty)
                {
                    button1.Enabled = true;
                }
                else
                {
                    button1.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void databaseSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Validate_Box();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button_FormFTP_Click(object sender, EventArgs e)
        {
            using (Form2 formFTP = new Form2())
            formFTP.ShowDialog();
        }
    }
}
