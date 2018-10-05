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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                ProjetoDAL pd = new ProjetoDAL();

                if (pd == null)
                {
                    lblMensagem.Text = "Lista Vazia.";
                }
                else
                {
                    gridProjetos.DataSource = pd.ListarProj();  //Popular a grid
                    gridProjetos.DataBind();                    //Exibe a grid
                }
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }

        protected void btnAcessarSprint(object sender, EventArgs e)
        {
            //Capturar o valor selecionado na nossa dropdownlist
            string opcao = ddlProjeto.SelectedValue;

            switch (opcao)
            {
                case "0":
                    lblMensagem.Text = "Selecione uma opção válida!";
                    break;
                case "1":
                    Response.Redirect("/Pages/CadastroSprint.aspx");
                    break;
                case "2":
                    Response.Redirect("/Pages/ListaSprint.aspx");
                    break;
                default:
                    break;
            }
        }
    }
}