namespace Bike.Grafico
{
    partial class ListarCidade
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
            this.dgListarCidade = new System.Windows.Forms.DataGridView();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgListarCidade)).BeginInit();
            this.SuspendLayout();
            // 
            // dgListarCidade
            // 
            this.dgListarCidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListarCidade.Location = new System.Drawing.Point(29, 22);
            this.dgListarCidade.Name = "dgListarCidade";
            this.dgListarCidade.Size = new System.Drawing.Size(650, 264);
            this.dgListarCidade.TabIndex = 0;
            // 
            // btAdicionar
            // 
            this.btAdicionar.Location = new System.Drawing.Point(29, 306);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btAdicionar.TabIndex = 1;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // btAtualizar
            // 
            this.btAtualizar.Location = new System.Drawing.Point(604, 306);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btAtualizar.TabIndex = 2;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // ListarCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 395);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.dgListarCidade);
            this.Name = "ListarCidade";
            this.Text = "ListarCidade";
            this.Load += new System.EventHandler(this.ListarCidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListarCidade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgListarCidade;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Button btAtualizar;
    }
}