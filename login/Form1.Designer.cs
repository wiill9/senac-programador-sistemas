
namespace login
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
            label4 = new Label();
            textBoxnovomembrojr = new TextBox();
            textBoxnovasenha = new TextBox();
            buttoncd = new Button();
            button1 = new Button();
            button2 = new Button();
            labelneymarjrnovo = new Label();
            labelneymarjunior = new Label();
            SuspendLayout();
            // 
            // buttonEnter
            // 
            buttonEnter.BackColor = Color.DeepSkyBlue;
            buttonEnter.ForeColor = Color.Gold;
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
            textBoxUsuário.BackColor = Color.ForestGreen;
            textBoxUsuário.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxUsuário.Location = new Point(52, 66);
            textBoxUsuário.Name = "textBoxUsuário";
            textBoxUsuário.Size = new Size(49, 15);
            textBoxUsuário.TabIndex = 3;
            textBoxUsuário.Text = "Login";
            // 
            // textBoxSenha
            // 
            textBoxSenha.AutoSize = true;
            textBoxSenha.BackColor = Color.Gold;
            textBoxSenha.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBoxSenha.Location = new Point(50, 95);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(51, 15);
            textBoxSenha.TabIndex = 4;
            textBoxSenha.Text = "Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gold;
            label3.Font = new Font("Snap ITC", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.ForestGreen;
            label3.Location = new Point(5, 9);
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
            label1.Location = new Point(714, 167);
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
            textBoxlogin.BackColor = Color.Gold;
            textBoxlogin.Location = new Point(107, 64);
            textBoxlogin.Name = "textBoxlogin";
            textBoxlogin.Size = new Size(132, 23);
            textBoxlogin.TabIndex = 15;
            // 
            // textsenhabox
            // 
            textsenhabox.BackColor = Color.ForestGreen;
            textsenhabox.Location = new Point(107, 93);
            textsenhabox.Name = "textsenhabox";
            textsenhabox.Size = new Size(132, 23);
            textsenhabox.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Yellow;
            label4.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.ForestGreen;
            label4.Location = new Point(690, 9);
            label4.Name = "label4";
            label4.Size = new Size(221, 33);
            label4.TabIndex = 18;
            label4.Text = "NOVO MEMBRO";
            // 
            // textBoxnovomembrojr
            // 
            textBoxnovomembrojr.BackColor = Color.Gold;
            textBoxnovomembrojr.Location = new Point(771, 46);
            textBoxnovomembrojr.Name = "textBoxnovomembrojr";
            textBoxnovomembrojr.Size = new Size(123, 23);
            textBoxnovomembrojr.TabIndex = 20;
            textBoxnovomembrojr.TextChanged += TextBoxnovomembrojr_TextChanged;
            // 
            // textBoxnovasenha
            // 
            textBoxnovasenha.BackColor = Color.ForestGreen;
            textBoxnovasenha.Location = new Point(771, 75);
            textBoxnovasenha.Name = "textBoxnovasenha";
            textBoxnovasenha.Size = new Size(123, 23);
            textBoxnovasenha.TabIndex = 22;
            textBoxnovasenha.TextChanged += textBoxnovasenha_TextChanged;
            // 
            // buttoncd
            // 
            buttoncd.BackColor = Color.Gold;
            buttoncd.ForeColor = Color.DeepSkyBlue;
            buttoncd.Location = new Point(758, 104);
            buttoncd.Name = "buttoncd";
            buttoncd.Size = new Size(75, 23);
            buttoncd.TabIndex = 23;
            buttoncd.Text = "Cadastrar ";
            buttoncd.UseVisualStyleBackColor = false;
            buttoncd.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Gold;
            button1.Location = new Point(663, 46);
            button1.Name = "button1";
            button1.Size = new Size(102, 23);
            button1.TabIndex = 26;
            button1.Text = "Usuario";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Gold;
            button2.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.ForestGreen;
            button2.Location = new Point(663, 75);
            button2.Name = "button2";
            button2.Size = new Size(102, 23);
            button2.TabIndex = 27;
            button2.Text = "Senha ";
            button2.UseVisualStyleBackColor = false;
            // 
            // labelneymarjrnovo
            // 
            labelneymarjrnovo.AutoSize = true;
            labelneymarjrnovo.Font = new Font("Elephant", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelneymarjrnovo.ForeColor = SystemColors.Highlight;
            labelneymarjrnovo.Location = new Point(578, 186);
            labelneymarjrnovo.Name = "labelneymarjrnovo";
            labelneymarjrnovo.Size = new Size(0, 25);
            labelneymarjrnovo.TabIndex = 28;
            // 
            // labelneymarjunior
            // 
            labelneymarjunior.AutoSize = true;
            labelneymarjunior.Location = new Point(758, 167);
            labelneymarjunior.Name = "labelneymarjunior";
            labelneymarjunior.Size = new Size(0, 15);
            labelneymarjunior.TabIndex = 29;
            // 
            // formlogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            BackgroundImage = Properties.Resources.neymar_brazil_2022_1668947300_97010;
            ClientSize = new Size(923, 557);
            Controls.Add(labelneymarjunior);
            Controls.Add(labelneymarjrnovo);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttoncd);
            Controls.Add(textBoxnovasenha);
            Controls.Add(textBoxnovomembrojr);
            Controls.Add(label4);
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
        private Label label4;
        private TextBox textBoxnovomembrojr;
        private TextBox textBoxnovasenha;
        private Button buttoncd;
        private TextBox button;
        private TextBox novasenhajr;
        private Button button1;
        private Button button2;
        private Label labelneymarjrnovo;
        private Label labelneymarjunior;
    }
}
