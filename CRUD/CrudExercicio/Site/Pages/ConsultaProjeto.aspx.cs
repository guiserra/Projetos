using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjetoDAL.Model;
using ProjetoDAL.Persistence;

namespace Site.Pages
{
    public partial class ConsultarProjeto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pnlDados.Visible = false;
            try
            {
                ProjetooDAL u = new ProjetooDAL();

                gridProjeto.DataSource = u.Listar(); //popular o grid
                gridProjeto.DataBind(); //exibir o conteudo do grid
            }
            catch (Exception ex)
            {
                lblMessagem.Text = ex.Message;
            }
        }

        protected void btnPesquisarProjeto(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);

                ProjetooDAL d = new ProjetooDAL();
                Projeto u = d.PesquisarPorCodigo(codigo);

                if (u != null)
                {
                    pnlDados.Visible = true;
                    txtNome.Text = u.Nome;
                    txtTipo.Text = u.Tipo;
                }
                else
                {
                    lblMessagem.Text = "Projeto não encontrado";

                    txtCodigo.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {

                lblMessagem.Text = ex.Message;
            }
        }

        protected void btnAcessarSprint(object sender, EventArgs e)
        {
            //Capturar o valor selecionado na nossa dropdownlist
            string opcao = ddlProjeto.SelectedValue;

            switch (opcao)
            {
                case "0":
                    lblMensagem.Text = "Selecione uma opção válida!";
                    break;
                case "1":
                    Response.Redirect("/Pages/CadastroSprint.aspx");
                    break;
                case "2":
                    Response.Redirect("/Pages/ConsultaSprint.aspx");
                    break;
                default:
                    break;
            }
        }

        protected void btnEditarProjeto(object sender, EventArgs e)
        {
            try
            {
                Projeto u = new Projeto();

                u.ProjetoId = Convert.ToInt32(txtCodigo.Text);
                u.Nome = Convert.ToString(txtNome.Text);
                u.Tipo = Convert.ToString(txtTipo.Text);

                ProjetooDAL d = new ProjetooDAL();
                d.Atualizar(u);

                lblMessagem.Text = "Projeto atualizado com sucesso";

                txtCodigo.Text = string.Empty;
                txtNome.Text = string.Empty;
                txtTipo.Text = string.Empty;
            }
            catch (Exception ex)
            {

                lblMessagem.Text = ex.Message;
            }
        }


    }
}