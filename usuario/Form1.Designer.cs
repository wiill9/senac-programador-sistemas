namespace usuario
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonEntrar1 = new Button();
            textboxlogin1 = new TextBox();
            textboxsenha2 = new TextBox();
            labelresultado = new Label();
            buttonCadrasto4 = new Button();
            textboxsenha3 = new TextBox();
            textBoxlogin2 = new TextBox();
            labelresultadocadrasto = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // buttonEntrar1
            // 
            buttonEntrar1.Location = new Point(102, 156);
            buttonEntrar1.Name = "buttonEntrar1";
            buttonEntrar1.Size = new Size(75, 23);
            buttonEntrar1.TabIndex = 0;
            buttonEntrar1.Text = "ENTRAR";
            buttonEntrar1.UseVisualStyleBackColor = true;
            buttonEntrar1.Click += buttonEntrar1_Click;
            // 
            // textboxlogin1
            // 
            textboxlogin1.Location = new Point(90, 67);
            textboxlogin1.Name = "textboxlogin1";
            textboxlogin1.Size = new Size(115, 23);
            textboxlogin1.TabIndex = 1;
            // 
            // textboxsenha2
            // 
            textboxsenha2.Location = new Point(90, 107);
            textboxsenha2.Name = "textboxsenha2";
            textboxsenha2.Size = new Size(115, 23);
            textboxsenha2.TabIndex = 2;
            // 
            // labelresultado
            // 
            labelresultado.AutoSize = true;
            labelresultado.Location = new Point(58, 255);
            labelresultado.Name = "labelresultado";
            labelresultado.Size = new Size(0, 15);
            labelresultado.TabIndex = 3;
            // 
            // buttonCadrasto4
            // 
            buttonCadrasto4.Location = new Point(542, 156);
            buttonCadrasto4.Name = "buttonCadrasto4";
            buttonCadrasto4.Size = new Size(92, 23);
            buttonCadrasto4.TabIndex = 4;
            buttonCadrasto4.Text = "CADRASTAR ";
            buttonCadrasto4.UseVisualStyleBackColor = true;
            buttonCadrasto4.Click += buttonCadrasto4_Click;
            // 
            // textboxsenha3
            // 
            textboxsenha3.Location = new Point(542, 107);
            textboxsenha3.Name = "textboxsenha3";
            textboxsenha3.Size = new Size(125, 23);
            textboxsenha3.TabIndex = 5;
            textboxsenha3.TextChanged += textBox3_TextChanged;
            // 
            // textBoxlogin2
            // 
            textBoxlogin2.Location = new Point(542, 64);
            textBoxlogin2.Name = "textBoxlogin2";
            textBoxlogin2.Size = new Size(125, 23);
            textBoxlogin2.TabIndex = 6;
            // 
            // labelresultadocadrasto
            // 
            labelresultadocadrasto.AutoSize = true;
            labelresultadocadrasto.Location = new Point(500, 245);
            labelresultadocadrasto.Name = "labelresultadocadrasto";
            labelresultadocadrasto.Size = new Size(0, 15);
            labelresultadocadrasto.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 75);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 8;
            label3.Text = "Login ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 115);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 9;
            label4.Text = "Senha ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(484, 67);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 10;
            label5.Text = "Login";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(484, 115);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 11;
            label6.Text = "Senha ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LimeGreen;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(301, 30);
            label1.TabIndex = 12;
            label1.Text = "TROPA DO MENINO NEY ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(500, 9);
            label2.Name = "label2";
            label2.Size = new Size(183, 30);
            label2.TabIndex = 13;
            label2.Text = "CADRASTE-SE ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(labelresultadocadrasto);
            Controls.Add(textBoxlogin2);
            Controls.Add(textboxsenha3);
            Controls.Add(buttonCadrasto4);
            Controls.Add(labelresultado);
            Controls.Add(textboxsenha2);
            Controls.Add(textboxlogin1);
            Controls.Add(buttonEntrar1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEntrar1;
        private TextBox textboxlogin1;
        private TextBox textboxsenha2;
        private Label labelresultado;
        private Button buttonCadrasto4;
        private TextBox textboxsenha3;
        private TextBox textBoxlogin2;
        private Label labelresultadocadrasto;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label1;
        private Label label2;
    }
}
