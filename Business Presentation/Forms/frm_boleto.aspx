	<!--****************************************************
	 * ADVERTISNMENT:                                    * 
	 * DEMO VERSION FOR EVALUATION ONLY                 * 
	 * YOU CAN'T USE TIER GENERATOR FOR COMMERCIAL USE   * 
	 **                                                   * 
	 ** Piton Consultoria Ltda                            * 
	 *  Business Presentation Layer                       * 
	 ** Projeto:LojaElfez                                 **
	 *  Chamada: (principal)boleto                               * 
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

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frm_boleto.aspx.cs" Inherits="boleto"  StylesheetTheme="Blue" %>

<%@ Import Namespace="LojaElfez" %>
<%@ Import Namespace="LojaElfez.BusinessRule" %>
<%@ Import Namespace="LojaElfez.BusinessCollection" %>
<%@ Import Namespace="System.Drawing" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>LojaElfez - boleto</title>
    <link href="../StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body style="padding-right: 0px; padding-left: 0px; padding-bottom: 0px; margin: 0px; padding-top: 0px">

    <form id="frmboleto" runat="server" onload="Page_Load">
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
                boleto</div>
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
            <asp:Label ID="lblboleto" runat="server" CssClass="Label" Text="Boleto:" width="48px"   AssociatedControlID="txtboleto"></asp:Label>
            <asp:TextBox ID="txtboleto" runat="server"  MaxLength="5"   width="100"  Font-Names="Tahoma" Font-Size="Small"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
        </tr>
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
            <asp:Label ID="lblproduto" runat="server" CssClass="Label" Text="Produto:" width="48px"   AssociatedControlID="txtproduto"></asp:Label>
            <asp:TextBox ID="txtproduto" runat="server"  MaxLength="5"   width="100"  Font-Names="Tahoma" Font-Size="Small"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
        </tr>
        <tr>
        <td style="width: 1px">
            <asp:Label ID="lblcedente" runat="server" CssClass="Label" Text="Cedente:" width="48px"   AssociatedControlID="txtcedente"></asp:Label>
            <asp:TextBox ID="txtcedente" runat="server"  MaxLength="200"   width="500"  Font-Names="Tahoma" Font-Size="Small"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
        </tr>
        <tr>
        <td style="width: 1px">
            <asp:Label ID="lblcnpj" runat="server" CssClass="Label" Text="Cnpj:" width="48px"   AssociatedControlID="txtcnpj"></asp:Label>
            <asp:TextBox ID="txtcnpj" runat="server"  MaxLength="30"   width="500"  Font-Names="Tahoma" Font-Size="Small"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
        </tr>
        <tr>
        <td style="width: 1px">
            <asp:Label ID="lblbanco" runat="server" CssClass="Label" Text="Banco:" width="48px"   AssociatedControlID="txtbanco"></asp:Label>
            <asp:TextBox ID="txtbanco" runat="server"  MaxLength="4"   width="500"  Font-Names="Tahoma" Font-Size="Small"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
        </tr>
        <tr>
        <td style="width: 1px">
            <asp:Label ID="lblagencia" runat="server" CssClass="Label" Text="Agencia:" width="48px"   AssociatedControlID="txtagencia"></asp:Label>
            <asp:TextBox ID="txtagencia" runat="server"  MaxLength="10"   width="500"  Font-Names="Tahoma" Font-Size="Small"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
        </tr>
        <tr>
        <td style="width: 1px">
            <asp:Label ID="lblconta" runat="server" CssClass="Label" Text="Conta:" width="48px"   AssociatedControlID="txtconta"></asp:Label>
            <asp:TextBox ID="txtconta" runat="server"  MaxLength="10"   width="500"  Font-Names="Tahoma" Font-Size="Small"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
        </tr>
        <tr>
        <td style="width: 1px">
            <asp:Label ID="lbldigito" runat="server" CssClass="Label" Text="Digito:" width="48px"   AssociatedControlID="txtdigito"></asp:Label>
            <asp:TextBox ID="txtdigito" runat="server"  MaxLength="2"   width="500"  Font-Names="Tahoma" Font-Size="Small"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
        </tr>
        <tr>
        <td style="width: 1px">
            <asp:Label ID="lblcarteira" runat="server" CssClass="Label" Text="Carteira:" width="48px"   AssociatedControlID="txtcarteira"></asp:Label>
            <asp:TextBox ID="txtcarteira" runat="server"  MaxLength="10"   width="500"  Font-Names="Tahoma" Font-Size="Small"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
        </tr>
        <tr>
        <td style="width: 1px">
            <asp:Label ID="lblvencimento" runat="server" CssClass="Label" Text="Vencimento:" width="48px"   AssociatedControlID="txtvencimento"></asp:Label>
            <asp:TextBox ID="txtvencimento" runat="server"  MaxLength="10"   width="100"  Font-Names="Tahoma" Font-Size="Small"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
        </tr>
        <tr>
        <td style="width: 1px">
            <asp:Label ID="lblquantidade" runat="server" CssClass="Label" Text="Quantidade:" width="48px"   AssociatedControlID="txtquantidade"></asp:Label>
            <asp:TextBox ID="txtquantidade" runat="server"  MaxLength="5"   width="100"  Font-Names="Tahoma" Font-Size="Small"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
        </tr>
        <tr>
        <td style="width: 1px">
            <asp:Label ID="lblpreco" runat="server" CssClass="Label" Text="Preco:" width="48px"   AssociatedControlID="txtpreco"></asp:Label>
            <asp:TextBox ID="txtpreco" runat="server"  MaxLength="12"   width="100"  Font-Names="Tahoma" Font-Size="Small"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
        </tr>
        <tr>
        <td style="width: 1px">
            <asp:Label ID="lbldatacriacao" runat="server" CssClass="Label" Text="Datacriacao:" width="48px"   AssociatedControlID="txtdatacriacao"></asp:Label>
            <asp:TextBox ID="txtdatacriacao" runat="server"  MaxLength="10"   width="100"  Font-Names="Tahoma" Font-Size="Small"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
        </tr>
        <tr>
        <td style="width: 1px">
            <asp:Label ID="lbldatapagamento" runat="server" CssClass="Label" Text="Datapagamento:" width="48px"   AssociatedControlID="txtdatapagamento"></asp:Label>
            <asp:TextBox ID="txtdatapagamento" runat="server"  MaxLength="10"   width="100"  Font-Names="Tahoma" Font-Size="Small"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
        </tr>
        <tr>
        <td style="width: 1px">
            <asp:Label ID="lblatualizacao" runat="server" CssClass="Label" Text="Atualizacao:" width="48px"   AssociatedControlID="txtatualizacao"></asp:Label>
            <asp:TextBox ID="txtatualizacao" runat="server"  MaxLength="5"   width="100"  Font-Names="Tahoma" Font-Size="Small"></asp:TextBox>
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
