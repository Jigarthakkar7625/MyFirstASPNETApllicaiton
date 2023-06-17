<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyPage.aspx.cs" Inherits="MyFirstASPNETApllicaiton.MyPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="txtFirstName" runat="server" MaxLength="10" OnTextChanged="txtFirstName_TextChanged"></asp:TextBox>
        <p>
            <textarea id="txtDescription" runat="server" cols="20" name="S1" rows="2"></textarea></p>
        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
    </form>
</body>
</html>
