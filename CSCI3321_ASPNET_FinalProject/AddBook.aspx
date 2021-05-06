<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddBook.aspx.cs" Inherits="CSCI3321_ASPNET_FinalProject.AddBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
		<div class="col-md-12">
			<h3>Add Book</h3>
		</div>
	</div>

	<div class="row">
		<div class="col-md-3">
			Book Title:
		</div>
		<div class="col-md-9">
			<asp:TextBox ID="txtBooktitle" runat="server" CssClass="form-control"></asp:TextBox>
		</div>

		<div class="col-md-3">
			Author:
		</div>
		<div class="col-md-9">
		    <asp:DropDownList ID="ddlAuthor" runat="server" DataSourceID="sqlAuthors" DataTextField="FullName" DataValueField="AuthorID">
            </asp:DropDownList>
            <asp:SqlDataSource ID="sqlAuthors" runat="server" ConnectionString="<%$ ConnectionStrings:DBConnectionString %>" ProviderName="<%$ ConnectionStrings:DBConnectionString.ProviderName %>" SelectCommand="SELECT AuthorID FROM Authors
SELECT FirstName + ' ' + LastName AS FullName From AUTHORS"></asp:SqlDataSource>
		</div>

		<div class="col-md-3">
			Price:
		</div>
		<div class="col-md-9">
			<asp:TextBox ID="txtPrice" runat="server" CssClass="form-control"></asp:TextBox>
		</div>

		<div class="col-md-3">
			Publish Date:
		</div>
		<div class="col-md-9">
			<asp:TextBox ID="txtPublishdate" runat="server" CssClass="form-control"></asp:TextBox>
		</div>

		<div class="col-md-3">
			Publisher:
		</div>
		<div class="col-md-9">
		    <asp:DropDownList ID="ddlPublishers" runat="server" DataSourceID="sqlPublishers" DataTextField="PublisherName" DataValueField="PublisherID">
            </asp:DropDownList>
            <asp:SqlDataSource ID="sqlPublishers" runat="server" ConnectionString="<%$ ConnectionStrings:DBConnectionString %>" ProviderName="<%$ ConnectionStrings:DBConnectionString.ProviderName %>" SelectCommand="SELECT PublisherID, PublisherName FROM Publishers"></asp:SqlDataSource>
		</div>

		<div class="col-md-3">
			Genre:
		</div>
		<div class="col-md-9">
		    <asp:DropDownList ID="ddlGenres" runat="server" DataSourceID="sqlGenres" DataTextField="GenreName" DataValueField="GenreID">
            </asp:DropDownList>
            <asp:SqlDataSource ID="sqlGenres" runat="server" ConnectionString="<%$ ConnectionStrings:DBConnectionString %>" ProviderName="<%$ ConnectionStrings:DBConnectionString.ProviderName %>" SelectCommand="SELECT Genres.* FROM Genres"></asp:SqlDataSource>
		</div>
	</div>
</asp:Content>
