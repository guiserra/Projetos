using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary1.Model;
using ClassLibrary1.Persistence;

namespace Site.Pages.Scripts
{
    public partial class CadastroProj : System.Web.UI.Page
    {
        protected void btnCadastrarProj(object sender, EventArgs e)
        {
            try
            {
                Projeto p = new Projeto();

                p.Nome = txtNome.Text;

                ProjetoDAL pd = new ProjetoDAL();

                pd.CadastrarProj(p); //Gravando a pessoa

                lblMensagem.Text = "Projeto " + p.Nome + " cadastrado com Sucesso.";

                txtNome.Text = string.Empty;

            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }
    }
}