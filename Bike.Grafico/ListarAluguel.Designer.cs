namespace Bike.Grafico
{
    partial class ListarAluguel
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
            this.components = new System.ComponentModel.Container();
            this.dgAlugueis = new System.Windows.Forms.DataGridView();
            this.codDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataRetiradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDevolucaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bicicletaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aluguelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btAdicionar = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.aluguelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btDevolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlugueis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aluguelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aluguelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAlugueis
            // 
            this.dgAlugueis.AutoGenerateColumns = false;
            this.dgAlugueis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlugueis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codDataGridViewTextBoxColumn,
            this.dataRetiradaDataGridViewTextBoxColumn,
            this.dataDevolucaoDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.bicicletaDataGridViewTextBoxColumn});
            this.dgAlugueis.DataSource = this.aluguelBindingSource1;
            this.dgAlugueis.Location = new System.Drawing.Point(12, 0);
            this.dgAlugueis.Name = "dgAlugueis";
            this.dgAlugueis.Size = new System.Drawing.Size(543, 205);
            this.dgAlugueis.TabIndex = 0;
            // 
            // codDataGridViewTextBoxColumn
            // 
            this.codDataGridViewTextBoxColumn.DataPropertyName = "Cod";
            this.codDataGridViewTextBoxColumn.HeaderText = "Cod";
            this.codDataGridViewTextBoxColumn.Name = "codDataGridViewTextBoxColumn";
            // 
            // dataRetiradaDataGridViewTextBoxColumn
            // 
            this.dataRetiradaDataGridViewTextBoxColumn.DataPropertyName = "DataRetirada";
            this.dataRetiradaDataGridViewTextBoxColumn.HeaderText = "DataRetirada";
            this.dataRetiradaDataGridViewTextBoxColumn.Name = "dataRetiradaDataGridViewTextBoxColumn";
            // 
            // dataDevolucaoDataGridViewTextBoxColumn
            // 
            this.dataDevolucaoDataGridViewTextBoxColumn.DataPropertyName = "DataDevolucao";
            this.dataDevolucaoDataGridViewTextBoxColumn.HeaderText = "DataDevolucao";
            this.dataDevolucaoDataGridViewTextBoxColumn.Name = "dataDevolucaoDataGridViewTextBoxColumn";
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            // 
            // bicicletaDataGridViewTextBoxColumn
            // 
            this.bicicletaDataGridViewTextBoxColumn.DataPropertyName = "Bicicleta";
            this.bicicletaDataGridViewTextBoxColumn.HeaderText = "Bicicleta";
            this.bicicletaDataGridViewTextBoxColumn.Name = "bicicletaDataGridViewTextBoxColumn";
            // 
            // aluguelBindingSource1
            // 
            this.aluguelBindingSource1.DataSource = typeof(Bike.Negocio.Aluguel);
            // 
            // btAdicionar
            // 
            this.btAdicionar.Location = new System.Drawing.Point(12, 221);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btAdicionar.TabIndex = 1;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // btAtualizar
            // 
            this.btAtualizar.Location = new System.Drawing.Point(471, 221);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btAtualizar.TabIndex = 2;
            this.btAtualizar.Text = "atualizar";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // aluguelBindingSource
            // 
            this.aluguelBindingSource.DataSource = typeof(Bike.Negocio.Aluguel);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(Bike.Negocio.Cliente);
            // 
            // clienteBindingSource1
            // 
            this.clienteBindingSource1.DataSource = typeof(Bike.Negocio.Cliente);
            // 
            // btDevolver
            // 
            this.btDevolver.Location = new System.Drawing.Point(114, 220);
            this.btDevolver.Name = "btDevolver";
            this.btDevolver.Size = new System.Drawing.Size(75, 23);
            this.btDevolver.TabIndex = 3;
            this.btDevolver.Text = "Devolver";
            this.btDevolver.UseVisualStyleBackColor = true;
            this.btDevolver.Click += new System.EventHandler(this.btDevolver_Click);
            // 
            // ListarAluguel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 261);
            this.Controls.Add(this.btDevolver);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.dgAlugueis);
            this.Name = "ListarAluguel";
            this.Text = "ListarAluguel";
            this.Load += new System.EventHandler(this.ListarAluguel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAlugueis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aluguelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aluguelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAlugueis;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.BindingSource aluguelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRetiradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDevolucaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bicicletaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource aluguelBindingSource1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.BindingSource clienteBindingSource1;
        private System.Windows.Forms.Button btDevolver;
    }
}