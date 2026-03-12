namespace AcademiaComercio
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtSenha = new TextBox();
            txtLogin = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            btnEntrar = new Button();
            btnSair = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(263, 227);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(262, 23);
            txtSenha.TabIndex = 1;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(266, 156);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(262, 23);
            txtLogin.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(263, 32);
            label1.Name = "label1";
            label1.Size = new Size(282, 37);
            label1.TabIndex = 3;
            label1.Text = "Aplicativo Academia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(266, 138);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 4;
            label2.Text = "Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(266, 209);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 5;
            label3.Text = "Senha";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(41, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 218);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(325, 297);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(153, 54);
            btnEntrar.TabIndex = 3;
            btnEntrar.Text = "Entar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(152, 297);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(153, 54);
            btnSair.TabIndex = 7;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 431);
            Controls.Add(btnSair);
            Controls.Add(btnEntrar);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLogin);
            Controls.Add(txtSenha);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtSenha;
        private TextBox txtLogin;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Button btnEntrar;
        private Button btnSair;
    }
}
