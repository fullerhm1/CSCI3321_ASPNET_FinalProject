<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddPublishers.aspx.cs" Inherits="CSCI3321_ASPNET_FinalProject.AddPublishers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div class="row">
		<div class="col-md-12">
			<h3>New Publisher</h3>
		</div>
	</div>

	<div class="row">
		<div class="col-md-3">
			Publisher Name:
		</div>
		<div class="col-md-9">
			<asp:TextBox ID="txtPublishname" runat="server" CssClass="form-control"></asp:TextBox>
		</div>

		<div class="col-md-3">
			Address:
		</div>
		<div class="col-md-9">
			<asp:TextBox ID="txtAddress" runat="server" CssClass="form-control"></asp:TextBox>
		</div>

		<div class="col-md-3">
			City:
		</div>
		<div class="col-md-9">
			<asp:TextBox ID="txtCity" runat="server" CssClass="form-control"></asp:TextBox>
		</div>

		<div class="col-md-3">
			Postal Code:
		</div>
		<div class="col-md-9">
			<asp:TextBox ID="txtPostcode" runat="server" CssClass="form-control"></asp:TextBox>
		</div>

		<div class="col-md-3">
			Country:
		</div>
		<div class="col-md-9">
			<asp:TextBox ID="txtCountry" runat="server" CssClass="form-control"></asp:TextBox>
		</div>

		<div class="col-md-3">
			Phone:
		</div>
		<div class="col-md-9">
			<asp:TextBox ID="txtPhone" runat="server" CssClass="form-control"></asp:TextBox>
		</div>

		<div class="col-md-12">
			<asp:Button ID="btnAddPublisher" runat="server" Text="Add Publisher" OnClick="btnAddPublisher_Click" />
		</div>
	</div>
</asp:Content>
