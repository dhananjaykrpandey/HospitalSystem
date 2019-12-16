<%@ Page Title="" Language="C#" MasterPageFile="~/Doctors.Master" AutoEventWireup="true" CodeBehind="View.aspx.cs" Inherits="HospitalSystem.XDoctors.Appointments.view" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>
        <br />
        View Appointments</h2>
    <p>
        <asp:ListBox ID="ListBoxAppointments" runat="server"></asp:ListBox>
    </p>
    <p>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/appointment.aspx">Back to Appointment Management</asp:HyperLink>
    </p>
</asp:Content>
