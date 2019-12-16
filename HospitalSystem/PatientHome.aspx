<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PatientHome.aspx.cs" Inherits="HospitalSystem.PatientHome" %>

<script runat="server">

    protected void btn_SendMessage_Click(object sender, EventArgs e)
    {

    }
</script>

<html>
<head id="Head1" runat="server"><title>E-mail test page</title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <p style="margin-left: 40px">
        <strong style="margin-left: 320px"><span class="auto-style1">Patient Home</span></strong><br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </p>
        <p style="margin-left: 40px">
        <br />
            <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="appointments/view.aspx">View Appointments</asp:HyperLink>
        </p>
        <p style="margin-left: 40px">
            <asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="appointments/add.aspx">Add Appointments </asp:HyperLink>
        <br />
        <br>
            <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="appointments/delete.aspx">Delete Appointment </asp:HyperLink>
            <br />
        <br />
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="Patient/PatientMessages.aspx">Access Medication List/Test Results</asp:HyperLink>
            <br />
        <br />
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="Patient/PatientMessages.aspx">Send Message to Patient</asp:HyperLink>
        </p>
        <p style="margin-left: 40px">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="Doctor/DoctorMessages.aspx">Send Message to Doctor</asp:HyperLink>
        </p>
    </form>
</body>
</html>
