namespace Bike.Grafico
{
    partial class ListarCliente
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
            this.dgListarCliente = new System.Windows.Forms.DataGridView();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgListarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgListarCliente
            // 
            this.dgListarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListarCliente.Location = new System.Drawing.Point(12, 0);
            this.dgListarCliente.Name = "dgListarCliente";
            this.dgListarCliente.Size = new System.Drawing.Size(724, 291);
            this.dgListarCliente.TabIndex = 0;
            this.dgListarCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListarCliente_CellContentClick);
            // 
            // btAdicionar
            // 
            this.btAdicionar.Location = new System.Drawing.Point(12, 328);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btAdicionar.TabIndex = 1;
            this.btAdicionar.Text = "adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // btAtualizar
            // 
            this.btAtualizar.Location = new System.Drawing.Point(661, 328);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btAtualizar.TabIndex = 2;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = true;
            // 
            // ListarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 402);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.dgListarCliente);
            this.Name = "ListarCliente";
            this.Text = "ListarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgListarCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgListarCliente;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Button btAtualizar;
    }
}