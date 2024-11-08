using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using LojaElfez.BusinessRule;

/// <summary>
/// Summary description for Seguranca
/// </summary>
namespace LojaElfez
{
    public sealed class Seguranca
    {

        #region "Variaveis"

        static public Boolean LoginState = false;
        static public Boolean Administrador = false;
        static public rul_usuario UsuarioConectado = null;

        #endregion

        #region "Propriedades"

        #endregion

        #region "Construtores"

        public Seguranca()
        {
            //
            // TODO: Add constructor logic here
            //
            LoginState = false;
            Administrador = false;

        }
        ~Seguranca()
        {
            //
            // TODO: Add constructor logic here
            //
            LoginState = false;
            Administrador = false;

        }
        #endregion

    }

}