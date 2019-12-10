<%@ Page Title="" Language="C#" MasterPageFile="~/Doctors.Master" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="HospitalSystem.XDoctors.Appointments.delete" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>
        <br />
        Delete Appointment</h2>
    <p>
        <asp:ListBox ID="ListBoxAppointments" runat="server"></asp:ListBox>
    </p>
    <p>
        <asp:Button ID="ButtonDeleteAppointment" runat="server" OnClick="ButtonDeleteAppointment_Click" Text="Delete Selected Appointment" />
    </p>
    <p>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/appointment.aspx">Back to Appointment Management</asp:HyperLink>
    </p>
</asp:Content>
