using ProjetoDAL.Model;
using ProjetoDAL.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site.Pages
{
    public partial class CadastrarProjeto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrarProjeto(object sender, EventArgs e)
        {
            try
            {
                Projeto p = new Projeto();

                p.Nome = txtNome.Text;
                p.Tipo = txtTipo.Text;

                ProjetooDAL d = new ProjetooDAL();

                d.Cadastrar(p);

                lblMessagem.Text = "Projeto " + p.Nome + " cadastrado com sucesso!";

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