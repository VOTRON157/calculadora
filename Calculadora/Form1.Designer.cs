
namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.um = new System.Windows.Forms.Button();
            this.dois = new System.Windows.Forms.Button();
            this.tres = new System.Windows.Forms.Button();
            this.seis = new System.Windows.Forms.Button();
            this.cinco = new System.Windows.Forms.Button();
            this.quatro = new System.Windows.Forms.Button();
            this.nove = new System.Windows.Forms.Button();
            this.oito = new System.Windows.Forms.Button();
            this.sete = new System.Windows.Forms.Button();
            this.subtrair = new System.Windows.Forms.Button();
            this.adicao = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.Label();
            this.divisao = new System.Windows.Forms.Button();
            this.multiplicar = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.apagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // um
            // 
            this.um.Location = new System.Drawing.Point(2, 199);
            this.um.Name = "um";
            this.um.Size = new System.Drawing.Size(63, 53);
            this.um.TabIndex = 0;
            this.um.Text = "1";
            this.um.UseVisualStyleBackColor = true;
            this.um.Click += new System.EventHandler(this.um_Click);
            // 
            // dois
            // 
            this.dois.Location = new System.Drawing.Point(62, 199);
            this.dois.Name = "dois";
            this.dois.Size = new System.Drawing.Size(63, 53);
            this.dois.TabIndex = 1;
            this.dois.Text = "2";
            this.dois.UseVisualStyleBackColor = true;
            this.dois.Click += new System.EventHandler(this.dois_Click);
            // 
            // tres
            // 
            this.tres.Location = new System.Drawing.Point(120, 199);
            this.tres.Name = "tres";
            this.tres.Size = new System.Drawing.Size(63, 53);
            this.tres.TabIndex = 2;
            this.tres.Text = "3";
            this.tres.UseVisualStyleBackColor = true;
            this.tres.Click += new System.EventHandler(this.tres_Click);
            // 
            // seis
            // 
            this.seis.Location = new System.Drawing.Point(120, 149);
            this.seis.Name = "seis";
            this.seis.Size = new System.Drawing.Size(63, 53);
            this.seis.TabIndex = 5;
            this.seis.Text = "6";
            this.seis.UseVisualStyleBackColor = true;
            this.seis.Click += new System.EventHandler(this.seis_Click);
            // 
            // cinco
            // 
            this.cinco.Location = new System.Drawing.Point(62, 149);
            this.cinco.Name = "cinco";
            this.cinco.Size = new System.Drawing.Size(63, 53);
            this.cinco.TabIndex = 4;
            this.cinco.Text = "5";
            this.cinco.UseVisualStyleBackColor = true;
            this.cinco.Click += new System.EventHandler(this.cinco_Click);
            // 
            // quatro
            // 
            this.quatro.Location = new System.Drawing.Point(2, 149);
            this.quatro.Name = "quatro";
            this.quatro.Size = new System.Drawing.Size(63, 53);
            this.quatro.TabIndex = 3;
            this.quatro.Text = "4";
            this.quatro.UseVisualStyleBackColor = true;
            this.quatro.Click += new System.EventHandler(this.quatro_Click);
            // 
            // nove
            // 
            this.nove.Location = new System.Drawing.Point(120, 99);
            this.nove.Name = "nove";
            this.nove.Size = new System.Drawing.Size(63, 53);
            this.nove.TabIndex = 8;
            this.nove.Text = "9";
            this.nove.UseVisualStyleBackColor = true;
            this.nove.Click += new System.EventHandler(this.nove_Click);
            // 
            // oito
            // 
            this.oito.Location = new System.Drawing.Point(62, 99);
            this.oito.Name = "oito";
            this.oito.Size = new System.Drawing.Size(63, 53);
            this.oito.TabIndex = 7;
            this.oito.Text = "8";
            this.oito.UseVisualStyleBackColor = true;
            this.oito.Click += new System.EventHandler(this.oito_Click);
            // 
            // sete
            // 
            this.sete.Location = new System.Drawing.Point(2, 99);
            this.sete.Name = "sete";
            this.sete.Size = new System.Drawing.Size(63, 53);
            this.sete.TabIndex = 6;
            this.sete.Text = "7";
            this.sete.UseVisualStyleBackColor = true;
            this.sete.Click += new System.EventHandler(this.sete_Click);
            // 
            // subtrair
            // 
            this.subtrair.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtrair.Location = new System.Drawing.Point(180, 199);
            this.subtrair.Name = "subtrair";
            this.subtrair.Size = new System.Drawing.Size(63, 53);
            this.subtrair.TabIndex = 9;
            this.subtrair.Text = "-";
            this.subtrair.UseVisualStyleBackColor = true;
            this.subtrair.Click += new System.EventHandler(this.subtrair_Click);
            // 
            // adicao
            // 
            this.adicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adicao.Location = new System.Drawing.Point(180, 149);
            this.adicao.Name = "adicao";
            this.adicao.Size = new System.Drawing.Size(63, 53);
            this.adicao.TabIndex = 10;
            this.adicao.Text = "+";
            this.adicao.UseVisualStyleBackColor = true;
            this.adicao.Click += new System.EventHandler(this.adicao_Click);
            // 
            // igual
            // 
            this.igual.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.igual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igual.ForeColor = System.Drawing.SystemColors.ControlText;
            this.igual.Location = new System.Drawing.Point(180, 249);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(63, 53);
            this.igual.TabIndex = 11;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = false;
            this.igual.Click += new System.EventHandler(this.igual_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(61, 249);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(63, 53);
            this.zero.TabIndex = 12;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.Location = new System.Drawing.Point(12, 9);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(39, 42);
            this.resultado.TabIndex = 13;
            this.resultado.Text = "0";
            // 
            // divisao
            // 
            this.divisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisao.Location = new System.Drawing.Point(180, 49);
            this.divisao.Name = "divisao";
            this.divisao.Size = new System.Drawing.Size(63, 53);
            this.divisao.TabIndex = 14;
            this.divisao.Text = "÷";
            this.divisao.UseVisualStyleBackColor = true;
            this.divisao.Click += new System.EventHandler(this.divisao_Click);
            // 
            // multiplicar
            // 
            this.multiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicar.Location = new System.Drawing.Point(180, 99);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(63, 53);
            this.multiplicar.TabIndex = 15;
            this.multiplicar.Text = "x";
            this.multiplicar.UseVisualStyleBackColor = true;
            this.multiplicar.Click += new System.EventHandler(this.multiplicar_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(2, 249);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(63, 53);
            this.clear.TabIndex = 16;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // apagar
            // 
            this.apagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apagar.Location = new System.Drawing.Point(120, 249);
            this.apagar.Name = "apagar";
            this.apagar.Size = new System.Drawing.Size(63, 53);
            this.apagar.TabIndex = 17;
            this.apagar.Text = "⌫";
            this.apagar.UseVisualStyleBackColor = true;
            this.apagar.Click += new System.EventHandler(this.apagar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 301);
            this.Controls.Add(this.apagar);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.multiplicar);
            this.Controls.Add(this.divisao);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.adicao);
            this.Controls.Add(this.subtrair);
            this.Controls.Add(this.nove);
            this.Controls.Add(this.oito);
            this.Controls.Add(this.sete);
            this.Controls.Add(this.seis);
            this.Controls.Add(this.cinco);
            this.Controls.Add(this.quatro);
            this.Controls.Add(this.tres);
            this.Controls.Add(this.dois);
            this.Controls.Add(this.um);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button um;
        private System.Windows.Forms.Button dois;
        private System.Windows.Forms.Button tres;
        private System.Windows.Forms.Button seis;
        private System.Windows.Forms.Button cinco;
        private System.Windows.Forms.Button quatro;
        private System.Windows.Forms.Button nove;
        private System.Windows.Forms.Button oito;
        private System.Windows.Forms.Button sete;
        private System.Windows.Forms.Button subtrair;
        private System.Windows.Forms.Button adicao;
        private System.Windows.Forms.Button igual;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Button divisao;
        private System.Windows.Forms.Button multiplicar;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button apagar;
    }
}

