<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="appointment.aspx.cs" Inherits="HospitalSystem.appointment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Appointments</h2>
    <p>
        &nbsp;</p>
    <p>
        Manage your appointments:</p>
    <p>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/appointments/view.aspx">View</asp:HyperLink>
    </p>
    <p>
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/appointments/add.aspx">Add</asp:HyperLink>
    </p>
    <p>
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/appointments/delete.aspx">Delete</asp:HyperLink>
    </p>
</asp:Content>
