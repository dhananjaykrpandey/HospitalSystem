<%@ Page Title="" Language="C#" MasterPageFile="~/Doctors.Master" AutoEventWireup="true" CodeBehind="PatientMedications.aspx.cs" Inherits="HospitalSystem.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Medications:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:ListBox ID="ListBox1" runat="server" Height="113px" Width="291px"></asp:ListBox>
    </p>
    <p>
        Tests:</p>
    <p>
        <asp:ListBox ID="ListBox2" runat="server" Height="111px" Width="284px"></asp:ListBox>
    </p>
</asp:Content>
