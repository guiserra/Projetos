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
    public partial class DetalhesUsu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMensagem.Text = string.Empty;
            pnlDados.Visible = false;
        }

        protected void btnPesquisarUsu(object sender, EventArgs e)
        {
            try
            {
                lblMensagem.Text = string.Empty;

                int Codigo = Convert.ToInt32(txtCodigo.Text);

                UsuarioDAL pd = new UsuarioDAL();
                Usuario p = pd.PesquisarId(Codigo);

                if (p != null)
                {
                    pnlDados.Visible = true;
                    txtNome.Text = p.Nome;
                    txtEmail.Text = p.Email;
                    txtSenha.Text = p.Senha;
                }
                else
                {
                    lblMensagem.Text = "Usuário não encontrado.";
                    txtCodigo.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }

        protected void btnAtualizarUsu(object sender, EventArgs e)
        {
            try
            {
                Usuario p = new Usuario();

                p.Codigo = Convert.ToInt32(txtCodigo.Text);
                p.Nome = Convert.ToString(txtNome.Text);
                p.Email = Convert.ToString(txtEmail.Text);
                p.Senha = Convert.ToString(txtSenha.Text);

                UsuarioDAL pd = new UsuarioDAL();
                pd.AtualizarUsu(p);

                lblMensagem.Text = "Usuário " + p.Nome + " atualizado com sucesso.";

                txtCodigo.Text = string.Empty;
                txtNome.Text = string.Empty;
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }

        protected void btnExcluirUsu(object sender, EventArgs e)
        {
            try
            {
                int Codigo = Convert.ToInt32(txtCodigo.Text);

                Usuario p = new Usuario();
                UsuarioDAL pd = new UsuarioDAL();

                pd.ExcluirUsu(Codigo);

                lblMensagem.Text = "Usuário " + p.Nome + " excluido com sucesso.";

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