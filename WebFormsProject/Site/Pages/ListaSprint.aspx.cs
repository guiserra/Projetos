using ClassLibrary1.Model;
using ClassLibrary1.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site.Pages
{
    public partial class ListaSprint : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pnlDados.Visible = false;
            try
            {
                SprintDAL u = new SprintDAL();

                gridSprint.DataSource = u.ListarSprt(); //popular o grid
                gridSprint.DataBind(); //exibir o conteudo do grid
            }
            catch (Exception ex)
            {
                lblMessagem.Text = ex.Message;
            }
        }

        protected void btnPesquisarSprint(object sender, EventArgs e)
        {
            try
            {
                lblMessagem.Text = string.Empty;

                int codigo = Convert.ToInt32(txtCodigo.Text);

                SprintDAL d = new SprintDAL();
                Sprint u = d.PesquisarId(codigo);

                if (u != null)
                {
                    pnlDados.Visible = true;
                    txtNome.Text = u.Nome;
                    txtDescricao.Text = u.Observacoes;
                    txtDuracao.Text = u.Semanas.ToString();
                    txtStatus.Text = u.Status.ToString();
                }
                else
                {
                    lblMessagem.Text = "Sprint não encontrado";

                    txtCodigo.Text = string.Empty;
                    txtNome.Text = string.Empty;
                    txtDescricao.Text = string.Empty;
                    txtDuracao.Text = string.Empty;
                    txtStatus.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {

                lblMessagem.Text = ex.Message;
            }
        }

        protected void btnEditarSprint(object sender, EventArgs e)
        {
            try
            {
                Sprint u = new Sprint();

                u.Codigo = Convert.ToInt32(txtCodigo.Text);
                u.Nome = txtNome.Text;
                u.Semanas = int.Parse(txtDuracao.Text);
                u.Observacoes = txtDescricao.Text;

                if (txtStatus.Checked)
                {
                    u.Status = true;
                }
                else
                {
                    u.Status = false;
                }

                SprintDAL d = new SprintDAL();
                d.AtualizarSprt(u);

                Response.Redirect("/Pages/ListaSprint.aspx");

                lblMessagem.Text = "Sprint atualizado com sucesso";
            }
            catch (Exception ex)
            {
                lblMessagem.Text = ex.Message;
            }
        }
    }
}