﻿namespace login
{
    partial class formlogin
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
            buttonEnter = new Button();
            textBoxUsuário = new Label();
            textBoxSenha = new Label();
            label3 = new Label();
            labelResultado = new Label();
            label1 = new Label();
            test = new Label();
            label2 = new Label();
            textBoxlogin = new TextBox();
            textsenhabox = new TextBox();
            SuspendLayout();
            // 
            // buttonEnter
            // 
            buttonEnter.BackColor = SystemColors.Info;
            buttonEnter.Location = new Point(143, 126);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(56, 22);
            buttonEnter.TabIndex = 2;
            buttonEnter.Text = "Entrar";
            buttonEnter.UseVisualStyleBackColor = false;
            buttonEnter.Click += buttonEnter_Click;
            // 
            // textBoxUsuário
            // 
            textBoxUsuário.AutoSize = true;
            textBoxUsuário.BackColor = SystemColors.Info;
            textBoxUsuário.Location = new Point(64, 72);
            textBoxUsuário.Name = "textBoxUsuário";
            textBoxUsuário.Size = new Size(37, 15);
            textBoxUsuário.TabIndex = 3;
            textBoxUsuário.Text = "Login";
            // 
            // textBoxSenha
            // 
            textBoxSenha.AutoSize = true;
            textBoxSenha.BackColor = SystemColors.Info;
            textBoxSenha.Location = new Point(62, 96);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(39, 15);
            textBoxSenha.TabIndex = 4;
            textBoxSenha.Text = "Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Info;
            label3.Font = new Font("Snap ITC", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(315, 31);
            label3.TabIndex = 5;
            label3.Text = "Tropa do menino Ney";
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelResultado.Location = new Point(40, 182);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(0, 27);
            labelResultado.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(495, 133);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 7;
            // 
            // test
            // 
            test.AutoSize = true;
            test.Location = new Point(508, 132);
            test.Name = "test";
            test.Size = new Size(0, 15);
            test.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(519, 145);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 11;
            // 
            // textBoxlogin
            // 
            textBoxlogin.BackColor = SystemColors.Info;
            textBoxlogin.Location = new Point(107, 64);
            textBoxlogin.Name = "textBoxlogin";
            textBoxlogin.Size = new Size(132, 23);
            textBoxlogin.TabIndex = 15;
            // 
            // textsenhabox
            // 
            textsenhabox.BackColor = SystemColors.Info;
            textsenhabox.Location = new Point(107, 93);
            textsenhabox.Name = "textsenhabox";
            textsenhabox.Size = new Size(132, 23);
            textsenhabox.TabIndex = 16;
            // 
            // formlogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            BackgroundImage = Properties.Resources.neymar_brazil_2022_1668947300_97010;
            ClientSize = new Size(923, 557);
            Controls.Add(textsenhabox);
            Controls.Add(textBoxlogin);
            Controls.Add(label2);
            Controls.Add(test);
            Controls.Add(label1);
            Controls.Add(labelResultado);
            Controls.Add(label3);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxUsuário);
            Controls.Add(buttonEnter);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "formlogin";
            Text = "login";
            Load += formlogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView textBoxUsuario;
        private Button buttonEnter;
        private Label textBoxUsuário;
        private Label textBoxSenha;
        private Label label3;
        private Label labelResultado;
        private Label label1;
        private Label test;
        private Label label2;
        private TextBox textBoxlogin;
        private TextBox textsenhabox;
    }
}
