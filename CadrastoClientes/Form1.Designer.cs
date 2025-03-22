namespace CadrastoClientes
{
    partial class Form1
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
            textboxName = new TextBox();
            textBoxendereco = new TextBox();
            textBoxemail = new TextBox();
            textBoxnomesocial = new TextBox();
            textboxtelefone = new TextBox();
            textboxID = new TextBox();
            comboBoxGenero = new ComboBox();
            cheeckEstrangeiro = new CheckBox();
            datadenascimento = new DateTimePicker();
            buttoncadastro = new Button();
            label1 = new Label();
            combobox01 = new ComboBox();
            textBoxlogradouro = new TextBox();
            textBoxbairro = new TextBox();
            textboxmunicipio = new TextBox();
            textBoxEstado = new TextBox();
            textboxcep = new TextBox();
            textboxnumero = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            Labelresultado = new Label();
            dataGridViewclientes = new DataGridView();
            textboxcomplemento = new TextBox();
            Complemento = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewclientes).BeginInit();
            SuspendLayout();
            // 
            // textboxName
            // 
            textboxName.Location = new Point(28, 150);
            textboxName.Name = "textboxName";
            textboxName.Size = new Size(230, 23);
            textboxName.TabIndex = 0;
            // 
            // textBoxendereco
            // 
            textBoxendereco.Location = new Point(28, 336);
            textBoxendereco.Name = "textBoxendereco";
            textBoxendereco.Size = new Size(230, 23);
            textBoxendereco.TabIndex = 1;
            // 
            // textBoxemail
            // 
            textBoxemail.Location = new Point(28, 291);
            textBoxemail.Name = "textBoxemail";
            textBoxemail.Size = new Size(230, 23);
            textBoxemail.TabIndex = 2;
            // 
            // textBoxnomesocial
            // 
            textBoxnomesocial.Location = new Point(28, 250);
            textBoxnomesocial.Name = "textBoxnomesocial";
            textBoxnomesocial.Size = new Size(230, 23);
            textBoxnomesocial.TabIndex = 3;
            // 
            // textboxtelefone
            // 
            textboxtelefone.Location = new Point(28, 205);
            textboxtelefone.Name = "textboxtelefone";
            textboxtelefone.Size = new Size(230, 23);
            textboxtelefone.TabIndex = 4;
            // 
            // textboxID
            // 
            textboxID.Location = new Point(28, 100);
            textboxID.Name = "textboxID";
            textboxID.Size = new Size(230, 23);
            textboxID.TabIndex = 5;
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.AutoCompleteCustomSource.AddRange(new string[] { "" });
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Items.AddRange(new object[] { "Cisgenêro", "Transgenêro ", "Não-binario " });
            comboBoxGenero.Location = new Point(307, 164);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(162, 23);
            comboBoxGenero.TabIndex = 6;
            comboBoxGenero.Text = "Selecione seu Genero ";
            comboBoxGenero.UseWaitCursor = true;
            // 
            // cheeckEstrangeiro
            // 
            cheeckEstrangeiro.AutoSize = true;
            cheeckEstrangeiro.Location = new Point(334, 250);
            cheeckEstrangeiro.Name = "cheeckEstrangeiro";
            cheeckEstrangeiro.Size = new Size(108, 19);
            cheeckEstrangeiro.TabIndex = 7;
            cheeckEstrangeiro.Text = "Sou Estrangeiro";
            cheeckEstrangeiro.UseVisualStyleBackColor = true;
            // 
            // datadenascimento
            // 
            datadenascimento.Location = new Point(286, 205);
            datadenascimento.Name = "datadenascimento";
            datadenascimento.Size = new Size(200, 23);
            datadenascimento.TabIndex = 8;
            datadenascimento.Value = new DateTime(2025, 3, 25, 23, 59, 59, 0);
            // 
            // buttoncadastro
            // 
            buttoncadastro.Location = new Point(89, 375);
            buttoncadastro.Name = "buttoncadastro";
            buttoncadastro.Size = new Size(100, 26);
            buttoncadastro.TabIndex = 9;
            buttoncadastro.Text = "CADRASTAR";
            buttoncadastro.UseVisualStyleBackColor = true;
            buttoncadastro.Click += buttoncadastro_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(241, 299);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 10;
            // 
            // combobox01
            // 
            combobox01.AutoCompleteCustomSource.AddRange(new string[] { "" });
            combobox01.FormattingEnabled = true;
            combobox01.Items.AddRange(new object[] { "Branco ", "Preto", "Pardo", "Indigena", "Amarelo " });
            combobox01.Location = new Point(307, 135);
            combobox01.Name = "combobox01";
            combobox01.Size = new Size(162, 23);
            combobox01.TabIndex = 11;
            combobox01.Text = "Etnia ";
            // 
            // textBoxlogradouro
            // 
            textBoxlogradouro.Location = new Point(512, 100);
            textBoxlogradouro.Name = "textBoxlogradouro";
            textBoxlogradouro.Size = new Size(230, 23);
            textBoxlogradouro.TabIndex = 12;
            // 
            // textBoxbairro
            // 
            textBoxbairro.Location = new Point(512, 205);
            textBoxbairro.Name = "textBoxbairro";
            textBoxbairro.Size = new Size(230, 23);
            textBoxbairro.TabIndex = 13;
            // 
            // textboxmunicipio
            // 
            textboxmunicipio.Location = new Point(512, 246);
            textboxmunicipio.Name = "textboxmunicipio";
            textboxmunicipio.Size = new Size(230, 23);
            textboxmunicipio.TabIndex = 14;
            // 
            // textBoxEstado
            // 
            textBoxEstado.Location = new Point(512, 296);
            textBoxEstado.Name = "textBoxEstado";
            textBoxEstado.Size = new Size(230, 23);
            textBoxEstado.TabIndex = 15;
            // 
            // textboxcep
            // 
            textboxcep.Location = new Point(512, 150);
            textboxcep.Name = "textboxcep";
            textboxcep.Size = new Size(230, 23);
            textboxcep.TabIndex = 16;
            // 
            // textboxnumero
            // 
            textboxnumero.Location = new Point(512, 340);
            textboxnumero.Name = "textboxnumero";
            textboxnumero.Size = new Size(230, 23);
            textboxnumero.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(291, 19);
            label2.Name = "label2";
            label2.Size = new Size(194, 30);
            label2.TabIndex = 18;
            label2.Text = "CADRASTRE-SE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 132);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 19;
            label3.Text = "Nome ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(512, 82);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 20;
            label4.Text = "Logradouro ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 318);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 21;
            label5.Text = "Endereço";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 273);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 22;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 231);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 23;
            label7.Text = "Nome Social";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 187);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 24;
            label8.Text = "Telefone";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(28, 82);
            label9.Name = "label9";
            label9.Size = new Size(18, 15);
            label9.TabIndex = 25;
            label9.Text = "ID";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(512, 322);
            label10.Name = "label10";
            label10.Size = new Size(54, 15);
            label10.TabIndex = 26;
            label10.Text = "Numero ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(512, 278);
            label11.Name = "label11";
            label11.Size = new Size(45, 15);
            label11.TabIndex = 27;
            label11.Text = "Estado ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(512, 231);
            label12.Name = "label12";
            label12.Size = new Size(64, 15);
            label12.TabIndex = 28;
            label12.Text = "Municipio ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(512, 187);
            label13.Name = "label13";
            label13.Size = new Size(41, 15);
            label13.TabIndex = 29;
            label13.Text = "Bairro ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(512, 132);
            label14.Name = "label14";
            label14.Size = new Size(28, 15);
            label14.TabIndex = 30;
            label14.Text = "CEP";
            // 
            // Labelresultado
            // 
            Labelresultado.AutoSize = true;
            Labelresultado.BackColor = Color.Lime;
            Labelresultado.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Labelresultado.Location = new Point(349, 402);
            Labelresultado.Name = "Labelresultado";
            Labelresultado.Size = new Size(0, 23);
            Labelresultado.TabIndex = 31;
            // 
            // dataGridViewclientes
            // 
            dataGridViewclientes.AllowUserToAddRows = false;
            dataGridViewclientes.AllowUserToDeleteRows = false;
            dataGridViewclientes.AllowUserToOrderColumns = true;
            dataGridViewclientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewclientes.Location = new Point(831, 12);
            dataGridViewclientes.Name = "dataGridViewclientes";
            dataGridViewclientes.ReadOnly = true;
            dataGridViewclientes.Size = new Size(592, 585);
            dataGridViewclientes.TabIndex = 32;
            // 
            // textboxcomplemento
            // 
            textboxcomplemento.Location = new Point(513, 384);
            textboxcomplemento.Name = "textboxcomplemento";
            textboxcomplemento.Size = new Size(230, 23);
            textboxcomplemento.TabIndex = 33;
            // 
            // Complemento
            // 
            Complemento.AutoSize = true;
            Complemento.Location = new Point(513, 366);
            Complemento.Name = "Complemento";
            Complemento.Size = new Size(84, 15);
            Complemento.TabIndex = 34;
            Complemento.Text = "Complemento";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1435, 603);
            Controls.Add(Complemento);
            Controls.Add(textboxcomplemento);
            Controls.Add(dataGridViewclientes);
            Controls.Add(Labelresultado);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textboxnumero);
            Controls.Add(textboxcep);
            Controls.Add(textBoxEstado);
            Controls.Add(textboxmunicipio);
            Controls.Add(textBoxbairro);
            Controls.Add(textBoxlogradouro);
            Controls.Add(combobox01);
            Controls.Add(label1);
            Controls.Add(buttoncadastro);
            Controls.Add(datadenascimento);
            Controls.Add(cheeckEstrangeiro);
            Controls.Add(comboBoxGenero);
            Controls.Add(textboxID);
            Controls.Add(textboxtelefone);
            Controls.Add(textBoxnomesocial);
            Controls.Add(textBoxemail);
            Controls.Add(textBoxendereco);
            Controls.Add(textboxName);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewclientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textboxName;
        private TextBox textBoxendereco;
        private TextBox textBoxemail;
        private TextBox textBoxnomesocial;
        private TextBox textboxtelefone;
        private TextBox textboxID;
        private ComboBox comboBoxGenero;
        private CheckBox cheeckEstrangeiro;
        private DateTimePicker datadenascimento;
        private Button buttoncadastro;
        private Label label1;
        private ComboBox combobox01;
        private TextBox textBoxlogradouro;
        private TextBox textBoxbairro;
        private TextBox textboxmunicipio;
        private TextBox textBoxEstado;
        private TextBox textboxcep;
        private TextBox textboxnumero;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label Labelresultado;
        private DataGridView dataGridViewclientes;
        private TextBox textboxcomplemento;
        private Label Complemento;
    }
}