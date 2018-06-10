<%@ Page Title="" Language="C#" MasterPageFile="~/InicioMaster.Master" AutoEventWireup="true" CodeBehind="cad_user.aspx.cs" Inherits="FacensBox.cad_user" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <div class="row">
            <center><H2>Novo usuario</H2></center>
            <div class="col-md-4">
                <label for="txtusr">Nome</label>
                <asp:TextBox ID="nome" runat="server" class="form-control"></asp:TextBox>
                <label for="exampleInputFile">Username</label>
                <asp:TextBox ID="username" runat="server" class="form-control"></asp:TextBox>
                <label for="exampleInputFile">Senha</label>
                <asp:TextBox ID="password" runat="server" class="form-control" TextMode="Password"></asp:TextBox>
                <label for="exampleInputFile">E-mail</label>
                <asp:TextBox ID="email" runat="server" class="form-control" TextMode="Email"></asp:TextBox>
                <label for="txtusr">Unidade Escolar</label>
                <asp:DropDownList ID="ddlunidade" runat="server" class="form-control"></asp:DropDownList>
                <label for="txtusr">Nivel de acesso</label>
                <asp:TextBox ID="nivel" runat="server" class="form-control" TextMode="Number"></asp:TextBox>
                <br/>
                <asp:Button runat="server" Text="Cadastrar" CssClass="btn btn-default" ID="btnEnviar" OnClick="btnEnviar_Click" />
            </div>
            <div class="col-md-8">
                <dl class="dl-horizontal">
                <dt>
					Nivel 0
				</dt>
				<dd>
					Administração - Acesso Total ao Sistema.
				</dd>
				<dt>
					Nivel 1
				</dt>
				<dd>
					Tecnicos - Acesso aos chamados e relatórios.
				</dd>
				<dt>
					Nivel 2
				</dt>
				<dd>
					Usuários - Acesso a abertura de chamados.
				</dd>
			</dl>
            </div>
        </div>
    </div>
</asp:Content>
