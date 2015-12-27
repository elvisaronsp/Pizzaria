﻿using Mike.Utilities.Desktop;
using Pizzaria.Controller.Repository;
using Pizzaria.Model.Entity;
using Pizzaria.View.UI.ViewCategoria;
using Pizzaria.View.UI.ViewSabor;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using System.Linq;
using Pizzaria.View.UI.ViewComplemento;
using Pizzaria.View.UI.ViewBorda;

namespace Pizzaria.View.UI.ViewProduto
{
    public partial class frmCadastrarProduto : Form
    {
        public frmCadastrarProduto()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja adicionar um complemento?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                OpenMdiForm.OpenForWithShowDialog(new frmCadastrarComplemento());
            }
            var com = new ComplementoRepositorio().GetUltimoResgistro();
           
            var prod = new Produto
            {
                Nome = txtNome.Text,
                Codigo = txtCodigo.Text,
                CategoriaID = new CategoriaRepositorio().GetIDCategoriaPorNome(cbbCategoria.Text),
                Complemento = result == DialogResult.Yes ?
                 new List<Complemento>
                    {
                         new Complemento
                         {
                              ComplementoID = com.ComplementoID,
                              Descricao =com.Descricao,
                              Preco =  com.Preco,
                              SaborID = com.SaborID
                         }
                    } : null,
                Descricao = txtDescricao.Text,
                Estoque = new Estoque
                {
                    Gerenciar = ckbGerenciar.Checked,
                    Quantidade = Convert.ToInt32(txtQtd.Text == "" ? "0" : txtQtd.Text),
                    QuantidadeMaxima = Convert.ToInt32(txtQtdMax.Text == "" ? "0" : txtQtdMax.Text),
                    QuantidadeMinima = Convert.ToInt32(txtQtdMin.Text == "" ? "0" : txtQtdMin.Text)
                },
                PrecoCompra = Convert.ToDouble(txtPrecoCompra.Text),
                PrecoVenda = Convert.ToDouble(txtPeco.Text),
                SaborID = new SaborRepositorio().GetIDCategoriaPorNome(cbbSabor.Text),
                 BordaID = new BordaRepositorio().getIDPorNome(cbbBorda.Text)



            };

            IList<ValidationResult> erros = new List<ValidationResult>();

            if (!Validator.TryValidateObject(prod, new ValidationContext(prod), erros, true))
            {

                var errosMessage = "";
                foreach (var c in erros)
                {

                    errosMessage += c.ErrorMessage + "\n";
                }
                MessageBox.Show(errosMessage);
            }
            else
            {
                bool resulte = new ProdutoRepositorio().Salvar(prod);
                if (resulte)
                {
                    MessageBox.Show("Produto cadastrado com sucesso!");
                    Array.ForEach(GetAllTextBox(),c=>c.Text = string.Empty);            
                }

            }


        }
        public TextBox[] GetAllTextBox()
               => new TextBox[] { txtNome, txtCodigo, txtPrecoCompra,txtPeco, txtDescricao,txtQtd,txtQtdMin,txtQtdMax };
        private void frmCadastrarProduto_Load(object sender, EventArgs e)
        {
            var cat = new CategoriaRepositorio();
            cbbCategoria.DisplayMember = "Nome";
            cbbCategoria.DataSource = cat.Listar();
            var sab = new SaborRepositorio();
            cbbSabor.DisplayMember = "Nome";
            cbbSabor.DataSource = sab.Listar();
            var bor = new BordaRepositorio();
            cbbBorda.DisplayMember = "Nome";
            cbbBorda.DataSource = bor.Listar();
            gpbEstoque.Visible = false;
            cbbTipoProduto.DataSource = new string[] { "Escolha o tipo do produto", "Pizza" };

        }

        private void btnAddSabor_Click(object sender, EventArgs e)
        {
            var dia = OpenMdiForm.OpenForWithShowDialog(new frmCadastrarSabor());
            if (dia == DialogResult.Yes)
            {
                var sab = new SaborRepositorio();
                cbbSabor.DisplayMember = "Nome";
                cbbSabor.DataSource = sab.Listar();
            }
        }

        private void btnAddCategoria_Click(object sender, EventArgs e)
        {
            var dia = OpenMdiForm.OpenForWithShowDialog(new frmCadastrarCategoria());
            if (dia == DialogResult.Yes)
            {
                var cat = new CategoriaRepositorio();
                cbbCategoria.DisplayMember = "Nome";
                cbbCategoria.DataSource = cat.Listar();
            }
        }

        private void ckbGerenciar_CheckedChanged(object sender, EventArgs e)
        {
            var f = gpbEstoque.Visible = (sender as CheckBox).Checked == true ? true : false;
            if (f)
            {
                txtQtd.Text = "0";
                txtQtdMax.Text = "0";
                txtQtdMin.Text = "0";
            }
        }


        private void btnAddBorda_Click(object sender, EventArgs e)
        {
            var dia = OpenMdiForm.OpenForWithShowDialog(new frmCadastrarBorda());
            if (dia == DialogResult.Yes)
            {
                var bor = new BordaRepositorio();
                cbbBorda.DisplayMember = "Nome";
                cbbBorda.DataSource = bor.Listar();
            }
        }

    }
}
