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
    public partial class CadastroSprint : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrarSprint(object sender, EventArgs e)
        {
            try
            {
                Sprint u = new Sprint();

                u.Nome = txtNome.Text;
                u.Descricao = txtDescricao.Text;
                u.Duracao = int.Parse(txtDuracao.Text);
                u.DtInicio = DateTime.Parse(txtDataInicio.Text);

                SprintDAL d = new SprintDAL();

                d.Cadastrar(u);

                lblMessagem.Text = "Sprint " + u.Nome + " cadastrada com sucesso!";

                txtNome.Text = string.Empty;
                txtDescricao.Text = string.Empty;
                txtDuracao.Text = string.Empty;
                txtDataInicio.Text = string.Empty;
            }
            catch (Exception ex)
            {

                lblMessagem.Text = ex.Message;
            }
        }
    }
}