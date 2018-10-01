using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAcessarUsuario(object sender, EventArgs e)
        {
            //Capturar o valor selecionado na nossa dropdownlist
            string opcao = ddlUsuario.SelectedValue;

            switch (opcao)
            {
                case "0":
                    lblMensagem.Text = "Selecione uma opção válida!";
                    break;
                case "1":
                    Response.Redirect("/Pages/CadastroUsuario.aspx");
                    break;
                case "2":
                    Response.Redirect("/Pages/ConsultaUsuario.aspx");
                    break;
                case "3":
                    Response.Redirect("/Pages/CadastroProjeto.aspx");
                    break;
                case "4":
                    Response.Redirect("/Pages/ConsultaProjeto.aspx");
                    break;
                default:
                    break;
            }
        }

    }
}