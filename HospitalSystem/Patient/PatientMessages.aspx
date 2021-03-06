﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Doctors.Master" AutoEventWireup="true" CodeBehind="PatientMessages.aspx.cs" Inherits="HospitalSystem.WebForm2" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">

    <p>
        Your Messages:</p>
    <p>
        <asp:ListBox ID="ListBoxMessages" runat="server"></asp:ListBox>
    </p>
    <p>
        &nbsp;</p>
    <asp:Label ID="LabelSentStatus" runat="server"></asp:Label>
    <p>
        Send Message:</p>
    <p>
        Doctor:
        <asp:DropDownList ID="DropDownListPatient" runat="server" OnSelectedIndexChanged="DropDownListPatient_SelectedIndexChanged">
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
    <p>
        <asp:DropDownList ID="DropDownListMessages" runat="server">
        </asp:DropDownList>
    </p>
    <p>
        <asp:Button ID="ButtonDeleteMessage" runat="server" OnClick="ButtonDeleteMessage_Click" Text="Delete Selected Message" />
    </p>
    <p>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Patient/PatientHome.aspx">Return to patient home</asp:HyperLink>
    </p>

</asp:Content>