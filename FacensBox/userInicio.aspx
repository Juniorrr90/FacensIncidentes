<%@ Page Title="" Language="C#" MasterPageFile="~/user.Master" AutoEventWireup="true" CodeBehind="userInicio.aspx.cs" Inherits="FacensBox.userInicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div class="jumbotron">
				<h2>
					Olá, <asp:Label ID="lblbemvindo" runat="server"/>
				</h2>
                &nbsp;
				<p>
					O Sistema de Help Desk foi desenvolvido para auxiliar a abertura e controle de chamados.
				</p>
	</div>
</asp:Content>
