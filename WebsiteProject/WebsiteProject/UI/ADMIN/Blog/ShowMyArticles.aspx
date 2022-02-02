<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="ShowMyArticles.aspx.cs" Inherits="WebsiteProject.MasterPages.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="gvShowAllArticles" runat="server" AutoGenerateColumns="false">
        <Columns> 
            <asp:TemplateField HeaderText="Title">
                <ItemTemplate>
                    <asp:Label ID="lblTitle" Text='<% #Eval("Title") %>' runat="server"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Description">
                <ItemTemplate>
                    <asp:Label ID="lblDescription" Text='<% #Eval("Description") %>' runat="server"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Edit Article">
                <ItemTemplate>
                    
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Delete Article">
                <ItemTemplate>
                    
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
