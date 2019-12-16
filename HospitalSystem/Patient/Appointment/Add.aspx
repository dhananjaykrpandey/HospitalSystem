<%@ Page Title="" Language="C#" MasterPageFile="~/Patients.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="HospitalSystem.XPatients.Appointments.add" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>
        <br />
        Add Appointment</h2>
    <p>
        <asp:Label ID="LabelDesiredAppointee" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        Date:</p>
    <p>
        <asp:Calendar ID="CalendarAppointmentDateSelector" runat="server"></asp:Calendar>
    </p>
    <p>
        Time:</p>
    <p>
        &nbsp;</p>
    <p>
        Purpose for visit:</p>
    <p>
        <asp:TextBox ID="TextBox1" runat="server" Height="114px" Width="399px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="ButtonAddAppointment" runat="server" OnClick="ButtonAddAppointment_Click" Text="Add Appointment" />
    </p>
    <p>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/appointment.aspx">Back to Appointment Management</asp:HyperLink>
    </p>
</asp:Content>
