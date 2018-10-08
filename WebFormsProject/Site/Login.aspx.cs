using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary1.Model;
using ClassLibrary1.Persistence;

namespace Site
{
    public partial class Login : System.Web.UI.Page
    {

        protected void btnLogar(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            u.Email = Convert.ToString(txtEmail.Text);
            u.Senha = txtSenha.Text;

            UsuarioDAL UsuarioDal = new UsuarioDAL();
            Usuario usuarioEncontrado = UsuarioDal.ValidarLogin(u);

            if (usuarioEncontrado.Codigo != 0)
            {
                if (u.Senha == usuarioEncontrado.Senha)
                {
                    Session["CodigoUsuarioLogado"] = usuarioEncontrado.Codigo;
                    Session["NomeUsuarioLogado"] = usuarioEncontrado.Nome;

                    Response.Redirect("/Pages/Default.aspx");
                }
                else
                {
                    lblMensagem.Text = "Senha do usuário incorreta!";
                }
            }
            else
            {
                lblMensagem.Text = "Usuário não encontrado!";
            }

            txtEmail.Text = string.Empty;
            txtSenha.Text = string.Empty;
        }

    }
}