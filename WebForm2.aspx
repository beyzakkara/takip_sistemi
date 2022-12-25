<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="haftalıkKuaförTakipSistemi.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style3 {
            width: 323px;
        }
        .auto-style4 {
            width: 324px;
        }
        .auto-style5 {
            width: 324px;
            height: 30px;
        }
        .auto-style6 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            &nbsp;</p>
        <asp:Label ID="Label3" runat="server" Text="Müşteri Randevu bilgilerini giriniz"></asp:Label>
        <table style="width:100%;">
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label4" runat="server" Text="ad"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label5" runat="server" Text="soyad"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label6" runat="server" Text="gün"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <table style="width:100%;">
            <tr>
                <td class="auto-style5">işlem türü</td>
                <td class="auto-style6">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox ID="CheckBox4" runat="server" Text="saç kesimi" OnCheckedChanged="CheckBox4_CheckedChanged" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox ID="CheckBox5" runat="server" Text="saç boyama" OnCheckedChanged="CheckBox5_CheckedChanged" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox ID="CheckBox6" runat="server" OnCheckedChanged="CheckBox6_CheckedChanged" Text="kaş işlemi" />
                </td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td class="auto-style4">saat</td>
                <td>
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label9" runat="server" Text="islem sayısı"></asp:Label>
                </td>
                <td>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:CheckBox ID="CheckBox7" runat="server" OnCheckedChanged="CheckBox7_CheckedChanged" Text="birinci" />
                    &nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox ID="CheckBox8" runat="server" OnCheckedChanged="CheckBox8_CheckedChanged" Text="ikinci" />
&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox ID="CheckBox9" runat="server" OnCheckedChanged="CheckBox9_CheckedChanged" Text="üçüncü" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    Toplam</td>
                <td>
        <asp:Label ID="lblToplamFiyat" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <asp:Button ID="Button1" runat="server" Height="67px" OnClick="Button1_Click" Text="kaydet" Width="172px" />
        <asp:Button ID="btnHesapla" runat="server" Height="67px" OnClick="btnHesapla_Click" Text="Hesapla" Width="172px" />

        <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>

        <div>
            &nbsp;<br />

        </div>
    </form>
</body>
</html>
