<%@ Page Title="" Language="C#" MasterPageFile="~/Doctors.Master" AutoEventWireup="true" CodeBehind="DoctorMessages.aspx.cs" Inherits="HospitalSystem.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        You Messages:</p>
    <p>
        <asp:ListBox ID="ListBoxMessages" runat="server"></asp:ListBox>
    </p>
    <p>
        &nbsp;</p>
    <asp:Label ID="LabelSentStatus" runat="server"></asp:Label>
    <p>
        Send Message:</p>
    <p>
        Patient:
        <asp:DropDownList ID="DropDownListPatient" runat="server">
        </asp:DropDownList>
    </p>
    <p>
        Message:</p>
    <p>
        <asp:TextBox ID="TextBoxMessageContent" runat="server" Height="107px" TextMode="MultiLine" Width="445px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="ButtonSendMessage" runat="server" OnClick="ButtonSendMessage_Click" Text="Send Message" />
    </p>
</asp:Content>
