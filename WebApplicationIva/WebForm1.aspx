<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="WebApplicationIva.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Calcular IVA</title>
    <style type="text/css">
        #Select1 {
            width: 170px;
        }
        .auto-style1 {
            width: 86px;
        }
        .auto-style2 {
            width: 245px;
        }
        .auto-style3 {
            text-align: left;
            height: 30px;
        }
        .auto-style4 {
            width: 86px;
            height: 55px;
        }
        .auto-style5 {
            width: 245px;
            height: 55px;
        }
        .auto-style6 {
            height: 55px;
        }
        .auto-style7 {
            width: 86px;
            height: 30px;
        }
        .auto-style8 {
            width: 245px;
            height: 30px;
        }
        .auto-style9 {
            font-size: large;
        }
        .auto-style10 {
            width: 127px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p class="auto-style9">
            <strong>Calcular IVA</strong></p>
        <div>
            &nbsp;Imtroduce los datos o el id de la factura
            <table style="width:100%;">
                <tr>
                    <td class="auto-style7">Pagar</td>
                    <td class="auto-style8">
    <div style="width: 165px">
    
        &nbsp; <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    
    </div>
                    </td>
                    <td class="auto-style3">Id Factura</td>
                </tr>
                <tr>
                    <td class="auto-style4">Tipo IVA</td>
                    <td class="auto-style5">
            <asp:ListBox ID="ListBox1" runat="server" Height="57px" style="margin-left: 0px" Width="133px">
                <asp:ListItem Selected="True" Value="0">General</asp:ListItem>
                <asp:ListItem Value="1">Reducido</asp:ListItem>
                <asp:ListItem Value="2">Super Reducido</asp:ListItem>
            </asp:ListBox>
                    </td>
                    <td class="auto-style6">
                        <asp:TextBox ID="TextBox4" runat="server" style="text-align: center"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            </div>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Calcular" Width="106px" BorderColor="Black" BorderStyle="Groove" />
        </p>
        <p>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style10"><strong>Total Sin IVA&nbsp;</strong></td>
                    <td> <asp:TextBox ID="TextBox2" runat="server" BackColor="#00CC99"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10"><strong>IVA&nbsp; </strong></td>
                    <td> <asp:TextBox ID="TextBox3" runat="server" BackColor="#00CC99"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </p>
    <p>
        &nbsp;</p>
    </form>
    </body>
</html>
