using System;

public partial class PainelAdmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //esse trecho verifica se existe a sessão "autenticado", se não existir redireciona o usuario para a pagina Index
        if (Session["autenticado"]== null)
        {
            Response.Redirect("index.aspx");
        }
        lblUsuario.Text = Session["nome"].ToString();
    }
}