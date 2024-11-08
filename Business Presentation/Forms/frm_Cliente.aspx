	<!--****************************************************
	 * ADVERTISNMENT:                                    * 
	 * DEMO VERSION FOR EVALUATION ONLY                 * 
	 * YOU CAN'T USE TIER GENERATOR FOR COMMERCIAL USE   * 
	 **                                                   * 
	 ** Piton Consultoria Ltda                            * 
	 *  Business Presentation Layer                       * 
	 ** Projeto:LojaElfez                                 **
	 *  Chamada: (principal)Cliente                              * 
	 *                                                    * 
	 *  Objeto gerado automaticamente pelo TierGenerator  * 
	 *                                                    * 
	 *  Versao do programa:                 *  
	 *                                                    * 
	 *  Data da criacao: 26/10/2010                       * 
	 *  Hora de criacao: 09:42:19                         * 
	 *                                                    *  
	 *                                                    *  
	****************************************************!-->

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frm_Cliente.aspx.cs" Inherits="Cliente"  StylesheetTheme="Blue" %>

<%@ Import Namespace="LojaElfez" %>
<%@ Import Namespace="LojaElfez.BusinessRule" %>
<%@ Import Namespace="LojaElfez.BusinessCollection" %>
<%@ Import Namespace="System.Drawing" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>LojaElfez - Cliente</title>
    <link href="../StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body style="padding-right: 0px; padding-left: 0px; padding-bottom: 0px; margin: 0px; padding-top: 0px">

    <form id="frmCliente" runat="server" onload="Page_Load">
    <div>
        <asp:Panel ID="pnlBarraFerramentas" runat="server" Height="1px" Width="100%" SkinID="PainelBarraFerramentas">
            <table style="width: 344px">
                <tr>
                    <td style="height: 28px;">
                        <asp:ImageButton ID="btnNovo" runat="server" ImageUrl="~/Imagens/Toolbar/01-N.gif" OnClick="btnNovo_Click" ToolTip="Novo registro"/>
                    </td>
                    <td style="height: 28px">
                        <asp:ImageButton ID="btnEditar" runat="server" ImageUrl="~/Imagens/Toolbar/02-N.gif" OnClick="btnEditar_Click"  ToolTip="Editar o registro selecionado"/>
                    </td>
                    <td style="height: 28px">
                        <asp:ImageButton ID="btnSalvar" runat="server" ImageUrl="~/Imagens/Toolbar/03-N.gif" OnClick="btnSalvar_Click"  ToolTip="Salvar o registro"/>
                    </td>
                    <td style="height: 28px">
                        <asp:ImageButton ID="btnExcluir" runat="server" ImageUrl="~/Imagens/Toolbar/04-N.gif" OnClick="btnExcluir_Click"  ToolTip="Excluir o registro selecionado" />
                    </td>
                    <td style="height: 28px">
                        <asp:ImageButton ID="btnLocalizar" runat="server" ImageUrl="~/Imagens/Toolbar/05-N.gif" OnClick="btnLocalizar_Click" ToolTip="Habilitar pesquisa" />
                    </td>
                    <td style="height: 28px">
                        <asp:ImageButton ID="btnAtualizar" runat="server" ImageUrl="~/Imagens/Toolbar/06-N.gif" OnClick="btnAtualizar_Click" ToolTip="Pesquisar" />
                    </td>
                    <td style="height: 28px">
                        <asp:ImageButton ID="btnImprimir" runat="server" ImageUrl="~/Imagens/Toolbar/07-N.gif" OnClick="btnImprimir_Click" ToolTip="Imprimir listagem" />
                    </td>
                    <td style="height: 28px">
                        <asp:ImageButton ID="btnVisualizar" runat="server" ImageUrl="~/Imagens/Toolbar/08-N.gif" OnClick="btnVisualizar_Click" ToolTip="Visualizar listagem" />
                    </td>
                    <td style="height: 28px">
                        <asp:ImageButton ID="btnSair" runat="server" ImageUrl="~/Imagens/Toolbar/12.gif" OnClick="btnSair_Click" ToolTip="Cancelar" />
                    </td>
                </tr>
            </table>
            <div style="font-weight: bold; left: 456px; vertical-align: middle; width: 376px;
                color: aliceblue; font-family: Tahoma, Arial; position: absolute; top: 8px; height: 24px;
                text-align: right">
                Cliente</div>
        </asp:Panel>
        <asp:Panel ID="PainelMensagem" runat="server" Height="32px" Width="100%" SkinID="PainelMensagem">
            &nbsp;&nbsp;
            <asp:Label ID="lblMensagemRetorno" runat="server" ForeColor="Blue" Height="24px"
                Width="80%" style="vertical-align: middle; color: #0000ff; font-family: Arial; text-align: center" Font-Size="Small"></asp:Label>
        </asp:Panel>
        <asp:Panel ID="pnlControles" runat="server" Height="208px" Width="100%" ScrollBars="Auto" Enabled="False" SkinID="PainelControles">
        <table border="0" cellpadding="0" cellspacing="10" style="width: 792px; height: 128px">

        <tr>
        <td style="width: 1px">
            <asp:Label ID="lblcliente" runat="server" CssClass="Label" Text="Cliente:" width="48px"   AssociatedControlID="txtcliente"></asp:Label>
            <asp:TextBox ID="txtcliente" runat="server"  MaxLength="5"   width="100"  Font-Names="Tahoma" Font-Size="Small"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
        </tr>
        <tr>
        <td style="width: 1px">
            <asp:Label ID="lblcpf_cnpj" runat="server" CssClass="Label" Text="Cpf_cnpj:" width="48px"   AssociatedControlID="txtcpf_cnpj"></asp:Label>
            <asp:TextBox ID="txtcpf_cnpj" runat="server"  MaxLength="30"   width="500"  Font-Names="Tahoma" Font-Size="Small"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
        </tr>
        <tr>
        <td style="width: 1px">
            <asp:Label ID="lblnome" runat="server" CssClass="Label" Text="Nome:" width="48px"   AssociatedControlID="txtnome"></asp:Label>
            <asp:TextBox ID="txtnome" runat="server"  MaxLength="200"   width="500"  Font-Names="Tahoma" Font-Size="Small"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
        </tr>
        <tr>
        <td style="width: 1px">
            <asp:Label ID="lblemail" runat="server" CssClass="Label" Text="Email:" width="48px"   AssociatedControlID="txtemail"></asp:Label>
            <asp:TextBox ID="txtemail" runat="server"  MaxLength="100"   width="500"  Font-Names="Tahoma" Font-Size="Small"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
        </tr>
        <tr>
        <td style="width: 1px">
            <asp:Label ID="lblendereco" runat="server" CssClass="Label" Text="Endereco:" width="48px"   AssociatedControlID="txtendereco"></asp:Label>
            <asp:TextBox ID="txtendereco" runat="server"  MaxLength="200"   width="500"  Font-Names="Tahoma" Font-Size="Small"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
        </tr>
        <tr>
        <td style="width: 1px">
            <asp:Label ID="lblbairro" runat="server" CssClass="Label" Text="Bairro:" width="48px"   AssociatedControlID="txtbairro"></asp:Label>
            <asp:TextBox ID="txtbairro" runat="server"  MaxLength="100"   width="500"  Font-Names="Tahoma" Font-Size="Small"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
        </tr>
        <tr>
        <td style="width: 1px">
            <asp:Label ID="lblcidade" runat="server" CssClass="Label" Text="Cidade:" width="48px"   AssociatedControlID="txtcidade"></asp:Label>
            <asp:TextBox ID="txtcidade" runat="server"  MaxLength="200"   width="500"  Font-Names="Tahoma" Font-Size="Small"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
        </tr>
        <tr>
        <td style="width: 1px">
            <asp:Label ID="lblestado" runat="server" CssClass="Label" Text="Estado:" width="48px"   AssociatedControlID="txtestado"></asp:Label>
            <asp:TextBox ID="txtestado" runat="server"  MaxLength="2"   width="500"  Font-Names="Tahoma" Font-Size="Small"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
        </tr>
        <tr>
        <td style="width: 1px">
            <asp:Label ID="lblddd" runat="server" CssClass="Label" Text="Ddd:" width="48px"   AssociatedControlID="txtddd"></asp:Label>
            <asp:TextBox ID="txtddd" runat="server"  MaxLength="2"   width="500"  Font-Names="Tahoma" Font-Size="Small"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
        </tr>
        <tr>
        <td style="width: 1px">
            <asp:Label ID="lbltelefonefixo" runat="server" CssClass="Label" Text="Telefonefixo:" width="48px"   AssociatedControlID="txttelefonefixo"></asp:Label>
            <asp:TextBox ID="txttelefonefixo" runat="server"  MaxLength="10"   width="500"  Font-Names="Tahoma" Font-Size="Small"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
        </tr>
        <tr>
        <td style="width: 1px">
            <asp:Label ID="lbltelefonecelular" runat="server" CssClass="Label" Text="Telefonecelular:" width="48px"   AssociatedControlID="txttelefonecelular"></asp:Label>
            <asp:TextBox ID="txttelefonecelular" runat="server"  MaxLength="10"   width="500"  Font-Names="Tahoma" Font-Size="Small"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
        </tr>
        <tr>
        <td style="width: 1px">
            <asp:Label ID="lblcep" runat="server" CssClass="Label" Text="Cep:" width="48px"   AssociatedControlID="txtcep"></asp:Label>
            <asp:TextBox ID="txtcep" runat="server"  MaxLength="8"   width="500"  Font-Names="Tahoma" Font-Size="Small"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
        </tr>
        <tr>
        <td style="width: 1px">
            <asp:Label ID="lblobservacoes" runat="server" CssClass="Label" Text="Observacoes:" width="48px"   AssociatedControlID="txtobservacoes"></asp:Label>
            <asp:TextBox ID="txtobservacoes" runat="server"  MaxLength="4000"   width="500"  Font-Names="Tahoma" Font-Size="Small"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
        </tr>
        <tr>
        <td style="width: 1px">
            <asp:Label ID="lbllogin" runat="server" CssClass="Label" Text="Login:" width="48px"   AssociatedControlID="txtlogin"></asp:Label>
            <asp:TextBox ID="txtlogin" runat="server"  MaxLength="20"   width="500"  Font-Names="Tahoma" Font-Size="Small"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
        </tr>
        <tr>
        <td style="width: 1px">
            <asp:Label ID="lblsenha" runat="server" CssClass="Label" Text="Senha:" width="48px"   AssociatedControlID="txtsenha"></asp:Label>
            <asp:TextBox ID="txtsenha" runat="server"  MaxLength="20"   width="500"  Font-Names="Tahoma" Font-Size="Small"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
        </tr>
        <tr>
        <td style="width: 1px">
            <asp:Label ID="lbldatainclusao" runat="server" CssClass="Label" Text="Datainclusao:" width="48px"   AssociatedControlID="txtdatainclusao"></asp:Label>
            <asp:TextBox ID="txtdatainclusao" runat="server"  MaxLength="10"   width="100"  Font-Names="Tahoma" Font-Size="Small"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
        </tr>


        </table>
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" Height="192px" Width="100%" BackColor="#E0E0E0" BorderStyle="Solid" BorderWidth="1px" BorderColor="CornflowerBlue" ScrollBars="Vertical">
            &nbsp; &nbsp;

            <asp:GridView ID="dtgRegistros" runat="server" Width="100%" BorderStyle="None" Height="144px" AutoGenerateColumns="False" AutoGenerateSelectButton="True" OnSelectedIndexChanged="dtgRegistros_SelectedIndexChanged" AllowSorting="True">
                <Columns>
                    <asp:ImageField>
                    </asp:ImageField>
                </Columns>
            </asp:GridView>
        </asp:Panel>
        </div>            
    </form>
</body>
</html>
