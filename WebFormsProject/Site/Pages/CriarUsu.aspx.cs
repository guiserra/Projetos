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
    public partial class CriarUsu : System.Web.UI.Page
    {
        protected void btnCadastrarUsuario(object sender, EventArgs e)
        {
            try
            {
                Usuario u = new Usuario();

                u.Nome = txtNome.Text;
                u.Email = txtEmail.Text;
                u.Senha = txtSenha.Text;

                UsuarioDAL ud = new UsuarioDAL();

                ud.CadastrarUsu(u); //Gravando a pessoa

                lblMensagem.Text = "Usuário " + u.Nome + " criado com Sucesso.";

                txtNome.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtSenha.Text = string.Empty;
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }
    }
}