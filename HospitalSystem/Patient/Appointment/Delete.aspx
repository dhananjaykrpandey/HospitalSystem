<%@ Page Title="" Language="C#" MasterPageFile="~/Doctors.Master" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="HospitalSystem.XPatients.Appointments.delete" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>
        <br />
        Cancel Appointment</h2>
    <p>
        <asp:DropDownList ID="DropDownListAppointments" runat="server">
        </asp:DropDownList>
    </p>
    <p>
        <asp:Label ID="LabelDeleteStatus" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Button ID="ButtonDeleteAppointment" runat="server" OnClick="ButtonDeleteAppointment_Click" Text="Cancel Selected Appointment" />
    </p>
    <p>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Patient/PatientAppointments.aspx">Back to Appointment Management</asp:HyperLink>
    </p>
</asp:Content>
