namespace ConversorDeNumerosRomanos.WinFormsApp
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
            this.btConverter = new System.Windows.Forms.Button();
            this.txRomano = new System.Windows.Forms.TextBox();
            this.lbResposta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btConverter
            // 
            this.btConverter.Location = new System.Drawing.Point(131, 93);
            this.btConverter.Name = "btConverter";
            this.btConverter.Size = new System.Drawing.Size(92, 27);
            this.btConverter.TabIndex = 0;
            this.btConverter.Text = "Converter";
            this.btConverter.UseVisualStyleBackColor = true;
            this.btConverter.Click += new System.EventHandler(this.btConverter_Click);
            // 
            // txRomano
            // 
            this.txRomano.Location = new System.Drawing.Point(116, 51);
            this.txRomano.Name = "txRomano";
            this.txRomano.Size = new System.Drawing.Size(125, 27);
            this.txRomano.TabIndex = 1;
            // 
            // lbResposta
            // 
            this.lbResposta.AutoSize = true;
            this.lbResposta.Location = new System.Drawing.Point(12, 135);
            this.lbResposta.Name = "lbResposta";
            this.lbResposta.Size = new System.Drawing.Size(89, 20);
            this.lbResposta.TabIndex = 2;
            this.lbResposta.Text = "<Resposta>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Digite o Número";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 173);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbResposta);
            this.Controls.Add(this.txRomano);
            this.Controls.Add(this.btConverter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de Numeros Romanos para Arábico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConverter;
        private System.Windows.Forms.TextBox txRomano;
        private System.Windows.Forms.Label lbResposta;
        private System.Windows.Forms.Label label2;
    }
}
