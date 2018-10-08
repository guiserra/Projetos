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
    public partial class DetalhesProj : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMensagem.Text = string.Empty;
            pnlDados.Visible = false;
            pnlSprint.Visible = false;
            txtCodigoSprint.Visible = false;
            btnConfirm.Visible = false;
            btnCancel.Visible = false;
            btnDeleteSprint.Visible = true;
        }

        protected void btnNovaSprint(object sender, EventArgs e)
        {
            pnlSprint.Visible = true;
        }

        protected void btnCancelarSprint(object sender, EventArgs e)
        {
            pnlSprint.Visible = false;
        }

        protected void btnPesquisarProj(object sender, EventArgs e)
        {
            try
            {
                lblMensagem.Text = string.Empty;

                int Codigo = Convert.ToInt32(txtCodigo.Text);

                ProjetoDAL pd = new ProjetoDAL();
                int cod = Convert.ToInt32(Session["CodigoUsuarioLogado"]);
                Projeto p = pd.PesquisarId(Codigo, cod);

                SprintDAL sp = new SprintDAL();
                int codProj = Convert.ToInt32(txtCodigo.Text);

                if (p != null)
                {
                    gridSprints.DataSource = sp.ListarSprt(codProj);//Popular a grid

                    if (sp.ListarSprt(codProj).Count > 0) {
                        gridSprints.DataBind();                     //Exibe a grid
                    }
                    else
                    {
                        lblListaSprint.Text = "--\nEste projeto nao possui Sprints cadastradas ainda--";
                    }

                    pnlDados.Visible = true;
                    txtNome.Text = p.Nome;
                }
                else
                {
                    lblMensagem.Text = "Projeto não encontrado.";
                    txtCodigo.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }

        protected void btnAtualizarProj(object sender, EventArgs e)
        {
            try
            {
                Projeto p = new Projeto();

                p.Codigo = Convert.ToInt32(txtCodigo.Text);
                p.Nome = Convert.ToString(txtNome.Text);

                ProjetoDAL pd = new ProjetoDAL();
                pd.AtualizarProj(p);

                lblMensagem.Text = "Projeto " + p.Nome + " atualizado com sucesso.";

                txtCodigo.Text = string.Empty;
                txtNome.Text = string.Empty;
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }

        protected void btnExcluirProj(object sender, EventArgs e)
        {
            try
            {
                int Codigo = Convert.ToInt32(txtCodigo.Text);

                Projeto p = new Projeto();
                ProjetoDAL pd = new ProjetoDAL();

                pd.ExcluirProj(Codigo);

                lblMensagem.Text = "Projeto " + p.Nome + " excluido com sucesso.";

                txtCodigo.Text = string.Empty;
                txtNome.Text = string.Empty;
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }

        protected void btnCadastrarSprint(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txtDuracao.Text) > 0)
                {
                    Sprint u = new Sprint();

                    u.Nome = txtSprintNome.Text;
                    u.Semanas = int.Parse(txtDuracao.Text);
                    u.Observacoes = txtDescricaoSprint.Text;

                    if (txtStatus.Checked)
                    {
                        u.Status = true;
                    }
                    else
                    {
                        u.Status = false;
                    }

                    SprintDAL d = new SprintDAL();

                    int cod = Convert.ToInt32(txtCodigo.Text);
                    d.CadastrarSprt(u, cod);

                    lblMensagem.Text = "Sprint " + u.Nome + " cadastrada com sucesso!";

                    txtSprintNome.Text = string.Empty;
                    txtDescricaoSprint.Text = string.Empty;
                    txtDuracao.Text = string.Empty;
                    txtStatus.Text = string.Empty;
                    pnlSprint.Visible = false;
                }
                else
                {
                    pnlSprint.Visible = false;
                    lblMensagem.Text = "Por favor declare uma duração da Sprint Valida!";
                }
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }

        protected void btnRemoverSprint(object sender, EventArgs e)
        {
            btnDeleteSprint.Visible = false;
            txtCodigoSprint.Visible = true;
            btnConfirm.Visible = true;
            btnCancel.Visible = true;
        }

        protected void btnConfirmarExclusao(object sender, EventArgs e)
        {
            try
            {
                int Codigo = Convert.ToInt32(txtCodigoSprint.Text);

                Sprint p = new Sprint();
                SprintDAL pd = new SprintDAL();

                pd.ExcluirSprt(Codigo);

                lblMensagem.Text = "Sprint " + p.Nome + " excluida com sucesso.";

                btnDeleteSprint.Visible = true;
                txtCodigoSprint.Visible = false;
                btnConfirm.Visible = false;
                btnCancel.Visible = false;
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }

        protected void btnCancelarExclusao(object sender, EventArgs e)
        {
            btnDeleteSprint.Visible = true;
            txtCodigoSprint.Visible = false;
            btnConfirm.Visible = false;
            btnCancel.Visible = false;

            lblMensagem.Text = "Exclusão da Sprint cancelada com sucesso.";
        }
    }
}