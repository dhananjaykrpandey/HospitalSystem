<%@ Page Title="" Language="C#" MasterPageFile="~/Doctors.Master" AutoEventWireup="true" CodeBehind="DoctorAppointments.aspx.cs" Inherits="HospitalSystem.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Appointment Management </h2>
    <p>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Doctor/Appointment/Add.aspx">Add Appointment</asp:HyperLink>
    </p>
    <p>
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Doctor/Appointment/Delete.aspx">Cancel Appointment</asp:HyperLink>
    </p>
    <p>
        Your scheduled appointments:</p>
    <p>
        <asp:ListBox ID="ListBoxAppointments" runat="server"></asp:ListBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Doctor/DoctorHome.aspx">Return to Account Management</asp:HyperLink>
    </p>
</asp:Content>
