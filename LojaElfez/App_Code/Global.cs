using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace LojaElfez
{
    public sealed class Global
    {
        #region "Enumerados"

        public enum Acao
        {
            Indefinido = -1,
            Inclusao = 0,
            Alteracao = 1,
            Exclusao = 2,
            Pesquisa = 3
        }

        public enum EnumBarraFerramentas
        {
            BtnNovo = 0,
            BtnEditar = 1,
            BtnSalvar = 2,
            BtnExcluir = 3,
            BtnLocalizar = 4,
            BtnImprimir = 5,
            BtnVisualizar = 6,
            BtnAtualizar = 7,
            BtnControles = 8,
            BtnGrid = 9,
            BtnSair = 11

        }

        #endregion

        #region "Construtores"

        public Global()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        #endregion

        #region "Metodos publicos"

        /// <summary>
        /// Verifica se o objeto passado como parametro contem calor numerico
        /// </summary>
        /// <param name="valor">valor a ser testado</param>
        /// <returns>true se for numerico</returns>
        static public Boolean IsNumeric(Object valor)
        {
            int res = -1;

            return System.Int32.TryParse(valor.ToString(), out res);
        }

        /// <summary>
        /// Verifica se o objeto passado como parametro contem uma data valida
        /// </summary>
        /// <param name="valor">valor a ser testado</param>
        /// <returns>true se o valor é uma data valida</returns>
        static public Boolean IsDate(Object valor)
        {
            System.DateTime res = new DateTime();

            return System.DateTime.TryParse(valor.ToString(), out  res);
        }

        /// <summary>
        /// Verifica se o objeto passado como parametro contem um valor decimal valido
        /// </summary>
        /// <param name="valor">valor a ser testado</param>
        /// <returns>true se o o valor e um decimal valido</returns>
        static public Boolean IsDecimal(Object valor)
        {
            System.Decimal res = new Decimal(-1);

            return System.Decimal.TryParse(valor.ToString(), out  res);
        }

        #endregion


    }

}