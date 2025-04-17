namespace ListaAtividade
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
            dataGridViewatividades = new DataGridView();
            textBox1 = new TextBox();
            buttonfinalizar = new Button();
            buttonatualizar = new Button();
            buttoncriar = new Button();
            labelErro = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewatividades).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewatividades
            // 
            dataGridViewatividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewatividades.Location = new Point(12, 41);
            dataGridViewatividades.Name = "dataGridViewatividades";
            dataGridViewatividades.Size = new Size(485, 376);
            dataGridViewatividades.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(485, 23);
            textBox1.TabIndex = 1;
            // 
            // buttonfinalizar
            // 
            buttonfinalizar.Location = new Point(503, 11);
            buttonfinalizar.Name = "buttonfinalizar";
            buttonfinalizar.Size = new Size(125, 23);
            buttonfinalizar.TabIndex = 2;
            buttonfinalizar.Text = "FINALIZAR";
            buttonfinalizar.UseVisualStyleBackColor = true;
            buttonfinalizar.Click += buttonfinalizar_Click;
            // 
            // buttonatualizar
            // 
            buttonatualizar.Location = new Point(503, 40);
            buttonatualizar.Name = "buttonatualizar";
            buttonatualizar.Size = new Size(125, 23);
            buttonatualizar.TabIndex = 3;
            buttonatualizar.Text = "ATUALIZAR ";
            buttonatualizar.UseVisualStyleBackColor = true;
            buttonatualizar.Click += buttonatualizar_Click;
            // 
            // buttoncriar
            // 
            buttoncriar.Location = new Point(503, 394);
            buttoncriar.Name = "buttoncriar";
            buttoncriar.Size = new Size(125, 23);
            buttoncriar.TabIndex = 4;
            buttoncriar.Text = "CRIAR";
            buttoncriar.UseVisualStyleBackColor = true;
            buttoncriar.Click += buttoncriar_Click;
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(12, 426);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(0, 15);
            labelErro.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 450);
            Controls.Add(labelErro);
            Controls.Add(buttoncriar);
            Controls.Add(buttonatualizar);
            Controls.Add(buttonfinalizar);
            Controls.Add(textBox1);
            Controls.Add(dataGridViewatividades);
            Name = "Form1";
            Text = "ListaDeAtividades.cs";
            ((System.ComponentModel.ISupportInitialize)dataGridViewatividades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewatividades;
        private TextBox textBox1;
        private Button buttonfinalizar;
        private Button buttonatualizar;
        private Button buttoncriar;
        private Label labelErro;
    }
}
