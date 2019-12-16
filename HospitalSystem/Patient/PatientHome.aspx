<%@ Page Title="" Language="C#" MasterPageFile="~/Doctors.Master" AutoEventWireup="true" CodeBehind="PatientHome.aspx.cs" Inherits="HospitalSystem.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Patient/PatientAppointments.aspx">Managed your scheduled appointments</asp:HyperLink>
    <br />
    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Patient/PatientMedications.aspx">Manage your medications</asp:HyperLink>
    <br />
    <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Patient/PatientMessages.aspx">Manage your messages</asp:HyperLink>
</asp:Content>
