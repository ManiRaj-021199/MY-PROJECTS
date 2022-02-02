<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/AdminMasterPage.Master" AutoEventWireup="true" CodeBehind="AdminBlog.aspx.cs" Inherits="WebsiteProject.MasterPages.WebForm2" %>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <link href="../../CSS/ADMIN/AdminBlog.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="adminBlogContainer">
        <div class="adminBlogHeader">
            <h1 class="adminBlogHeaderTitle">Admin Blog</h1>
            <div class="adminBlogHeaderButtons">
                <asp:Button Text="Show My Articles" runat="server" />
                <asp:Button Text="Show All Admin Articles" runat="server" />
                <asp:Button Text="Show All User Articles" runat="server" />
            </div>
        </div>
        <hr />
        <div class="adminBlogFormContainer">
            <div class="adminBlogFormCell">
                <h3 id="warningMsg" runat="server"></h3>
            </div>
            <div class="adminBlogFormCell">
                <label id="blogTitleLabel">Title</label>
                <input id="blogTitle" type="text" title="blogTitleLabel" name="name" for="blogTitleLabel" runat="server" />
            </div>
            <div class="adminBlogFormCell">
                <label id="blogDescriptionLabel">Description</label>
                <textarea id="blogDescription" title="blogDescriptionLabel" rows="5" for="blogDescriptionLabel"  runat="server"></textarea>
            </div>
            <div class="adminBlogFormCell">
                <label id="blogContentLabel">Blog Content</label>
                <textarea id="blogContent" rows="25" title="blogContentLabel" for="blogContentLabel"  runat="server"></textarea>
            </div>
            <div class="adminBlogFormCell">
                <asp:Button ID="SubmitArticle"  Text="Submit Article" runat="server" OnClick="SubmitArticle_Click" />
                <asp:Button ID="ResetArticle" Text="Reset" runat="server" OnClick="ResetArticle_Click" />
            </div>
        </div>
    </div>
</asp:Content>
