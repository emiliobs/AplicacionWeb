<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Cliente.aspx.cs" Inherits="AplicacionWeb.Cliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table style="width: 100%">
        <tr>
            <td colspan="3">
                <h1 style="color: #0000CC; font-size: x-large"><strong><em>Clientes:</em></strong></h1>
            </td>
        </tr>
        <tr>
            <td style="width: 676px" rowspan="4">
                <img alt="Clientes" src="images/clientes1.jpg" style="width: 623px; height: 218px" /></td>
            <td style="width: 339px">
                <asp:Label ID="Label1" runat="server" Text="Id Cliente:" CssClass="bold" Style="color: #0000FF; font-style: italic"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtIdCliente" runat="server" Width="289px" ReadOnly="true"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 339px">
                <asp:Label ID="Label2" runat="server" Text="Nombre:" CssClass="bold" Style="color: #0000FF; font-style: italic"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNombre" runat="server" Width="289px"></asp:TextBox>
<%--                <asp:RequiredFieldValidator ErrorMessage="Debe ingre Nombre" ControlToValidate="txtNombre" runat="server" />--%>
            </td>
        </tr>
        <tr>
            <td style="width: 339px">
                <asp:Label ID="Label3" runat="server" Text="Dirección:" Style="color: #0000FF; font-weight: 700; font-style: italic"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDireccion" runat="server" Width="289px" TextMode="MultiLine" Height="81px"></asp:TextBox>
<%--                <asp:RequiredFieldValidator ErrorMessage="Debe ingrear Dirección" ControlToValidate="txtDireccion" ForeColor="Red" runat="server" />--%>
            </td>
        </tr>
        <tr>
            <td style="width: 339px">
                <asp:Label ID="Label4" runat="server" Text="Teléfono:" CssClass="bold" Style="color: #0000FF; font-style: italic"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtTelefono" runat="server" Width="289px"></asp:TextBox>
<%--                <asp:RequiredFieldValidator ErrorMessage="Deb ingre un Teléfono" ControlToValidate="txtTelefono" ForeColor="Red" runat="server" />--%>
            </td>
        </tr>
        <tr>
            <td style="width: 676px">&nbsp;</td>
            <td style="width: 339px">&nbsp;</td>
            <td>
                <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="bold" Style="color: #0000FF; font-style: italic" OnClick="btnAgregar_Click" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblEstado" runat="server" Style="font-weight: 700; font-style: italic; color: #FF0000; font-size: large"></asp:Label>

            </td>
            <td>
                <asp:Label ID="lblError" runat="server" Style="font-weight: 700; font-style: italic; color: #FF0000; font-size: large"></asp:Label>

            </td>
        </tr>
    </table>

</asp:Content>
