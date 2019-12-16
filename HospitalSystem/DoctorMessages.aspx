<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DoctorMessages.aspx.cs" Inherits="HospitalSystem.DoctorMessages" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
            text-decoration: underline;
            margin-left: 440px;
        }
        .auto-style2 {
            font-size: large;
        }
    </style>
</head>
<body>
    <p>
        <span class="auto-style1"><strong>Doctor Messages </strong></span>
    </p>
    <form id="form1" runat="server">
        <p class="auto-style2">
            Select Patient </p>
        <p>
            <asp:ListBox ID="ListBox1" runat="server" Height="79px" Width="110px"></asp:ListBox>
        </p>
        <p>
            <br class="auto-style2">
            <span class="auto-style2">Message body:</span><br/>
        <asp:textbox id="txtBody" runat="server" height="150px" textmode="multiline" />
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Send Message" />
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" Text="Delete Message" />
        <br />
        <br />
        </p>
        <div>
        </div>
    </form>
</body>
</html>
