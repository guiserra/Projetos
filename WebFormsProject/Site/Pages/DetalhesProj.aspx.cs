using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary1.Model;
using ClassLibrary1.Persistence;

namespace Site.Pages
{
    public partial class DetalhesProj : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMensagem.Text = string.Empty;
            pnlDados.Visible = false;
        }

        protected void btnPesquisarProj(object sender, EventArgs e)
        {
            try
            {
                lblMensagem.Text = string.Empty;

                int Codigo = Convert.ToInt32(txtCodigo.Text);

                ProjetoDAL pd = new ProjetoDAL();
                Projeto p = pd.PesquisarId(Codigo);

                if (p != null)
                {
                    pnlDados.Visible = true;
                    txtNome.Text = p.Nome;
                }
                else
                {
                    lblMensagem.Text = "Projeto não encontrado.";
                    txtCodigo.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }

        protected void btnAtualizarProj(object sender, EventArgs e)
        {
            try
            {
                Projeto p = new Projeto();

                p.Codigo = Convert.ToInt32(txtCodigo.Text);
                p.Nome = Convert.ToString(txtNome.Text);

                ProjetoDAL pd = new ProjetoDAL();
                pd.AtualizarProj(p);

                lblMensagem.Text = "Projeto " + p.Nome + " atualizado com sucesso.";

                txtCodigo.Text = string.Empty;
                txtNome.Text = string.Empty;
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }

        protected void btnExcluirProj(object sender, EventArgs e)
        {
            try
            {
                int Codigo = Convert.ToInt32(txtCodigo.Text);

                Projeto p = new Projeto();
                ProjetoDAL pd = new ProjetoDAL();

                pd.ExcluirProj(Codigo);

                lblMensagem.Text = "Projeto " + p.Nome + " excluido com sucesso.";

                txtCodigo.Text = string.Empty;
                txtNome.Text = string.Empty;
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }
    }
}