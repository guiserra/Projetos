using ClassLibrary1.Model;
using ClassLibrary1.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site.Pages
{
    public partial class CadastroSprint : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnCadastrarSprint(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txtDuracao.Text) > 0)
                {
                    Sprint u = new Sprint();

                    u.Nome = txtNome.Text;
                    u.Semanas = int.Parse(txtDuracao.Text);
                    u.Observacoes = txtDescricao.Text;

                    if (txtStatus.Checked)
                    {
                        u.Status = true;
                    }
                    else
                    {
                        u.Status = false;
                    }

                    SprintDAL d = new SprintDAL();

                    d.CadastrarSprt(u);

                    lblMessagem.Text = "Sprint " + u.Nome + " cadastrada com sucesso!";

                    txtNome.Text = string.Empty;
                    txtDescricao.Text = string.Empty;
                    txtDuracao.Text = string.Empty;
                    txtStatus.Text = string.Empty;
                }
                else
                {
                    lblMessagem.Text = "Por favor declare uma duração da Sprint Valida!";
                }
            }
            catch (Exception ex)
            {
                lblMessagem.Text = ex.Message;
            }
        }

    }
}