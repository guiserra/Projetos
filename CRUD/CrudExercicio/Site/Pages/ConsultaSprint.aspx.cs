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
    public partial class ConsultaSprint : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pnlDados.Visible = false;
            try
            {
                SprintDAL u = new SprintDAL();

                gridSprint.DataSource = u.Listar(); //popular o grid
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
                int codigo = Convert.ToInt32(txtCodigo.Text);

                SprintDAL d = new SprintDAL();
                Sprint u = d.PesquisarPorCodigo(codigo);

                if (u != null)
                {
                    pnlDados.Visible = true;
                    txtNome.Text = u.Nome;
                    txtDescricao.Text = u.Descricao;
                    txtDuracao.Text = u.Duracao.ToString();
                    txtDataInicio.Text = u.DtInicio.ToString();
                }
                else
                {
                    lblMessagem.Text = "Sprint não encontrado";

                    txtCodigo.Text = string.Empty;
                    txtNome.Text = string.Empty;
                    txtDescricao.Text = string.Empty;
                    txtDuracao.Text = string.Empty;
                    txtDataInicio.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {

                lblMessagem.Text = ex.Message;
            }
        }

        protected void btnEditarUsuario(object sender, EventArgs e)
        {
            try
            {
                Sprint u = new Sprint();

                u.SprintId = Convert.ToInt32(txtCodigo.Text);
                u.Nome = Convert.ToString(txtNome.Text);
                u.Descricao = Convert.ToString(txtDescricao.Text);
                u.Duracao = Convert.ToInt32(txtDuracao.Text);
                u.DtInicio = Convert.ToDateTime(txtDataInicio.Text);

                SprintDAL d = new SprintDAL();
                d.Atualizar(u);

                lblMessagem.Text = "Sprint atualizado com sucesso";

                txtCodigo.Text = string.Empty;
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