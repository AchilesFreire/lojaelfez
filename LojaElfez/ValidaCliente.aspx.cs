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

public partial class ValidaCliente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Request.QueryString["TxtEMail"] != null)
            {
                rul_Cliente cliente = new rul_Cliente();
                cliente.email = Request.QueryString["TxtEMail"];

                col_Cliente lista = cliente.GetAll();

                if (lista.Count == 1)
                {
                    cliente = lista.Item(0);

                    cliente.ValidaCliente();

                    if ( cliente.mensagem =="")
                        Response.Write("<p>Cliente validado</p>");
                    else
                        Response.Write("<p>Problema na validacao: <b>"+ cliente.mensagem + "</b></p>");
                }
                else
                {
                    Response.Write("<p>Email nao encontrado</p>");
                }
            }

        }
        catch (Exception ex)
        {

        }
    }
}
