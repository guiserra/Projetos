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
            try
            {
                Usuario u = new Usuario();

                u.Email = txtEmail.Text;
                u.Senha = txtSenha.Text;

                UsuarioDAL ud = new UsuarioDAL();

                if(ud.ValidarLogin(u) == true)
                {
                    Response.Redirect("/Pages/Default.aspx");
                }
                else
                {
                    lblMensagem.Text = "Usuario não cadastrado";
                    txtEmail.Text = string.Empty;
                    txtSenha.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }
    }
}