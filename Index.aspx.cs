using System;
using System.Data.SqlClient;
using System.Web.UI;

public partial class Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {
            Session.Abandon();
        }
    }

    protected void btnEntrar_Click(object sender, EventArgs e)
    {
        using (SqlConnection con = new SqlConnection("Server=AME0556331W10-1\\SQLEXPRESS;DataBase=DB_LIVRARIA;trusted_connection=Yes"))
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM TB_USUARIOS WHERE NOME_USUARIO = @usuario AND SENHA = @senha", con))
            {
                cmd.Parameters.AddWithValue("Usuario", txtUsuario.Text);
                cmd.Parameters.AddWithValue("Senha", txtSenha.Text);

                try
                {
                    con.Open();
                    SqlDataReader sdrUsuario = cmd.ExecuteReader();
                    sdrUsuario.Read();
                    if (sdrUsuario.HasRows)
                    {
                        Session["autenticado"] = "OK";
                        Session["nome"] = sdrUsuario.GetString(1);
                        Response.Redirect("PainelAdmin.aspx");
                    }
                    else
                    {
                        lblMensagem.Text = "Usuário ou senha invalido";
                    }
                }
                catch(Exception ex)
                {
                    lblMensagem.Text = "Erro de Banco de dados. contate o suporte." + ex.Message;
                }
            }
        }
    }
}