<%@ Page Title="" Language="C#" MasterPageFile="~/Doctors.Master" AutoEventWireup="true" CodeBehind="Patients.aspx.cs" Inherits="HospitalSystem.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="View all Patients" />
    <br />
    <br />
    Search for Patients<br />
    ID:
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Search by ID" />
    <br />
    First Name:
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
    Last Name:
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Search by Name" />
    <br />
    <br />
    <asp:ListBox ID="ListBox1" runat="server" Height="121px" Width="1035px"></asp:ListBox>
    <br />
    <br />
<br />
    <br />
</asp:Content>
