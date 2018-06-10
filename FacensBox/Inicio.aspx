<%@ Page Title="" Language="C#" MasterPageFile="~/InicioMaster.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="FacensBox.Inicio" %>
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
