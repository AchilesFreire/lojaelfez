using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using LojaElfez;
using LojaElfez.BusinessRule;
using LojaElfez.BusinessCollection;

public partial class AlteraCadastro : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        rul_Cliente cliente = new rul_Cliente();
        String Retorno = "";

        cliente.login = Request.QueryString["Login"];
        cliente.senha = Request.QueryString["Senha"];

        col_Cliente lista = cliente.GetAll();

        if (lista.Count == 0)
            Response.Write("Login ou senha são invalidos");
        else
        {
            Retorno += cliente.nome + ";";
            Retorno += cliente.email + ";";
            Retorno += cliente.endereco + ";";
            Retorno += cliente.bairro + ";";
            Retorno += cliente.cidade + ";";
            Retorno += cliente.estado + ";";
            Retorno += cliente.ddd + ";";
            Retorno += cliente.telefonefixo + ";";
            Retorno += cliente.telefonecelular + ";";
            Retorno += cliente.cep + ";";
            Retorno += cliente.login + ";";
            Retorno += cliente.senha + ";";

            Response.Write("DADOS:{" + Retorno + "}");
        }
    }
}

