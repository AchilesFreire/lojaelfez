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

public partial class VerificaLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        rul_Cliente cliente = new rul_Cliente();
        cliente.login = Request.QueryString["Login"];

        col_Cliente lista = cliente.GetAll();

        if ( lista.Count >0 )
            Response.Write("<p>Ja existe cadastro com este login</p>");

        lista.Clear();

    }
}
