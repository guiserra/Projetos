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
    public partial class Consulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                UsuarioDAL u = new UsuarioDAL();

                gridUsuario.DataSource = u.Listar(); //popular o grid
                gridUsuario.DataBind(); //exibir o conteudo do grid
            }
            catch (Exception ex)
            {
                lblMessagem.Text = ex.Message;
            }
        }
    }
}