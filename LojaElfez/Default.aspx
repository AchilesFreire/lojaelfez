<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" Theme="Blue" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Loja Elfez</title>
 
    <link href="../StyleSheet.css" rel="stylesheet" type="text/css" />

    <style type="text/css">
        .style1
        {
            width: 199px;
        }
        .style3
        {
            width: 376px;
        }
    </style>

</head>
<body background="Imagens/BackGround.jpg">
    <form id="form1" runat="server">
    <div style="height: 166px">
    
        <table align="left" style="width: 708px">
            <tr>
                <td>
                    <asp:ImageButton ID="BtnProdutos" runat="server" 
                        ImageUrl="~/Imagens/JanelaPrincipal/Produtos.png" 
                        onclick="BtnProdutos_Click"  Visible="False" />
                </td>
                <td>
                    <asp:ImageButton ID="BtnAtualizacoes" runat="server" 
                        ImageUrl="~/Imagens/JanelaPrincipal/Atualizacoes.png" 
                        onclick="BtnAtualizacoes_Click" Visible="False" />
                </td>
                <td>
                    <asp:ImageButton ID="BtnClientes" runat="server" 
                        ImageUrl="~/Imagens/JanelaPrincipal/Clientes.png" 
                        onclick="BtnClientes_Click" Visible="False" />
                </td>
                <td>
                    <asp:ImageButton ID="BtnBaixaBoletos" runat="server" 
                        ImageUrl="~/Imagens/JanelaPrincipal/BaixaBoletos.png" 
                        onclick="BtnBaixaBoletos_Click" Visible="False" />
                </td>
                <td>
                    <asp:ImageButton ID="BtnConsultas" runat="server" 
                        ImageUrl="~/Imagens/JanelaPrincipal/Consultas.png" 
                        onclick="BtnConsultas_Click" Visible="False" />
                </td>
                <td class="style1">
                    <asp:ImageButton ID="BtnConfiguracoes" runat="server" 
                        ImageUrl="~/Imagens/JanelaPrincipal/Configuracoes.png" 
                        onclick="BtnConfiguracoes_Click" Visible="False" />
                </td>
            </tr>
            <tr>
                <td align="center">
                    <asp:Label ID="LblProdutos" runat="server" Text="Produtos" 
                        Font-Names="Calibri,Tahoma,Arial" Font-Size="14pt" ForeColor="#003399" 
                        Visible="False"></asp:Label>
                </td>
                <td  align="center">
                    <asp:Label ID="LblAtualizacoes" runat="server" Text="Atualizações" 
                        Font-Names="Calibri,Tahoma,Arial" Font-Size="14pt" ForeColor="#003399" 
                        Visible="False"></asp:Label>
                </td>
                <td  align="center">
                    <asp:Label ID="LblClientes" runat="server" Text="Clientes" 
                        Font-Names="Calibri,Tahoma,Arial" Font-Size="14pt" ForeColor="#003399" 
                        Visible="False"></asp:Label>
                </td>
                <td  align="center">
                    <asp:Label ID="LblBaixaBoletos" runat="server" Text="Baixa de Boletos" 
                        Font-Names="Calibri,Tahoma,Arial" Font-Size="14pt" ForeColor="#003399" 
                        Visible="False"></asp:Label>
                </td>
                <td  align="center">
                    <asp:Label ID="LblConsultas" runat="server" Text="Consultas"
                    Font-Names="Calibri,Tahoma,Arial" Font-Size="14pt" ForeColor="#003399" 
                        Visible="False"></asp:Label>
                </td>
                <td  align="center">
                    <asp:Label ID="LblConfiguracoes" runat="server" Text="Configurações"
                    Font-Names="Calibri,Tahoma,Arial" Font-Size="14pt" ForeColor="#003399" 
                        Visible="False"></asp:Label>
                </td>
            </tr>
            </table>
    </div>
    

        
        <table align="center" style="height: 258px; width: 764px" >
            <tr>
                <td colspan="2" align="center" dir="rtl" class="Titulo" 
                    style="font-family: Calibri, Tahoma, Verdana, Arial; font-size: 28px; color: #003399;">
                    
                    Autenticação da Loja Elfez</td>

            </tr>
            <tr>
                <td align="right" class="style3">
                    <asp:Label ID="LblLogin" runat="server" Font-Names="Calibri,Tahoma,Arial" 
                        ForeColor="#003399" Text="Login:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TxtLogin" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="style3">
                    <asp:Label ID="LblSenha" runat="server" Font-Names="Calibri,Tahoma,Arial" 
                        ForeColor="#003399" Text="Senha:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TxtSenha" runat="server"></asp:TextBox>
                    
                </td>
            </tr>
            <tr align="center">
                <td colspan="2">
                   <asp:Button ID="BtnProsseguir" runat="server" Text="Prosseguir" 
                    onclick="BtnProsseguir_Click" Width="107px" /> 
                </td>
   
            </tr>
            <tr align="center">
                <td colspan="2" align="center" dir="rtl">
                    <asp:Label ID="lblMensagem" runat="server" Font-Names="Calibri,Tahoma,Arial" 
                    Font-Size="25pt" ForeColor="#003399"></asp:Label>
                
                </td>
   
            </tr>
            
        </table>
        <br />
        
        <br />
        <br />
    
    </form>
</body>
</html>
