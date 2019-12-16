<%@ Page Title="" Language="C#" MasterPageFile="~/Doctors.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="HospitalSystem.XPatients.Appointments.add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>
        <br />
        Add Appointment</h2>
    <p>
        Doctor</p>
    <p>
        <asp:DropDownList ID="DropDownListPatients" runat="server">
        </asp:DropDownList>
    </p>
    <p>
        <asp:Label ID="LabelPatientSelected" runat="server" Text="Please select a doctor."></asp:Label>
    </p>
    <p>
        Department:
        <asp:TextBox ID="TextBoxDepartment" runat="server"></asp:TextBox>
    </p>
    <p>
        Date:</p>
    <p>
        <asp:Calendar ID="CalendarAppointmentDateSelector" runat="server"></asp:Calendar>
    </p>
    <p>
        Time:</p>
    <p>
        <asp:DropDownList ID="DropDownListTimeHour" runat="server">
            <asp:ListItem>01</asp:ListItem>
            <asp:ListItem>02</asp:ListItem>
            <asp:ListItem>03</asp:ListItem>
            <asp:ListItem>04</asp:ListItem>
            <asp:ListItem>05</asp:ListItem>
            <asp:ListItem>06</asp:ListItem>
            <asp:ListItem>07</asp:ListItem>
            <asp:ListItem>08</asp:ListItem>
            <asp:ListItem>09</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
            <asp:ListItem>11</asp:ListItem>
            <asp:ListItem>12</asp:ListItem>
        </asp:DropDownList>
        :<asp:DropDownList ID="DropDownListTimeMinute" runat="server">
            <asp:ListItem>00</asp:ListItem>
            <asp:ListItem>30</asp:ListItem>
        </asp:DropDownList>
&nbsp;<asp:DropDownList ID="DropDownListTimeHemi" runat="server">
            <asp:ListItem>AM</asp:ListItem>
            <asp:ListItem>PM</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        Purpose for visit:</p>
    <p>
        <asp:TextBox ID="TextBoxPurpose" runat="server" Height="114px" Width="399px" TextMode="MultiLine"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="LabelAddStatus" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Button ID="ButtonAddAppointment" runat="server" OnClick="ButtonAddAppointment_Click" Text="Add Appointment" />
    </p>
    <p>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Doctor/DoctorAppointments.aspx">Back to Appointment Management</asp:HyperLink>
    </p>
</asp:Content>
