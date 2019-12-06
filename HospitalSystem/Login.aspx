<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HospitalSystem.ProjectFiles.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <p>
        <br />
    </p>
    <p>
        &nbsp;</p>
    <form id="form1" runat="server">
        <p>
            <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate1">
            </asp:Login>
        </p>
        <div>
        </div>
    </form>
</body>
</html>
