using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LojaElfez.BusinessRule;
using LojaElfez.BusinessCollection;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void BtnProdutos_Click(object sender, ImageClickEventArgs e)
    {

    }
   
    protected void BtnAtualizacoes_Click(object sender, ImageClickEventArgs e)
    {

    }

    protected void BtnClientes_Click(object sender, ImageClickEventArgs e)
    {

    }

    protected void BtnBaixaBoletos_Click(object sender, ImageClickEventArgs e)
    {

    }

    protected void BtnConsultas_Click(object sender, ImageClickEventArgs e)
    {

    }
    protected void BtnConfiguracoes_Click(object sender, ImageClickEventArgs e)
    {

    }

    protected void BtnProsseguir_Click(object sender, EventArgs e)
    {
        String Login;
        String Senha;

        lblMensagem.Text = "";

        Login = TxtLogin.Text.Trim();
        if (Login == String.Empty)
        {
            lblMensagem.Text = "Informe o login";
            return;
        }

        Senha = TxtSenha.Text.Trim();
        if (Senha == String.Empty)
        {
            lblMensagem.Text = "Informe a senha";
            return;
        }

        rul_usuario usr = new rul_usuario();
        usr.login = Login;
        usr.senha = Senha;
        col_usuario lista = usr.GetAll();
        if (lista.Count == 0)
        {
            lblMensagem.Text = "Login ou senha inválidos";
            return;
        }

        LojaElfez.Seguranca.UsuarioConectado = lista.Item(0);
        LojaElfez.Seguranca.LoginState = true;

        HabilitaDesabilitaBotoes(true);
        HabilitaDesabilitaogin(false);
              
    }
    
    protected void HabilitaDesabilitaBotoes(Boolean estado){

        BtnProdutos.Visible = estado;
        LblProdutos.Visible = estado;

        BtnAtualizacoes.Visible = estado;
        LblAtualizacoes.Visible = estado;

        BtnClientes.Visible = estado;
        LblClientes.Visible = estado;

        BtnBaixaBoletos.Visible = estado;
        LblBaixaBoletos.Visible = estado;

        BtnConsultas.Visible = estado;
        LblConsultas.Visible = estado;

        BtnConfiguracoes.Visible = estado;
        LblConfiguracoes.Visible = estado;
        
    }

    protected void HabilitaDesabilitaogin(Boolean estado)
    {
        TxtLogin.Visible = estado;
        TxtSenha.Visible = estado;
        //LblTitulo.Visible = estado;
        LblLogin.Visible = estado;
        LblSenha.Visible = estado;
        lblMensagem.Visible = estado;
        BtnProsseguir.Visible = estado;
    }


}
