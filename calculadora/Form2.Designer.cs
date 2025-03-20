namespace calculadora
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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            comboBoxfiguras = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textboxvalor1 = new TextBox();
            textboxvalor2 = new TextBox();
            texboxvalor3 = new TextBox();
            textresultado = new TextBox();
            texboxvalor4 = new TextBox();
            label5 = new Label();
            textresul = new TextBox();
            label6 = new Label();
            radioButton5 = new RadioButton();
            buttoncalcular = new Button();
            buttoncalculo = new Button();
            label7 = new Label();
            label8 = new Label();
            valor7 = new TextBox();
            texboxvalor5 = new TextBox();
            radioButton10 = new RadioButton();
            buttoncall = new Button();
            radioButton4 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton8 = new RadioButton();
            radioButton9 = new RadioButton();
            labelresultado = new Label();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(225, 52);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(80, 19);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "Perimetro ";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(225, 73);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(49, 19);
            radioButton2.TabIndex = 10;
            radioButton2.TabStop = true;
            radioButton2.Text = "Area";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(225, 98);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(68, 19);
            radioButton3.TabIndex = 11;
            radioButton3.TabStop = true;
            radioButton3.Text = "Volume ";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // comboBoxfiguras
            // 
            comboBoxfiguras.AutoCompleteCustomSource.AddRange(new string[] { "Quadrado ", "Triangulo", "Circulo " });
            comboBoxfiguras.FormattingEnabled = true;
            comboBoxfiguras.Location = new Point(12, 13);
            comboBoxfiguras.Name = "comboBoxfiguras";
            comboBoxfiguras.Size = new Size(134, 23);
            comboBoxfiguras.TabIndex = 0;
            comboBoxfiguras.Text = "Selecione uma figura ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 60);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 1;
            label1.Text = "Largura:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 89);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Altura:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1, 114);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 3;
            label3.Text = "Comprimento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 147);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 4;
            label4.Text = "Resultado :";
            // 
            // textboxvalor1
            // 
            textboxvalor1.Location = new Point(92, 52);
            textboxvalor1.Name = "textboxvalor1";
            textboxvalor1.Size = new Size(100, 23);
            textboxvalor1.TabIndex = 5;
            textboxvalor1.TextChanged += textBox1_TextChanged;
            // 
            // textboxvalor2
            // 
            textboxvalor2.Location = new Point(92, 82);
            textboxvalor2.Name = "textboxvalor2";
            textboxvalor2.Size = new Size(100, 23);
            textboxvalor2.TabIndex = 6;
            textboxvalor2.TextChanged += textBox2_TextChanged;
            // 
            // texboxvalor3
            // 
            texboxvalor3.Location = new Point(92, 111);
            texboxvalor3.Name = "texboxvalor3";
            texboxvalor3.Size = new Size(100, 23);
            texboxvalor3.TabIndex = 7;
            // 
            // textresultado
            // 
            textresultado.Location = new Point(92, 144);
            textresultado.Name = "textresultado";
            textresultado.Size = new Size(100, 23);
            textresultado.TabIndex = 8;
            textresultado.TextChanged += textBox4_TextChanged;
            // 
            // texboxvalor4
            // 
            texboxvalor4.Location = new Point(625, 49);
            texboxvalor4.Name = "texboxvalor4";
            texboxvalor4.Size = new Size(100, 23);
            texboxvalor4.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(553, 54);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 14;
            label5.Text = "Lado:";
            // 
            // textresul
            // 
            textresul.Location = new Point(625, 89);
            textresul.Name = "textresul";
            textresul.Size = new Size(100, 23);
            textresul.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(553, 89);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 16;
            label6.Text = "Resultado:";
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(750, 49);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(80, 19);
            radioButton5.TabIndex = 18;
            radioButton5.TabStop = true;
            radioButton5.Text = "Perimetro ";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // buttoncalcular
            // 
            buttoncalcular.Location = new Point(334, 70);
            buttoncalcular.Name = "buttoncalcular";
            buttoncalcular.Size = new Size(75, 23);
            buttoncalcular.TabIndex = 12;
            buttoncalcular.Text = "Calcular";
            buttoncalcular.UseVisualStyleBackColor = true;
            buttoncalcular.Click += button1_Click;
            // 
            // buttoncalculo
            // 
            buttoncalculo.Location = new Point(847, 69);
            buttoncalculo.Name = "buttoncalculo";
            buttoncalculo.Size = new Size(75, 23);
            buttoncalculo.TabIndex = 19;
            buttoncalculo.Text = "Calcular";
            buttoncalculo.UseVisualStyleBackColor = true;
            buttoncalculo.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 276);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 21;
            label7.Text = "Resultado:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 242);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 22;
            label8.Text = "Raio:";
            // 
            // valor7
            // 
            valor7.Location = new Point(92, 272);
            valor7.Name = "valor7";
            valor7.Size = new Size(100, 23);
            valor7.TabIndex = 23;
            // 
            // texboxvalor5
            // 
            texboxvalor5.Location = new Point(92, 234);
            texboxvalor5.Name = "texboxvalor5";
            texboxvalor5.Size = new Size(100, 23);
            texboxvalor5.TabIndex = 24;
            // 
            // radioButton10
            // 
            radioButton10.AutoSize = true;
            radioButton10.Location = new Point(246, 232);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new Size(74, 19);
            radioButton10.TabIndex = 28;
            radioButton10.TabStop = true;
            radioButton10.Text = "Diametro";
            radioButton10.UseVisualStyleBackColor = true;
            // 
            // buttoncall
            // 
            buttoncall.Location = new Point(361, 257);
            buttoncall.Name = "buttoncall";
            buttoncall.Size = new Size(75, 23);
            buttoncall.TabIndex = 29;
            buttoncall.Text = "Calcular";
            buttoncall.UseVisualStyleBackColor = true;
            buttoncall.Click += button3_Click;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(750, 74);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(49, 19);
            radioButton4.TabIndex = 30;
            radioButton4.TabStop = true;
            radioButton4.Text = "Area";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(750, 98);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(68, 19);
            radioButton6.TabIndex = 31;
            radioButton6.TabStop = true;
            radioButton6.Text = "Volume ";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(246, 257);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(80, 19);
            radioButton7.TabIndex = 32;
            radioButton7.TabStop = true;
            radioButton7.Text = "Perimetro ";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(246, 282);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(49, 19);
            radioButton8.TabIndex = 33;
            radioButton8.TabStop = true;
            radioButton8.Text = "Area";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.Location = new Point(246, 307);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(68, 19);
            radioButton9.TabIndex = 34;
            radioButton9.TabStop = true;
            radioButton9.Text = "Volume ";
            radioButton9.UseVisualStyleBackColor = true;
            // 
            // labelresultado
            // 
            labelresultado.AutoSize = true;
            labelresultado.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelresultado.Location = new Point(551, 265);
            labelresultado.Name = "labelresultado";
            labelresultado.Size = new Size(0, 25);
            labelresultado.TabIndex = 35;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 359);
            Controls.Add(labelresultado);
            Controls.Add(radioButton9);
            Controls.Add(radioButton8);
            Controls.Add(radioButton7);
            Controls.Add(radioButton6);
            Controls.Add(radioButton4);
            Controls.Add(buttoncall);
            Controls.Add(radioButton10);
            Controls.Add(texboxvalor5);
            Controls.Add(valor7);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(buttoncalculo);
            Controls.Add(radioButton5);
            Controls.Add(label6);
            Controls.Add(textresul);
            Controls.Add(label5);
            Controls.Add(texboxvalor4);
            Controls.Add(buttoncalcular);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textresultado);
            Controls.Add(texboxvalor3);
            Controls.Add(textboxvalor2);
            Controls.Add(textboxvalor1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxfiguras);
            Name = "Form2";
            Text = "Geometria ";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private ComboBox comboBoxfiguras;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textboxvalor1;
        private TextBox textboxvalor2;
        private TextBox texboxvalor3;
        private TextBox textresultado;
        private TextBox texboxvalor4;
        private Label label5;
        private TextBox textresul;
        private Label label6;
        private RadioButton radioButton5;
        private Button buttoncalcular;
        private Button buttoncalculo;
        private Label label7;
        private Label label8;
        private TextBox valor7;
        private TextBox texboxvalor5;
        private RadioButton radioButton10;
        private Button buttoncall;
        private RadioButton radioButton4;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
        private RadioButton radioButton9;
        private Label labelresultado;
    }
}