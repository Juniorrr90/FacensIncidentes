<%@ Page Title="" Language="C#" MasterPageFile="~/InicioMaster.Master" AutoEventWireup="true" CodeBehind="cad_ue.aspx.cs" Inherits="FacensBox.cad_ue" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
				    <div class="row">
                        <center><H2>Cadastro Local</H2></center>
                    <div class="col-md-4">
                        
                        <label for="txtusr">Nome UE</label>
                        <asp:TextBox ID="nome" runat="server" class="form-control"></asp:TextBox>
                        <label for="exampleInputFile">Endereco</label>
                        <asp:TextBox ID="end" runat="server" class="form-control"></asp:TextBox>
                        <label for="exampleInputFile">Bairro</label>
                        <asp:TextBox ID="bairro" runat="server" class="form-control"></asp:TextBox>
                        <label for="exampleInputFile">E-mail</label>
                        <asp:TextBox ID="email" runat="server" class="form-control" TextMode="Email"></asp:TextBox>
                        <label for="txtusr">Telefone</label>
                        <asp:TextBox ID="telefone" runat="server" class="form-control"></asp:TextBox>
                        <label for="txtusr">Codigo CIE</label>
                        <asp:TextBox ID="codcie" runat="server" class="form-control"></asp:TextBox>
                        <br/>
                        <asp:Button runat="server" Text="Cadastrar" CssClass="btn btn-default" ID="btnEnviar" OnClick="btnEnviar_Click"/>
                    </div>
                    </div>
		</div>
</asp:Content>
