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
using System.Net.Mail;


// ?Acao=Incluir&TxtNome=Achiles Freire Soares&TxtEMail=achiles@terra.com.br&TxtEndereco=elsewhere&TxtBairro=itapua&TxtCidade=salvador&CboEstado=BA&TxtDDD=071&TxtTelefoneFixo=3099515&TxtTelefoneCelular=92248867&TxtCEP=4161015&TxtLogin=teste&TxtSenha=teste&TxtConfirmacaoSenha=teste

public partial class CadastraClientes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        rul_Cliente cliente = new rul_Cliente();

        String Acao = Request.QueryString["Acao"];

        if (Request.QueryString["TxtNome"] != null && Request.QueryString["TxtEMail"] != null && Request.QueryString["TxtSenha"] != null)
        {

            cliente.nome = Request.QueryString["TxtNome"].ToString();
            cliente.email = Request.QueryString["TxtEMail"];
            cliente.endereco = Request.QueryString["TxtEndereco"];
            cliente.bairro = Request.QueryString["TxtBairro"];
            cliente.cidade = Request.QueryString["TxtCidade"];
            cliente.estado = Request.QueryString["CboEstado"];
            cliente.ddd = Request.QueryString["TxtDDD"];
            cliente.telefonefixo = Request.QueryString["TxtTelefoneFixo"];
            cliente.telefonecelular = Request.QueryString["TxtTelefoneCelular"];
            cliente.cep = Request.QueryString["TxtCEP"];
            cliente.login = Request.QueryString["TxtLogin"];
            cliente.senha = Request.QueryString["TxtSenha"];
            String TxtConfirmacaoSenha = Request.QueryString["TxtConfirmacaoSenha"];

            if (Acao == "Incluir")
                cliente.ValidateInsert();
            else
                if (Acao == "Alterar")
                    cliente.ValidateUpdate();

            if (cliente.mensagem == "")
            {
                Response.Write("<p>Cliente cadastrado com sucesso</p>");
                EnviaEmail(cliente);
            }
            else
            {
                Response.Write("<p>Erro no cadastro de clientes</p>");
            }
        }

    }
    private Boolean EnviaEmail(rul_Cliente cliente)
    {
        try{
        String Assunto;
        String fonte = "<font face='arial' size=3px>";

        MailAddress remetente = new MailAddress("usointerno@elfez.com.br");
        MailAddress destinatario = new MailAddress("achiles@terra.com.br");
        MailMessage mensagem = new MailMessage(remetente, destinatario);

        mensagem.IsBodyHtml = true;

        Assunto = fonte;

        Assunto += "<center>Loja Elfez - Cliente cadastrado:</center>\n";

        Assunto += " <table border='1'>";
        Assunto += " <tr><td>" + fonte + "Nome</font></td><td>" + fonte + cliente.nome + "</font></td></tr>\n";
        Assunto += " <tr><td>" + fonte + "Email</font></td><td>" + fonte + cliente.email + "</font></td></tr>\n";
        Assunto += " <tr><td>" + fonte + "Endereço</font></td><td>" + fonte + cliente.endereco + "</font></td></tr>\n";
        Assunto += " <tr><td>" + fonte + "Bairro</font></td><td>" + fonte + cliente.bairro + "</font></td></tr>\n";
        Assunto += " <tr><td>" + fonte + "Cidade</font></td><td>" + fonte + cliente.cidade + "</font></td></tr>\n";
        Assunto += " <tr><td>" + fonte + "Estado</font></td><td>" + fonte + cliente.estado + "</font></td></tr>\n";
        Assunto += " <tr><td>" + fonte + "DDD</font></td><td>" + fonte + cliente.ddd + "</font></td></tr>\n";
        Assunto += " <tr><td>" + fonte + "Telefone fixo</font></td><td>" + fonte + cliente.telefonefixo + "</font></td></tr>\n";
        Assunto += " <tr><td>" + fonte + "Telefone celular</font></td><td>" + fonte + cliente.telefonecelular + "</font></td></tr>\n";
        Assunto += " <tr><td>" + fonte + "CEP</font></td><td>" + fonte + cliente.cep + "</font></td></tr>\n";
        Assunto += " <tr><td>" + fonte + "Login</font></td><td>" + fonte + cliente.login + "</font></td></tr>\n";
        Assunto += " <tr><td>" + fonte + "Senha</font></td><td>" + fonte + cliente.senha + "</font></td></tr>\n";
        Assunto += "</table><br><br><br>";
        Assunto += "<hr><br><br><br>";

        Assunto += "<center>" + fonte + "Para validar, clique no link abaixo</font></center>\n";

        Assunto += "<a href=\"http://www.elfez.com.br/lojaelfez/ValidarCliente.aspx?TxtEMail=" + cliente.email + "\">" + fonte + "Validar</font></a>";
        Assunto += "<hr><br><br><br>";
        Assunto += "<hr>";
        Assunto += "</font>";

        mensagem.Subject = "Loja Elfez - Cliente cadastrado";
        mensagem.Body = Assunto;

        // senha e*l@f#ez

        SmtpClient smtp = new SmtpClient();

        smtp.Host = "smtp.elfez.com.br";
        smtp.Port = 25;
        smtp.Credentials = new System.Net.NetworkCredential("usointerno@elfez.com.br", "e*l@f#ez");
        smtp.Send(mensagem);

        return true;
        }
        catch ( Exception ex){

            return false;
        }
    }
}
