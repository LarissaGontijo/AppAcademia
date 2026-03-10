namespace AcademiaComercio
{
    partial class frmMenu
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
            label1 = new Label();
            button1 = new Button();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            button4 = new Button();
            button5 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Haettenschweiler", 48F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(169, 9);
            label1.Name = "label1";
            label1.Size = new Size(317, 67);
            label1.TabIndex = 0;
            label1.Text = "Menu Principal";
            // 
            // button1
            // 
            button1.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(43, 142);
            button1.Name = "button1";
            button1.Size = new Size(138, 53);
            button1.TabIndex = 1;
            button1.Text = "Monte seu Treino";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(43, 357);
            button3.Name = "button3";
            button3.Size = new Size(138, 53);
            button3.TabIndex = 3;
            button3.Text = "Produtos";
            button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(44, 98);
            label2.Name = "label2";
            label2.Size = new Size(259, 25);
            label2.TabIndex = 4;
            label2.Text = "Evolua seu resultado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(43, 213);
            label3.Name = "label3";
            label3.Size = new Size(265, 25);
            label3.TabIndex = 5;
            label3.Text = "Contrate um personal:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(44, 258);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(413, 31);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pesquisar";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(84, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(283, 26);
            textBox1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(222, 142);
            button2.Name = "button2";
            button2.Size = new Size(138, 53);
            button2.TabIndex = 7;
            button2.Text = "Fale com o Personal";
            button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.GhostWhite;
            pictureBox1.Image = Properties.Resources.buscarM;
            pictureBox1.Location = new Point(373, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 32);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(43, 312);
            label4.Name = "label4";
            label4.Size = new Size(190, 25);
            label4.TabIndex = 8;
            label4.Text = "Área do Cliente:";
            // 
            // button4
            // 
            button4.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(222, 357);
            button4.Name = "button4";
            button4.Size = new Size(138, 53);
            button4.TabIndex = 9;
            button4.Text = "Descontos";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(400, 357);
            button5.Name = "button5";
            button5.Size = new Size(138, 53);
            button5.TabIndex = 10;
            button5.Text = "SAC";
            button5.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(657, 459);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "frmMenu";
            Text = " ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button3;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Button button2;
        private PictureBox pictureBox1;
        private Label label4;
        private Button button4;
        private Button button5;
    }
}