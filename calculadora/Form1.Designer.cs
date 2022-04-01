
namespace calculadora
{
    partial class calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calculadora));
            this.result = new System.Windows.Forms.TextBox();
            this.um = new System.Windows.Forms.Button();
            this.dois = new System.Windows.Forms.Button();
            this.tres = new System.Windows.Forms.Button();
            this.quatro = new System.Windows.Forms.Button();
            this.cinco = new System.Windows.Forms.Button();
            this.seis = new System.Windows.Forms.Button();
            this.sete = new System.Windows.Forms.Button();
            this.oito = new System.Windows.Forms.Button();
            this.nove = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.apagar = new System.Windows.Forms.Button();
            this.virgula = new System.Windows.Forms.Button();
            this.soma = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.result.Enabled = false;
            this.result.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result.Location = new System.Drawing.Point(13, 13);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(249, 33);
            this.result.TabIndex = 0;
            this.result.TabStop = false;
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // um
            // 
            this.um.Location = new System.Drawing.Point(13, 92);
            this.um.Name = "um";
            this.um.Size = new System.Drawing.Size(57, 35);
            this.um.TabIndex = 1;
            this.um.Text = "1";
            this.um.UseVisualStyleBackColor = true;
            this.um.Click += new System.EventHandler(this.um_Click);
            // 
            // dois
            // 
            this.dois.Location = new System.Drawing.Point(76, 92);
            this.dois.Name = "dois";
            this.dois.Size = new System.Drawing.Size(57, 35);
            this.dois.TabIndex = 2;
            this.dois.Text = "2";
            this.dois.UseVisualStyleBackColor = true;
            this.dois.Click += new System.EventHandler(this.dois_Click);
            // 
            // tres
            // 
            this.tres.Location = new System.Drawing.Point(139, 92);
            this.tres.Name = "tres";
            this.tres.Size = new System.Drawing.Size(57, 35);
            this.tres.TabIndex = 3;
            this.tres.Text = "3";
            this.tres.UseVisualStyleBackColor = true;
            this.tres.Click += new System.EventHandler(this.tres_Click);
            // 
            // quatro
            // 
            this.quatro.Location = new System.Drawing.Point(12, 133);
            this.quatro.Name = "quatro";
            this.quatro.Size = new System.Drawing.Size(57, 35);
            this.quatro.TabIndex = 4;
            this.quatro.Text = "4";
            this.quatro.UseVisualStyleBackColor = true;
            this.quatro.Click += new System.EventHandler(this.quatro_Click);
            // 
            // cinco
            // 
            this.cinco.Location = new System.Drawing.Point(76, 133);
            this.cinco.Name = "cinco";
            this.cinco.Size = new System.Drawing.Size(57, 35);
            this.cinco.TabIndex = 5;
            this.cinco.Text = "5";
            this.cinco.UseVisualStyleBackColor = true;
            this.cinco.Click += new System.EventHandler(this.cinco_Click);
            // 
            // seis
            // 
            this.seis.Location = new System.Drawing.Point(139, 133);
            this.seis.Name = "seis";
            this.seis.Size = new System.Drawing.Size(57, 35);
            this.seis.TabIndex = 6;
            this.seis.Text = "6";
            this.seis.UseVisualStyleBackColor = true;
            this.seis.Click += new System.EventHandler(this.seis_Click);
            // 
            // sete
            // 
            this.sete.Location = new System.Drawing.Point(12, 174);
            this.sete.Name = "sete";
            this.sete.Size = new System.Drawing.Size(57, 35);
            this.sete.TabIndex = 7;
            this.sete.Text = "7";
            this.sete.UseVisualStyleBackColor = true;
            this.sete.Click += new System.EventHandler(this.sete_Click);
            // 
            // oito
            // 
            this.oito.Location = new System.Drawing.Point(76, 174);
            this.oito.Name = "oito";
            this.oito.Size = new System.Drawing.Size(57, 35);
            this.oito.TabIndex = 8;
            this.oito.Text = "8";
            this.oito.UseVisualStyleBackColor = true;
            this.oito.Click += new System.EventHandler(this.oito_Click);
            // 
            // nove
            // 
            this.nove.Location = new System.Drawing.Point(139, 174);
            this.nove.Name = "nove";
            this.nove.Size = new System.Drawing.Size(57, 35);
            this.nove.TabIndex = 9;
            this.nove.Text = "9";
            this.nove.UseVisualStyleBackColor = true;
            this.nove.Click += new System.EventHandler(this.nove_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(12, 215);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(57, 35);
            this.zero.TabIndex = 10;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // apagar
            // 
            this.apagar.Location = new System.Drawing.Point(75, 215);
            this.apagar.Name = "apagar";
            this.apagar.Size = new System.Drawing.Size(57, 35);
            this.apagar.TabIndex = 11;
            this.apagar.Text = "C";
            this.apagar.UseVisualStyleBackColor = true;
            this.apagar.Click += new System.EventHandler(this.apagar_Click);
            // 
            // virgula
            // 
            this.virgula.Location = new System.Drawing.Point(139, 215);
            this.virgula.Name = "virgula";
            this.virgula.Size = new System.Drawing.Size(57, 35);
            this.virgula.TabIndex = 12;
            this.virgula.Text = ".";
            this.virgula.UseVisualStyleBackColor = true;
            this.virgula.Click += new System.EventHandler(this.virgula_Click);
            // 
            // soma
            // 
            this.soma.Location = new System.Drawing.Point(202, 92);
            this.soma.Name = "soma";
            this.soma.Size = new System.Drawing.Size(57, 35);
            this.soma.TabIndex = 13;
            this.soma.Text = "+";
            this.soma.UseVisualStyleBackColor = true;
            this.soma.Click += new System.EventHandler(this.soma_Click);
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(202, 133);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(57, 35);
            this.sub.TabIndex = 14;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(202, 174);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(57, 35);
            this.div.TabIndex = 15;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // mult
            // 
            this.mult.Location = new System.Drawing.Point(202, 215);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(57, 35);
            this.mult.TabIndex = 16;
            this.mult.Text = "*";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.mult_Click);
            // 
            // igual
            // 
            this.igual.Location = new System.Drawing.Point(13, 256);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(249, 35);
            this.igual.TabIndex = 17;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = true;
            this.igual.Click += new System.EventHandler(this.igual_Click);
            // 
            // calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(274, 307);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.div);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.soma);
            this.Controls.Add(this.virgula);
            this.Controls.Add(this.apagar);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.nove);
            this.Controls.Add(this.oito);
            this.Controls.Add(this.sete);
            this.Controls.Add(this.seis);
            this.Controls.Add(this.cinco);
            this.Controls.Add(this.quatro);
            this.Controls.Add(this.tres);
            this.Controls.Add(this.dois);
            this.Controls.Add(this.um);
            this.Controls.Add(this.result);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button um;
        private System.Windows.Forms.Button dois;
        private System.Windows.Forms.Button tres;
        private System.Windows.Forms.Button quatro;
        private System.Windows.Forms.Button cinco;
        private System.Windows.Forms.Button seis;
        private System.Windows.Forms.Button sete;
        private System.Windows.Forms.Button oito;
        private System.Windows.Forms.Button nove;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button apagar;
        private System.Windows.Forms.Button virgula;
        private System.Windows.Forms.Button soma;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button igual;
    }
}

