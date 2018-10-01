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
            pnlDados.Visible = false;
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

        protected void btnPesquisarUsuario(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);

                UsuarioDAL d = new UsuarioDAL();
                Usuario u = d.PesquisarPorCodigo(codigo);

                if (u != null)
                {
                    pnlDados.Visible = true;
                    txtNome.Text = u.Nome;
                    txtUser.Text = u.Login;
                    txtSenha.Text = u.Senha;
                }
                else
                {
                    lblMessagem.Text = "Usuario não encontrado";

                    txtCodigo.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {

                lblMessagem.Text = ex.Message;
            }
        }

        protected void btnExcluirUsuario(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);

                Usuario u = new Usuario();
                UsuarioDAL d = new UsuarioDAL();

                d.Excluir(codigo);

                lblMessagem.Text = "Usuario excluido com sucesso";

                txtNome.Text = string.Empty;
                txtUser.Text = string.Empty;
                txtSenha.Text = string.Empty;
            }
            catch (Exception ex)
            {

                lblMessagem.Text = ex.Message;
            }
        }

        protected void btnEditarUsuario(object sender, EventArgs e)
        {
            try
            {
                Usuario u = new Usuario();

                u.UsuarioId = Convert.ToInt32(txtCodigo.Text);
                u.Nome = Convert.ToString(txtNome.Text);
                u.Login = Convert.ToString(txtUser.Text);
                u.Senha = Convert.ToString(txtSenha.Text);

                UsuarioDAL d = new UsuarioDAL();
                d.Atualizar(u);

                lblMessagem.Text = "Usuario atualizado com sucesso";

                txtCodigo.Text = string.Empty;
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