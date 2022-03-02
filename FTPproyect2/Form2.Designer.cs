namespace FTPproyect2
{
    partial class Form2
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
            this.button_FormBackUp = new System.Windows.Forms.Button();
            this.button_Load = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label_FileName = new System.Windows.Forms.Label();
            this.label_pathFTP = new System.Windows.Forms.Label();
            this.label_userFTP = new System.Windows.Forms.Label();
            this.label_passFTP = new System.Windows.Forms.Label();
            this.txt_pathFTP = new System.Windows.Forms.TextBox();
            this.txt_userFTP = new System.Windows.Forms.TextBox();
            this.txt_passFTP = new System.Windows.Forms.TextBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label_status = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_FormBackUp
            // 
            this.button_FormBackUp.BackColor = System.Drawing.Color.White;
            this.button_FormBackUp.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_FormBackUp.Location = new System.Drawing.Point(12, 373);
            this.button_FormBackUp.Name = "button_FormBackUp";
            this.button_FormBackUp.Size = new System.Drawing.Size(75, 23);
            this.button_FormBackUp.TabIndex = 0;
            this.button_FormBackUp.Text = "Volver";
            this.button_FormBackUp.UseVisualStyleBackColor = false;
            this.button_FormBackUp.Click += new System.EventHandler(this.button_FormBackUp_Click);
            // 
            // button_Load
            // 
            this.button_Load.BackColor = System.Drawing.Color.White;
            this.button_Load.Enabled = false;
            this.button_Load.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Load.Location = new System.Drawing.Point(22, 288);
            this.button_Load.Name = "button_Load";
            this.button_Load.Size = new System.Drawing.Size(133, 23);
            this.button_Load.TabIndex = 1;
            this.button_Load.Text = "Subir Archivo";
            this.button_Load.UseVisualStyleBackColor = false;
            this.button_Load.Click += new System.EventHandler(this.button_Load_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // label_FileName
            // 
            this.label_FileName.AutoSize = true;
            this.label_FileName.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FileName.Location = new System.Drawing.Point(161, 291);
            this.label_FileName.Name = "label_FileName";
            this.label_FileName.Size = new System.Drawing.Size(137, 17);
            this.label_FileName.TabIndex = 2;
            this.label_FileName.Text = "Seleccionar archivo ...";
            // 
            // label_pathFTP
            // 
            this.label_pathFTP.AutoSize = true;
            this.label_pathFTP.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pathFTP.Location = new System.Drawing.Point(19, 145);
            this.label_pathFTP.Name = "label_pathFTP";
            this.label_pathFTP.Size = new System.Drawing.Size(86, 17);
            this.label_pathFTP.TabIndex = 4;
            this.label_pathFTP.Text = "Dominio FTP";
            // 
            // label_userFTP
            // 
            this.label_userFTP.AutoSize = true;
            this.label_userFTP.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_userFTP.Location = new System.Drawing.Point(19, 206);
            this.label_userFTP.Name = "label_userFTP";
            this.label_userFTP.Size = new System.Drawing.Size(55, 17);
            this.label_userFTP.TabIndex = 5;
            this.label_userFTP.Text = "Usuario";
            // 
            // label_passFTP
            // 
            this.label_passFTP.AutoSize = true;
            this.label_passFTP.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_passFTP.Location = new System.Drawing.Point(161, 206);
            this.label_passFTP.Name = "label_passFTP";
            this.label_passFTP.Size = new System.Drawing.Size(78, 17);
            this.label_passFTP.TabIndex = 6;
            this.label_passFTP.Text = "Contraseña";
            // 
            // txt_pathFTP
            // 
            this.txt_pathFTP.BackColor = System.Drawing.Color.White;
            this.txt_pathFTP.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pathFTP.Location = new System.Drawing.Point(22, 165);
            this.txt_pathFTP.Name = "txt_pathFTP";
            this.txt_pathFTP.Size = new System.Drawing.Size(280, 28);
            this.txt_pathFTP.TabIndex = 7;
            this.txt_pathFTP.TextChanged += new System.EventHandler(this.txt_pathFTP_TextChanged);
            // 
            // txt_userFTP
            // 
            this.txt_userFTP.BackColor = System.Drawing.Color.White;
            this.txt_userFTP.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userFTP.Location = new System.Drawing.Point(22, 226);
            this.txt_userFTP.Name = "txt_userFTP";
            this.txt_userFTP.Size = new System.Drawing.Size(136, 28);
            this.txt_userFTP.TabIndex = 8;
            this.txt_userFTP.TextChanged += new System.EventHandler(this.txt_userFTP_TextChanged);
            // 
            // txt_passFTP
            // 
            this.txt_passFTP.BackColor = System.Drawing.Color.White;
            this.txt_passFTP.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_passFTP.Location = new System.Drawing.Point(164, 226);
            this.txt_passFTP.Name = "txt_passFTP";
            this.txt_passFTP.Size = new System.Drawing.Size(138, 28);
            this.txt_passFTP.TabIndex = 9;
            this.txt_passFTP.UseSystemPasswordChar = true;
            this.txt_passFTP.TextChanged += new System.EventHandler(this.txt_passFTP_TextChanged);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.White;
            this.progressBar.Location = new System.Drawing.Point(131, 373);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(187, 23);
            this.progressBar.TabIndex = 10;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.Location = new System.Drawing.Point(217, 353);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(25, 17);
            this.label_status.TabIndex = 11;
            this.label_status.Text = "0%";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FTPproyect2.Properties.Resources.ftp;
            this.pictureBox1.Location = new System.Drawing.Point(100, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(103)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(330, 407);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.txt_passFTP);
            this.Controls.Add(this.txt_userFTP);
            this.Controls.Add(this.txt_pathFTP);
            this.Controls.Add(this.label_passFTP);
            this.Controls.Add(this.label_userFTP);
            this.Controls.Add(this.label_pathFTP);
            this.Controls.Add(this.label_FileName);
            this.Controls.Add(this.button_Load);
            this.Controls.Add(this.button_FormBackUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transferencia por FTP";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_FormBackUp;
        private System.Windows.Forms.Button button_Load;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label_FileName;
        private System.Windows.Forms.Label label_pathFTP;
        private System.Windows.Forms.Label label_userFTP;
        private System.Windows.Forms.Label label_passFTP;
        private System.Windows.Forms.TextBox txt_pathFTP;
        private System.Windows.Forms.TextBox txt_userFTP;
        private System.Windows.Forms.TextBox txt_passFTP;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}