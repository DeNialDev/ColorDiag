namespace ColorDiag
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCambiarBtn = new System.Windows.Forms.Button();
            this.btnCambiarBG = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cambiar color de fondo de ventana";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCambiarBtn);
            this.panel1.Controls.Add(this.btnCambiarBG);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 450);
            this.panel1.TabIndex = 1;
            // 
            // btnCambiarBtn
            // 
            this.btnCambiarBtn.Location = new System.Drawing.Point(437, 384);
            this.btnCambiarBtn.Name = "btnCambiarBtn";
            this.btnCambiarBtn.Size = new System.Drawing.Size(182, 23);
            this.btnCambiarBtn.TabIndex = 5;
            this.btnCambiarBtn.Text = "Cambiar color de fondo de botones";
            this.btnCambiarBtn.UseVisualStyleBackColor = true;
            this.btnCambiarBtn.Click += new System.EventHandler(this.btnCambiarBtn_Click);
            // 
            // btnCambiarBG
            // 
            this.btnCambiarBG.Location = new System.Drawing.Point(217, 384);
            this.btnCambiarBG.Name = "btnCambiarBG";
            this.btnCambiarBG.Size = new System.Drawing.Size(214, 23);
            this.btnCambiarBG.TabIndex = 4;
            this.btnCambiarBG.Text = "Cambiar color de fondo de la lista";
            this.btnCambiarBG.UseVisualStyleBackColor = true;
            this.btnCambiarBG.Click += new System.EventHandler(this.btnCambiarBG_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(272, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(406, 23);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(242, 303);
            this.listBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCambiarBG;
        private System.Windows.Forms.Button btnCambiarBtn;
    }
}

