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
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrarUsuario(object sender, EventArgs e)
        {
            try
            {
                Usuario u = new Usuario();

                u.Nome = txtNome.Text;
                u.Login = txtUser.Text;
                u.Senha = txtSenha.Text;

                UsuarioDAL d = new UsuarioDAL();

                d.Cadastrar(u);

                lblMessagem.Text = "Usuário " + u.Nome + " cadastrado com sucesso!";

                txtNome.Text = string.Empty;
                txtUser.Text = string.Empty;
                txtSenha.Text = string.Empty;
            }
            catch (Exception ex)
            {

                lblMessagem.Text = ex.Message;
            }
        }
    }
}