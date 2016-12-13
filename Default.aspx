<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GETnPOST.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Get N Post</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <br /><br />
        Type of http context / Type of request from Client : <asp:Label Text="" id="lblRequestType" runat="server" />
        <br /><br />
        <asp:Button Text="Click here" runat="server" ID="btnClickHere" OnClick="btnClickHere_Click" />
    </div>
    </form>
</body>
</html>
