<%@ Page Title="" Language="C#" MasterPageFile="~/Doctors.Master" AutoEventWireup="true" CodeBehind="doctor.aspx.cs" Inherits="HospitalSystem.doctor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Doctor Management Page</h2>
    <p>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/appointment.aspx">Appointment Management</asp:HyperLink>
    </p>
    <p>
        <asp:Image ID="Image1" runat="server" Height="263px" ImageUrl="~/res/doctors.jpng.jpg" Width="822px" />
    </p>
</asp:Content>
