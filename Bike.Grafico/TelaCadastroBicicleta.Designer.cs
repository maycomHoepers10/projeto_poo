namespace Bike.Grafico
{
    partial class TelaCadastroBicicleta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tbData = new System.Windows.Forms.TextBox();
            this.rdNormal = new System.Windows.Forms.RadioButton();
            this.rdEletrica = new System.Windows.Forms.RadioButton();
            this.cbLocais = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data da Compra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Local de Locação";
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(124, 66);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(205, 20);
            this.tbMarca.TabIndex = 6;
            // 
            // tbModelo
            // 
            this.tbModelo.Location = new System.Drawing.Point(124, 109);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(205, 20);
            this.tbModelo.TabIndex = 7;
            // 
            // tbCod
            // 
            this.tbCod.Location = new System.Drawing.Point(126, 30);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(203, 20);
            this.tbCod.TabIndex = 11;
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(114, 284);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 12;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(236, 284);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 13;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(126, 151);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(203, 20);
            this.tbData.TabIndex = 18;
            // 
            // rdNormal
            // 
            this.rdNormal.AccessibleName = "rdTipo";
            this.rdNormal.AutoSize = true;
            this.rdNormal.Checked = true;
            this.rdNormal.Location = new System.Drawing.Point(126, 192);
            this.rdNormal.Name = "rdNormal";
            this.rdNormal.Size = new System.Drawing.Size(58, 17);
            this.rdNormal.TabIndex = 20;
            this.rdNormal.TabStop = true;
            this.rdNormal.Text = "Normal";
            this.rdNormal.UseVisualStyleBackColor = true;
            // 
            // rdEletrica
            // 
            this.rdEletrica.AccessibleName = "rdTipo";
            this.rdEletrica.AutoSize = true;
            this.rdEletrica.Location = new System.Drawing.Point(218, 192);
            this.rdEletrica.Name = "rdEletrica";
            this.rdEletrica.Size = new System.Drawing.Size(60, 17);
            this.rdEletrica.TabIndex = 21;
            this.rdEletrica.Text = "Elétrica";
            this.rdEletrica.UseVisualStyleBackColor = true;
            // 
            // cbLocais
            // 
            this.cbLocais.FormattingEnabled = true;
            this.cbLocais.Location = new System.Drawing.Point(124, 228);
            this.cbLocais.Name = "cbLocais";
            this.cbLocais.Size = new System.Drawing.Size(205, 21);
            this.cbLocais.TabIndex = 22;
            this.cbLocais.SelectedIndexChanged += new System.EventHandler(this.TelaCadastroBicicleta_Load);
            // 
            // TelaCadastroBicicleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 319);
            this.Controls.Add(this.cbLocais);
            this.Controls.Add(this.rdEletrica);
            this.Controls.Add(this.rdNormal);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.tbCod);
            this.Controls.Add(this.tbModelo);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaCadastroBicicleta";
            this.Text = "TelaCadastroBicicleta";
            this.Load += new System.EventHandler(this.TelaCadastroBicicleta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btCancelar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.RadioButton rdNormal;
        private System.Windows.Forms.RadioButton rdEletrica;
        private System.Windows.Forms.ComboBox cbLocais;
    }
}