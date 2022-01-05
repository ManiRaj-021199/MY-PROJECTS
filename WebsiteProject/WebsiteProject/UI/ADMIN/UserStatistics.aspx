<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="UserStatistics.aspx.cs" Inherits="WebsiteProject.MasterPages.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../CSS/ADMIN/UserStatistics.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="gvAuthorsListTable" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:TemplateField HeaderText="Name">
                <ItemTemplate>
                    <asp:Label ID="lblName" Text='<% #Eval("Name") %>' runat="server"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="EMail">
                <ItemTemplate>
                    <asp:Label ID="lblEMail" Text='<% #Eval("EMail") %>' runat="server"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Post Count">
                <ItemTemplate>
                    <asp:Label ID="lblPostCount" Text='<% #Eval("PostCount") %>' runat="server"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Followers Count">
                <ItemTemplate>
                    <asp:Label ID="lblFollowersCount" Text='<% #Eval("FollowerCount") %>' runat="server"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Total Reports">
                <ItemTemplate>
                    <asp:Label ID="lblReports" Text='<% #Eval("TotalReports") %>' runat="server"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
