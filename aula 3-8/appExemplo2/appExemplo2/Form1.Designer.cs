namespace appExemplo2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRaio = new System.Windows.Forms.TextBox();
            this.cmdCalcular = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtResultado);
            this.groupBox1.Controls.Add(this.Resultado);
            this.groupBox1.Controls.Add(this.cmdCalcular);
            this.groupBox1.Controls.Add(this.txtRaio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 372);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Área do Círculo";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe o raio da circunferência";
            // 
            // txtRaio
            // 
            this.txtRaio.Location = new System.Drawing.Point(6, 54);
            this.txtRaio.Name = "txtRaio";
            this.txtRaio.Size = new System.Drawing.Size(268, 29);
            this.txtRaio.TabIndex = 1;
            // 
            // cmdCalcular
            // 
            this.cmdCalcular.Location = new System.Drawing.Point(6, 103);
            this.cmdCalcular.Name = "cmdCalcular";
            this.cmdCalcular.Size = new System.Drawing.Size(268, 32);
            this.cmdCalcular.TabIndex = 2;
            this.cmdCalcular.Text = "Calcular Área";
            this.cmdCalcular.UseVisualStyleBackColor = false;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(6, 210);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(268, 135);
            this.txtResultado.TabIndex = 4;
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Location = new System.Drawing.Point(6, 186);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(86, 21);
            this.Resultado.TabIndex = 3;
            this.Resultado.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 606);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtResultado;
        private Label Resultado;
        private Button cmdCalcular;
        private TextBox txtRaio;
        private Label label1;
    }
}