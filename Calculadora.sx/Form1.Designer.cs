namespace Calculadora.sx
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
            textBoxValor1 = new TextBox();
            textBoxValor2 = new TextBox();
            labelresultado = new Label();
            SuspendLayout();
            // 
            // textBoxValor1
            // 
            textBoxValor1.Location = new Point(26, 61);
            textBoxValor1.Name = "textBoxValor1";
            textBoxValor1.Size = new Size(100, 23);
            textBoxValor1.TabIndex = 0;
            textBoxValor1.TextChanged += textBoxValor1_TextChanged;
            // 
            // textBoxValor2
            // 
            textBoxValor2.Location = new Point(175, 61);
            textBoxValor2.Name = "textBoxValor2";
            textBoxValor2.Size = new Size(100, 23);
            textBoxValor2.TabIndex = 0;
            // 
            // labelresultado
            // 
            labelresultado.AutoSize = true;
            labelresultado.Location = new Point(12, 159);
            labelresultado.Name = "labelresultado";
            labelresultado.Size = new Size(100, 15);
            labelresultado.TabIndex = 1;
            labelresultado.Text = "Insira dois valores";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelresultado);
            Controls.Add(textBoxValor2);
            Controls.Add(textBoxValor1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxValor1;
        private TextBox textBoxValor2;
        private Label labelresultado;
    }
}
