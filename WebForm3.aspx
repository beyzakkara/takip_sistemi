<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="haftalıkKuaförTakipSistemi.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 198px;
        }

        .auto-style2 {
            width: 200px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width: 100%;">
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label2" runat="server" Text="randevu saati"></asp:Label>
                </td>
                <td>
                    <asp:Label runat="server" ID="lblrndSaat"></asp:Label></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label3" runat="server" Text="randevu günü"></asp:Label>
                </td>
                <td>
                    <asp:Label runat="server" ID="lblRndGun"></asp:Label></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label4" runat="server" Text="işlem türü"></asp:Label>
                </td>
                <td>
                    <asp:Label runat="server" ID="lblIslemTur"></asp:Label></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label5" runat="server" Text="ToplamFiyat"></asp:Label>
                </td>
                <td>
                    <asp:Label runat="server" ID="lblToplamFiyat"></asp:Label></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label6" runat="server" Text="İndirim Oranı"></asp:Label>
                </td>
                <td>
                    <asp:Label runat="server" ID="lblIndirimOrani"></asp:Label></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="Label7" runat="server" Text="Genel Toplam"></asp:Label>
                </td>
                <td>
                    <asp:Label runat="server" ID="lblGenelToplam"></asp:Label></td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
    <table style="width: 100%;">
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</body>
</html>
