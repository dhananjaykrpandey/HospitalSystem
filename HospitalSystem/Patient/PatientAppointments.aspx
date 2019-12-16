<%@ Page Title="" Language="C#" MasterPageFile="~/Doctors.Master" AutoEventWireup="true" CodeBehind="PatientAppointments.aspx.cs" Inherits="HospitalSystem.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>
        &nbsp;Appointment Management</h2>
    <p>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Patient/Appointment/Add.aspx">Add Appointment</asp:HyperLink>
    </p>
    <p>
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Patient/Appointment/Delete.aspx">Cancel Appointment</asp:HyperLink>
    </p>
    <p>
        Your scheduled appointments:</p>
    <p>
        <asp:ListBox ID="ListBoxAppointments" runat="server"></asp:ListBox>
        <br />
    </p>
</asp:Content>
