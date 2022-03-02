namespace FTPproyect2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.databaseSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_FormFTP = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(86, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crear copia";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // databaseSelect
            // 
            this.databaseSelect.BackColor = System.Drawing.Color.White;
            this.databaseSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.databaseSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.databaseSelect.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databaseSelect.FormattingEnabled = true;
            this.databaseSelect.Location = new System.Drawing.Point(50, 191);
            this.databaseSelect.Name = "databaseSelect";
            this.databaseSelect.Size = new System.Drawing.Size(189, 25);
            this.databaseSelect.TabIndex = 1;
            this.databaseSelect.SelectedIndexChanged += new System.EventHandler(this.databaseSelect_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione una Base de Datos";
            // 
            // button_FormFTP
            // 
            this.button_FormFTP.BackColor = System.Drawing.Color.White;
            this.button_FormFTP.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_FormFTP.Location = new System.Drawing.Point(187, 322);
            this.button_FormFTP.Name = "button_FormFTP";
            this.button_FormFTP.Size = new System.Drawing.Size(81, 23);
            this.button_FormFTP.TabIndex = 3;
            this.button_FormFTP.Text = "Subir FTP";
            this.button_FormFTP.UseVisualStyleBackColor = false;
            this.button_FormFTP.Click += new System.EventHandler(this.button_FormFTP_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::FTPproyect2.Properties.Resources.bckup;
            this.pictureBox1.Location = new System.Drawing.Point(75, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(103)))), ((int)(((byte)(163)))));
            this.ClientSize = new System.Drawing.Size(280, 357);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_FormFTP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.databaseSelect);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup Base de Datos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox databaseSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_FormFTP;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

