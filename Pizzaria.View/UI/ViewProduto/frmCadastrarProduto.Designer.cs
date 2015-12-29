﻿namespace Pizzaria.View.UI.ViewProduto
{
    partial class frmCadastrarProduto
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
            this.ckbGerenciar = new System.Windows.Forms.CheckBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.gpbEstoque = new System.Windows.Forms.GroupBox();
            this.txtQtdMin = new System.Windows.Forms.TextBox();
            this.lblQuantidadeMinima = new System.Windows.Forms.Label();
            this.txtQtdMax = new System.Windows.Forms.TextBox();
            this.lblQuantidadeMaxima = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gpbPrecoVenda = new System.Windows.Forms.GroupBox();
            this.lblPrecoVenda = new System.Windows.Forms.Label();
            this.txtPeco = new System.Windows.Forms.TextBox();
            this.txtPrecoCompra = new System.Windows.Forms.TextBox();
            this.lblCusto = new System.Windows.Forms.Label();
            this.gpbBorda = new System.Windows.Forms.GroupBox();
            this.btnAddBorda = new System.Windows.Forms.Button();
            this.cbbBorda = new System.Windows.Forms.ComboBox();
            this.gpbSabor = new System.Windows.Forms.GroupBox();
            this.btnAddSabor = new System.Windows.Forms.Button();
            this.cbbSabor = new System.Windows.Forms.ComboBox();
            this.gpbCategoria = new System.Windows.Forms.GroupBox();
            this.btnAddCategoria = new System.Windows.Forms.Button();
            this.cbbCategoria = new System.Windows.Forms.ComboBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.gpbTipoCadastro = new System.Windows.Forms.GroupBox();
            this.cbbTipoProduto = new System.Windows.Forms.ComboBox();
            this.gpbEstoque.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpbPrecoVenda.SuspendLayout();
            this.gpbBorda.SuspendLayout();
            this.gpbSabor.SuspendLayout();
            this.gpbCategoria.SuspendLayout();
            this.gpbTipoCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // ckbGerenciar
            // 
            this.ckbGerenciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbGerenciar.Location = new System.Drawing.Point(380, 0);
            this.ckbGerenciar.Name = "ckbGerenciar";
            this.ckbGerenciar.Size = new System.Drawing.Size(343, 70);
            this.ckbGerenciar.TabIndex = 3;
            this.ckbGerenciar.Text = "Gerenciar Estoque";
            this.ckbGerenciar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckbGerenciar.UseVisualStyleBackColor = true;
            this.ckbGerenciar.CheckedChanged += new System.EventHandler(this.ckbGerenciar_CheckedChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(12, 472);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(711, 43);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Salvar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // gpbEstoque
            // 
            this.gpbEstoque.Controls.Add(this.txtQtdMin);
            this.gpbEstoque.Controls.Add(this.lblQuantidadeMinima);
            this.gpbEstoque.Controls.Add(this.txtQtdMax);
            this.gpbEstoque.Controls.Add(this.lblQuantidadeMaxima);
            this.gpbEstoque.Controls.Add(this.txtQtd);
            this.gpbEstoque.Controls.Add(this.lblQuantidade);
            this.gpbEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbEstoque.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gpbEstoque.Location = new System.Drawing.Point(12, 401);
            this.gpbEstoque.Name = "gpbEstoque";
            this.gpbEstoque.Size = new System.Drawing.Size(711, 62);
            this.gpbEstoque.TabIndex = 6;
            this.gpbEstoque.TabStop = false;
            this.gpbEstoque.Text = "Estoque";
            // 
            // txtQtdMin
            // 
            this.txtQtdMin.BackColor = System.Drawing.Color.Yellow;
            this.txtQtdMin.Location = new System.Drawing.Point(373, 26);
            this.txtQtdMin.Name = "txtQtdMin";
            this.txtQtdMin.Size = new System.Drawing.Size(62, 26);
            this.txtQtdMin.TabIndex = 3;
            this.txtQtdMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblQuantidadeMinima
            // 
            this.lblQuantidadeMinima.AutoSize = true;
            this.lblQuantidadeMinima.Location = new System.Drawing.Point(221, 26);
            this.lblQuantidadeMinima.Name = "lblQuantidadeMinima";
            this.lblQuantidadeMinima.Size = new System.Drawing.Size(146, 20);
            this.lblQuantidadeMinima.TabIndex = 10;
            this.lblQuantidadeMinima.Text = "Quantidade mínima";
            // 
            // txtQtdMax
            // 
            this.txtQtdMax.BackColor = System.Drawing.Color.Yellow;
            this.txtQtdMax.Location = new System.Drawing.Point(611, 26);
            this.txtQtdMax.Name = "txtQtdMax";
            this.txtQtdMax.Size = new System.Drawing.Size(62, 26);
            this.txtQtdMax.TabIndex = 3;
            this.txtQtdMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblQuantidadeMaxima
            // 
            this.lblQuantidadeMaxima.AutoSize = true;
            this.lblQuantidadeMaxima.Location = new System.Drawing.Point(455, 26);
            this.lblQuantidadeMaxima.Name = "lblQuantidadeMaxima";
            this.lblQuantidadeMaxima.Size = new System.Drawing.Size(150, 20);
            this.lblQuantidadeMaxima.TabIndex = 11;
            this.lblQuantidadeMaxima.Text = "Quantidade máxima";
            // 
            // txtQtd
            // 
            this.txtQtd.BackColor = System.Drawing.Color.Yellow;
            this.txtQtd.Location = new System.Drawing.Point(133, 26);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(62, 26);
            this.txtQtd.TabIndex = 3;
            this.txtQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(35, 26);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(92, 20);
            this.lblQuantidade.TabIndex = 5;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gpbPrecoVenda);
            this.groupBox1.Controls.Add(this.gpbBorda);
            this.groupBox1.Controls.Add(this.gpbSabor);
            this.groupBox1.Controls.Add(this.gpbCategoria);
            this.groupBox1.Controls.Add(this.lblDescricao);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 337);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produto";
            // 
            // gpbPrecoVenda
            // 
            this.gpbPrecoVenda.Controls.Add(this.lblPrecoVenda);
            this.gpbPrecoVenda.Controls.Add(this.txtPeco);
            this.gpbPrecoVenda.Controls.Add(this.txtPrecoCompra);
            this.gpbPrecoVenda.Controls.Add(this.lblCusto);
            this.gpbPrecoVenda.Location = new System.Drawing.Point(18, 96);
            this.gpbPrecoVenda.Name = "gpbPrecoVenda";
            this.gpbPrecoVenda.Size = new System.Drawing.Size(341, 104);
            this.gpbPrecoVenda.TabIndex = 3;
            this.gpbPrecoVenda.TabStop = false;
            this.gpbPrecoVenda.Text = "Preços";
            // 
            // lblPrecoVenda
            // 
            this.lblPrecoVenda.Location = new System.Drawing.Point(5, 65);
            this.lblPrecoVenda.Name = "lblPrecoVenda";
            this.lblPrecoVenda.Size = new System.Drawing.Size(103, 31);
            this.lblPrecoVenda.TabIndex = 27;
            this.lblPrecoVenda.Text = "Venda";
            this.lblPrecoVenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPeco
            // 
            this.txtPeco.BackColor = System.Drawing.Color.Yellow;
            this.txtPeco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeco.Location = new System.Drawing.Point(108, 67);
            this.txtPeco.MaxLength = 5;
            this.txtPeco.Name = "txtPeco";
            this.txtPeco.Size = new System.Drawing.Size(219, 29);
            this.txtPeco.TabIndex = 4;
            this.txtPeco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrecoCompra
            // 
            this.txtPrecoCompra.BackColor = System.Drawing.Color.Yellow;
            this.txtPrecoCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoCompra.Location = new System.Drawing.Point(108, 24);
            this.txtPrecoCompra.MaxLength = 5;
            this.txtPrecoCompra.Name = "txtPrecoCompra";
            this.txtPrecoCompra.Size = new System.Drawing.Size(219, 29);
            this.txtPrecoCompra.TabIndex = 3;
            this.txtPrecoCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCusto
            // 
            this.lblCusto.Location = new System.Drawing.Point(6, 24);
            this.lblCusto.Name = "lblCusto";
            this.lblCusto.Size = new System.Drawing.Size(102, 31);
            this.lblCusto.TabIndex = 25;
            this.lblCusto.Text = "Compra";
            this.lblCusto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpbBorda
            // 
            this.gpbBorda.Controls.Add(this.btnAddBorda);
            this.gpbBorda.Controls.Add(this.cbbBorda);
            this.gpbBorda.Location = new System.Drawing.Point(365, 160);
            this.gpbBorda.Name = "gpbBorda";
            this.gpbBorda.Size = new System.Drawing.Size(330, 62);
            this.gpbBorda.TabIndex = 29;
            this.gpbBorda.TabStop = false;
            this.gpbBorda.Text = "Borda";
            // 
            // btnAddBorda
            // 
            this.btnAddBorda.Location = new System.Drawing.Point(282, 22);
            this.btnAddBorda.Name = "btnAddBorda";
            this.btnAddBorda.Size = new System.Drawing.Size(41, 30);
            this.btnAddBorda.TabIndex = 23;
            this.btnAddBorda.Text = "+";
            this.btnAddBorda.UseVisualStyleBackColor = true;
            this.btnAddBorda.ClientSizeChanged += new System.EventHandler(this.btnAddSabor_Click);
            this.btnAddBorda.Click += new System.EventHandler(this.btnAddBorda_Click);
            // 
            // cbbBorda
            // 
            this.cbbBorda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBorda.FormattingEnabled = true;
            this.cbbBorda.Location = new System.Drawing.Point(6, 24);
            this.cbbBorda.Name = "cbbBorda";
            this.cbbBorda.Size = new System.Drawing.Size(271, 28);
            this.cbbBorda.TabIndex = 22;
            // 
            // gpbSabor
            // 
            this.gpbSabor.Controls.Add(this.btnAddSabor);
            this.gpbSabor.Controls.Add(this.cbbSabor);
            this.gpbSabor.Location = new System.Drawing.Point(365, 90);
            this.gpbSabor.Name = "gpbSabor";
            this.gpbSabor.Size = new System.Drawing.Size(330, 64);
            this.gpbSabor.TabIndex = 29;
            this.gpbSabor.TabStop = false;
            this.gpbSabor.Text = "Sabor";
            // 
            // btnAddSabor
            // 
            this.btnAddSabor.Location = new System.Drawing.Point(283, 23);
            this.btnAddSabor.Name = "btnAddSabor";
            this.btnAddSabor.Size = new System.Drawing.Size(41, 30);
            this.btnAddSabor.TabIndex = 23;
            this.btnAddSabor.Text = "+";
            this.btnAddSabor.UseVisualStyleBackColor = true;
            this.btnAddSabor.Click += new System.EventHandler(this.btnAddSabor_Click);
            // 
            // cbbSabor
            // 
            this.cbbSabor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSabor.FormattingEnabled = true;
            this.cbbSabor.Location = new System.Drawing.Point(6, 24);
            this.cbbSabor.Name = "cbbSabor";
            this.cbbSabor.Size = new System.Drawing.Size(271, 28);
            this.cbbSabor.TabIndex = 22;
            // 
            // gpbCategoria
            // 
            this.gpbCategoria.Controls.Add(this.btnAddCategoria);
            this.gpbCategoria.Controls.Add(this.cbbCategoria);
            this.gpbCategoria.Location = new System.Drawing.Point(365, 18);
            this.gpbCategoria.Name = "gpbCategoria";
            this.gpbCategoria.Size = new System.Drawing.Size(330, 66);
            this.gpbCategoria.TabIndex = 28;
            this.gpbCategoria.TabStop = false;
            this.gpbCategoria.Text = "Categoria";
            // 
            // btnAddCategoria
            // 
            this.btnAddCategoria.Location = new System.Drawing.Point(282, 24);
            this.btnAddCategoria.Name = "btnAddCategoria";
            this.btnAddCategoria.Size = new System.Drawing.Size(41, 30);
            this.btnAddCategoria.TabIndex = 24;
            this.btnAddCategoria.Text = "+";
            this.btnAddCategoria.UseVisualStyleBackColor = true;
            this.btnAddCategoria.Click += new System.EventHandler(this.btnAddCategoria_Click);
            // 
            // cbbCategoria
            // 
            this.cbbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategoria.FormattingEnabled = true;
            this.cbbCategoria.Location = new System.Drawing.Point(6, 25);
            this.cbbCategoria.Name = "cbbCategoria";
            this.cbbCategoria.Size = new System.Drawing.Size(270, 28);
            this.cbbCategoria.TabIndex = 23;
            // 
            // lblDescricao
            // 
            this.lblDescricao.Location = new System.Drawing.Point(14, 200);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(88, 28);
            this.lblDescricao.TabIndex = 23;
            this.lblDescricao.Text = "Descrição";
            this.lblDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.Yellow;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(18, 231);
            this.txtDescricao.MaxLength = 100;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(677, 100);
            this.txtDescricao.TabIndex = 5;
            this.txtDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(11, 61);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 29);
            this.lblCodigo.TabIndex = 26;
            this.lblCodigo.Text = "Código";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.Yellow;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(74, 64);
            this.txtCodigo.MaxLength = 13;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(285, 29);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNome
            // 
            this.lblNome.Location = new System.Drawing.Point(13, 25);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 26);
            this.lblNome.TabIndex = 27;
            this.lblNome.Text = "Nome";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.Yellow;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(66, 25);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(293, 29);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gpbTipoCadastro
            // 
            this.gpbTipoCadastro.Controls.Add(this.cbbTipoProduto);
            this.gpbTipoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbTipoCadastro.Location = new System.Drawing.Point(12, 0);
            this.gpbTipoCadastro.Name = "gpbTipoCadastro";
            this.gpbTipoCadastro.Size = new System.Drawing.Size(359, 62);
            this.gpbTipoCadastro.TabIndex = 8;
            this.gpbTipoCadastro.TabStop = false;
            this.gpbTipoCadastro.Text = "Tipo do Produto";
            // 
            // cbbTipoProduto
            // 
            this.cbbTipoProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTipoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTipoProduto.FormattingEnabled = true;
            this.cbbTipoProduto.Location = new System.Drawing.Point(9, 22);
            this.cbbTipoProduto.Name = "cbbTipoProduto";
            this.cbbTipoProduto.Size = new System.Drawing.Size(336, 28);
            this.cbbTipoProduto.TabIndex = 10;
            this.cbbTipoProduto.SelectedIndexChanged += new System.EventHandler(this.cbbTipoProduto_SelectedIndexChanged);
            // 
            // frmCadastrarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(734, 523);
            this.Controls.Add(this.gpbTipoCadastro);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ckbGerenciar);
            this.Controls.Add(this.gpbEstoque);
            this.Controls.Add(this.btnCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmCadastrarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar de Produto";
            this.Load += new System.EventHandler(this.frmCadastrarProduto_Load);
            this.gpbEstoque.ResumeLayout(false);
            this.gpbEstoque.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpbPrecoVenda.ResumeLayout(false);
            this.gpbPrecoVenda.PerformLayout();
            this.gpbBorda.ResumeLayout(false);
            this.gpbSabor.ResumeLayout(false);
            this.gpbCategoria.ResumeLayout(false);
            this.gpbTipoCadastro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox ckbGerenciar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox gpbEstoque;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtQtdMin;
        private System.Windows.Forms.Label lblQuantidadeMinima;
        private System.Windows.Forms.TextBox txtQtdMax;
        private System.Windows.Forms.Label lblQuantidadeMaxima;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblCusto;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtPrecoCompra;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox gpbSabor;
        private System.Windows.Forms.Button btnAddSabor;
        private System.Windows.Forms.ComboBox cbbSabor;
        private System.Windows.Forms.GroupBox gpbCategoria;
        private System.Windows.Forms.Button btnAddCategoria;
        private System.Windows.Forms.ComboBox cbbCategoria;
        private System.Windows.Forms.GroupBox gpbPrecoVenda;
        private System.Windows.Forms.Label lblPrecoVenda;
        private System.Windows.Forms.TextBox txtPeco;
        private System.Windows.Forms.GroupBox gpbBorda;
        private System.Windows.Forms.Button btnAddBorda;
        private System.Windows.Forms.ComboBox cbbBorda;
        private System.Windows.Forms.GroupBox gpbTipoCadastro;
        private System.Windows.Forms.ComboBox cbbTipoProduto;
    }
}