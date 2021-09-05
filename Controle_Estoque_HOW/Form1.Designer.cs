
namespace Controle_Estoque_HOW
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
            this.lblproduto = new System.Windows.Forms.Label();
            this.txtproduto = new System.Windows.Forms.TextBox();
            this.txtcor = new System.Windows.Forms.TextBox();
            this.lblcor = new System.Windows.Forms.Label();
            this.txtsexo = new System.Windows.Forms.Label();
            this.txttamanho = new System.Windows.Forms.Label();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colunaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaproduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunacor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunasexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunatamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnapagar = new System.Windows.Forms.Button();
            this.btnrelatorio = new System.Windows.Forms.Button();
            this.rdbtnalfabetico = new System.Windows.Forms.RadioButton();
            this.rdbtnnumerico = new System.Windows.Forms.RadioButton();
            this.txttamanho1 = new System.Windows.Forms.TextBox();
            this.txtsexo1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblproduto
            // 
            this.lblproduto.AutoSize = true;
            this.lblproduto.Location = new System.Drawing.Point(24, 49);
            this.lblproduto.Name = "lblproduto";
            this.lblproduto.Size = new System.Drawing.Size(44, 13);
            this.lblproduto.TabIndex = 0;
            this.lblproduto.Text = "Produto";
            // 
            // txtproduto
            // 
            this.txtproduto.Location = new System.Drawing.Point(75, 45);
            this.txtproduto.Name = "txtproduto";
            this.txtproduto.Size = new System.Drawing.Size(168, 20);
            this.txtproduto.TabIndex = 1;
            // 
            // txtcor
            // 
            this.txtcor.Location = new System.Drawing.Point(57, 75);
            this.txtcor.Name = "txtcor";
            this.txtcor.Size = new System.Drawing.Size(76, 20);
            this.txtcor.TabIndex = 2;
            // 
            // lblcor
            // 
            this.lblcor.AutoSize = true;
            this.lblcor.Location = new System.Drawing.Point(24, 79);
            this.lblcor.Name = "lblcor";
            this.lblcor.Size = new System.Drawing.Size(23, 13);
            this.lblcor.TabIndex = 3;
            this.lblcor.Text = "Cor";
            // 
            // txtsexo
            // 
            this.txtsexo.AutoSize = true;
            this.txtsexo.Location = new System.Drawing.Point(143, 79);
            this.txtsexo.Name = "txtsexo";
            this.txtsexo.Size = new System.Drawing.Size(31, 13);
            this.txtsexo.TabIndex = 4;
            this.txtsexo.Text = "Sexo";
            // 
            // txttamanho
            // 
            this.txttamanho.AutoSize = true;
            this.txttamanho.Location = new System.Drawing.Point(24, 110);
            this.txttamanho.Name = "txttamanho";
            this.txttamanho.Size = new System.Drawing.Size(52, 13);
            this.txttamanho.TabIndex = 7;
            this.txttamanho.Text = "Tamanho";
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(27, 138);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(92, 23);
            this.btnsalvar.TabIndex = 8;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaid,
            this.colunaproduto,
            this.colunacor,
            this.colunasexo,
            this.colunatamanho});
            this.dataGridView1.Location = new System.Drawing.Point(27, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(613, 261);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colunaid
            // 
            this.colunaid.HeaderText = "ID";
            this.colunaid.Name = "colunaid";
            this.colunaid.ReadOnly = true;
            // 
            // colunaproduto
            // 
            this.colunaproduto.HeaderText = "Produto";
            this.colunaproduto.Name = "colunaproduto";
            this.colunaproduto.ReadOnly = true;
            // 
            // colunacor
            // 
            this.colunacor.HeaderText = "Cor";
            this.colunacor.Name = "colunacor";
            this.colunacor.ReadOnly = true;
            // 
            // colunasexo
            // 
            this.colunasexo.HeaderText = "Sexo";
            this.colunasexo.Name = "colunasexo";
            this.colunasexo.ReadOnly = true;
            // 
            // colunatamanho
            // 
            this.colunatamanho.HeaderText = "Tamanho";
            this.colunatamanho.Name = "colunatamanho";
            this.colunatamanho.ReadOnly = true;
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(223, 138);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(92, 23);
            this.btneditar.TabIndex = 10;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            // 
            // btnapagar
            // 
            this.btnapagar.Location = new System.Drawing.Point(125, 138);
            this.btnapagar.Name = "btnapagar";
            this.btnapagar.Size = new System.Drawing.Size(92, 23);
            this.btnapagar.TabIndex = 10;
            this.btnapagar.Text = "Apagar";
            this.btnapagar.UseVisualStyleBackColor = true;
            this.btnapagar.Click += new System.EventHandler(this.btnapagar_Click);
            // 
            // btnrelatorio
            // 
            this.btnrelatorio.Location = new System.Drawing.Point(321, 138);
            this.btnrelatorio.Name = "btnrelatorio";
            this.btnrelatorio.Size = new System.Drawing.Size(92, 23);
            this.btnrelatorio.TabIndex = 10;
            this.btnrelatorio.Text = "Gerar Relatório";
            this.btnrelatorio.UseVisualStyleBackColor = true;
            // 
            // rdbtnalfabetico
            // 
            this.rdbtnalfabetico.AutoSize = true;
            this.rdbtnalfabetico.Location = new System.Drawing.Point(89, 108);
            this.rdbtnalfabetico.Name = "rdbtnalfabetico";
            this.rdbtnalfabetico.Size = new System.Drawing.Size(72, 17);
            this.rdbtnalfabetico.TabIndex = 11;
            this.rdbtnalfabetico.TabStop = true;
            this.rdbtnalfabetico.Text = "Alfabético";
            this.rdbtnalfabetico.UseVisualStyleBackColor = true;
            this.rdbtnalfabetico.CheckedChanged += new System.EventHandler(this.rdbtnalfabetico_CheckedChanged);
            // 
            // rdbtnnumerico
            // 
            this.rdbtnnumerico.AutoSize = true;
            this.rdbtnnumerico.Location = new System.Drawing.Point(174, 108);
            this.rdbtnnumerico.Name = "rdbtnnumerico";
            this.rdbtnnumerico.Size = new System.Drawing.Size(70, 17);
            this.rdbtnnumerico.TabIndex = 11;
            this.rdbtnnumerico.TabStop = true;
            this.rdbtnnumerico.Text = "Numérico";
            this.rdbtnnumerico.UseVisualStyleBackColor = true;
            this.rdbtnnumerico.CheckedChanged += new System.EventHandler(this.rdbtnalfabetico_CheckedChanged);
            // 
            // txttamanho1
            // 
            this.txttamanho1.Location = new System.Drawing.Point(257, 107);
            this.txttamanho1.Name = "txttamanho1";
            this.txttamanho1.Size = new System.Drawing.Size(124, 20);
            this.txttamanho1.TabIndex = 12;
            // 
            // txtsexo1
            // 
            this.txtsexo1.Location = new System.Drawing.Point(180, 75);
            this.txtsexo1.Name = "txtsexo1";
            this.txtsexo1.Size = new System.Drawing.Size(76, 20);
            this.txtsexo1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 450);
            this.Controls.Add(this.txttamanho1);
            this.Controls.Add(this.rdbtnnumerico);
            this.Controls.Add(this.rdbtnalfabetico);
            this.Controls.Add(this.btnrelatorio);
            this.Controls.Add(this.btnapagar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.txttamanho);
            this.Controls.Add(this.txtsexo);
            this.Controls.Add(this.lblcor);
            this.Controls.Add(this.txtsexo1);
            this.Controls.Add(this.txtcor);
            this.Controls.Add(this.txtproduto);
            this.Controls.Add(this.lblproduto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblproduto;
        private System.Windows.Forms.TextBox txtproduto;
        private System.Windows.Forms.TextBox txtcor;
        private System.Windows.Forms.Label lblcor;
        private System.Windows.Forms.Label txtsexo;
        private System.Windows.Forms.Label txttamanho;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnapagar;
        private System.Windows.Forms.Button btnrelatorio;
        private System.Windows.Forms.RadioButton rdbtnalfabetico;
        private System.Windows.Forms.RadioButton rdbtnnumerico;
        private System.Windows.Forms.TextBox txttamanho1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaproduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunacor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunasexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunatamanho;
        private System.Windows.Forms.TextBox txtsexo1;
    }
}

