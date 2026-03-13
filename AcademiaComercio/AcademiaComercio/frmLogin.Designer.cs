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
            btnEntrar = new Button();
            btnSair = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(149, 334);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(262, 23);
            txtSenha.TabIndex = 1;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(149, 268);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(262, 23);
            txtLogin.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(134, 9);
            label1.Name = "label1";
            label1.Size = new Size(307, 43);
            label1.TabIndex = 3;
            label1.Text = "Aplicativo Academia";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(149, 243);
            label2.Name = "label2";
            label2.Size = new Size(60, 22);
            label2.TabIndex = 4;
            label2.Text = "Login:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(149, 309);
            label3.Name = "label3";
            label3.Size = new Size(66, 22);
            label3.TabIndex = 5;
            label3.Text = "Senha:";
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(46, 377);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(156, 42);
            btnEntrar.TabIndex = 3;
            btnEntrar.Text = "Entar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(370, 377);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(156, 42);
            btnSair.TabIndex = 7;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo1;
            pictureBox1.Location = new Point(165, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 186);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(208, 377);
            button1.Name = "button1";
            button1.Size = new Size(156, 42);
            button1.TabIndex = 9;
            button1.Text = "Não possui cadastro? Cadastre-se!";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(576, 431);
            Controls.Add(button1);
            Controls.Add(btnSair);
            Controls.Add(btnEntrar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLogin);
            Controls.Add(txtSenha);
            Controls.Add(pictureBox1);
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
        private Button btnEntrar;
        private Button btnSair;
        private PictureBox pictureBox1;
        private Button button1;
    }
}
