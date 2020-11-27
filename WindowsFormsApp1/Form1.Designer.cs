namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.salida = new System.Windows.Forms.Label();
            this.btnvalidacion = new System.Windows.Forms.Button();
            this.nombrein = new System.Windows.Forms.TextBox();
            this.codigoin = new System.Windows.Forms.TextBox();
            this.correoin = new System.Windows.Forms.TextBox();
            this.errorm = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passwordin = new System.Windows.Forms.TextBox();
            this.btnvalpass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Thistle;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(111, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Thistle;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(111, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Thistle;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(113, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correo";
            // 
            // salida
            // 
            this.salida.AutoSize = true;
            this.salida.BackColor = System.Drawing.Color.Thistle;
            this.salida.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.salida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salida.Location = new System.Drawing.Point(314, 369);
            this.salida.Name = "salida";
            this.salida.Size = new System.Drawing.Size(36, 22);
            this.salida.TabIndex = 3;
            this.salida.Text = ".....";
            // 
            // btnvalidacion
            // 
            this.btnvalidacion.BackColor = System.Drawing.Color.Thistle;
            this.btnvalidacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvalidacion.ForeColor = System.Drawing.Color.Purple;
            this.btnvalidacion.Location = new System.Drawing.Point(210, 303);
            this.btnvalidacion.Name = "btnvalidacion";
            this.btnvalidacion.Size = new System.Drawing.Size(131, 38);
            this.btnvalidacion.TabIndex = 4;
            this.btnvalidacion.Text = "Validar";
            this.btnvalidacion.UseVisualStyleBackColor = false;
            this.btnvalidacion.Click += new System.EventHandler(this.btnvalidacion_Click);
            // 
            // nombrein
            // 
            this.nombrein.BackColor = System.Drawing.Color.Thistle;
            this.nombrein.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrein.ForeColor = System.Drawing.Color.Purple;
            this.nombrein.Location = new System.Drawing.Point(210, 160);
            this.nombrein.Name = "nombrein";
            this.nombrein.Size = new System.Drawing.Size(207, 22);
            this.nombrein.TabIndex = 5;
            this.nombrein.TextChanged += new System.EventHandler(this.nombrein_TextChanged);
            // 
            // codigoin
            // 
            this.codigoin.BackColor = System.Drawing.Color.Thistle;
            this.codigoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoin.ForeColor = System.Drawing.Color.Purple;
            this.codigoin.Location = new System.Drawing.Point(210, 214);
            this.codigoin.Name = "codigoin";
            this.codigoin.Size = new System.Drawing.Size(207, 22);
            this.codigoin.TabIndex = 6;
            // 
            // correoin
            // 
            this.correoin.BackColor = System.Drawing.Color.Thistle;
            this.correoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correoin.ForeColor = System.Drawing.Color.Purple;
            this.correoin.Location = new System.Drawing.Point(210, 266);
            this.correoin.Name = "correoin";
            this.correoin.Size = new System.Drawing.Size(207, 22);
            this.correoin.TabIndex = 7;
            // 
            // errorm
            // 
            this.errorm.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 453);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // passwordin
            // 
            this.passwordin.BackColor = System.Drawing.Color.Thistle;
            this.passwordin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordin.ForeColor = System.Drawing.Color.Purple;
            this.passwordin.Location = new System.Drawing.Point(458, 160);
            this.passwordin.Name = "passwordin";
            this.passwordin.Size = new System.Drawing.Size(209, 22);
            this.passwordin.TabIndex = 10;
            // 
            // btnvalpass
            // 
            this.btnvalpass.BackColor = System.Drawing.Color.Thistle;
            this.btnvalpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvalpass.ForeColor = System.Drawing.Color.Purple;
            this.btnvalpass.Location = new System.Drawing.Point(458, 188);
            this.btnvalpass.Name = "btnvalpass";
            this.btnvalpass.Size = new System.Drawing.Size(209, 35);
            this.btnvalpass.TabIndex = 11;
            this.btnvalpass.Text = "Validar Password";
            this.btnvalpass.UseVisualStyleBackColor = false;
            this.btnvalpass.Click += new System.EventHandler(this.btnvalpass_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvalpass);
            this.Controls.Add(this.passwordin);
            this.Controls.Add(this.correoin);
            this.Controls.Add(this.codigoin);
            this.Controls.Add(this.nombrein);
            this.Controls.Add(this.btnvalidacion);
            this.Controls.Add(this.salida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label salida;
        private System.Windows.Forms.Button btnvalidacion;
        private System.Windows.Forms.TextBox nombrein;
        private System.Windows.Forms.TextBox codigoin;
        private System.Windows.Forms.TextBox correoin;
        private System.Windows.Forms.ErrorProvider errorm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnvalpass;
        private System.Windows.Forms.TextBox passwordin;
    }
}

