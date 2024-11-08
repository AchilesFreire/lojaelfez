	<!--****************************************************
	 * ADVERTISNMENT:                                    * 
	 * DEMO VERSION FOR EVALUATION ONLY                 * 
	 * YOU CAN'T USE TIER GENERATOR FOR COMMERCIAL USE   * 
	 **                                                   * 
	 ** Piton Consultoria Ltda                            * 
	 *  Business Presentation Layer                       * 
	 ** Projeto:LojaElfez                                 **
	 *  Chamada: (principal)produto                              * 
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

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frm_produto.aspx.cs" Inherits="produto"  StylesheetTheme="Blue" %>

<%@ Import Namespace="LojaElfez" %>
<%@ Import Namespace="LojaElfez.BusinessRule" %>
<%@ Import Namespace="LojaElfez.BusinessCollection" %>
<%@ Import Namespace="System.Drawing" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>LojaElfez - produto</title>
    <link href="../StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body style="padding-right: 0px; padding-left: 0px; padding-bottom: 0px; margin: 0px; padding-top: 0px">

    <form id="frmproduto" runat="server" onload="Page_Load">
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
                produto</div>
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
            <asp:Label ID="lblproduto" runat="server" CssClass="Label" Text="Produto:" width="48px"   AssociatedControlID="txtproduto"></asp:Label>
            <asp:TextBox ID="txtproduto" runat="server"  MaxLength="5"   width="100"  Font-Names="Tahoma" Font-Size="Small"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
        </tr>
        <tr>
        <td style="width: 1px">
            <asp:Label ID="lblnome" runat="server" CssClass="Label" Text="Nome:" width="48px"   AssociatedControlID="txtnome"></asp:Label>
            <asp:TextBox ID="txtnome" runat="server"  MaxLength="100"   width="500"  Font-Names="Tahoma" Font-Size="Small"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
        </tr>
        <tr>
        <td style="width: 1px">
            <asp:Label ID="lblversaoatual" runat="server" CssClass="Label" Text="Versaoatual:" width="48px"   AssociatedControlID="txtversaoatual"></asp:Label>
            <asp:TextBox ID="txtversaoatual" runat="server"  MaxLength="10"   width="500"  Font-Names="Tahoma" Font-Size="Small"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
        </tr>
        <tr>
        <td style="width: 1px">
            <asp:Label ID="lblpreco" runat="server" CssClass="Label" Text="Preco:" width="48px"   AssociatedControlID="txtpreco"></asp:Label>
            <asp:TextBox ID="txtpreco" runat="server"  MaxLength="14"   width="100"  Font-Names="Tahoma" Font-Size="Small"></asp:TextBox>
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
