<%@ Page Title="SHD" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FacensBox._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
    <div class="row">
        <div class="col-md-8">
                <h1>FACENS Incidentes</h1>
                <p class="lead">Sistema de Help Desk, uma ferramenta para auxiliar a abertura e controle de chamados.&nbsp;&nbsp;&nbsp;</p>
        </div>
        <div class="col-md-4">
                <p>Acessar o Sistema</p>
                <p>
                    <asp:TextBox ID="loginusername" class="form-control" placeholder="Username" runat ="server"></asp:TextBox>
                </p>
                <p>
                    <asp:TextBox ID="loginpassword" class="form-control" placeholder="Senha" runat="server" TextMode="Password"></asp:TextBox>
                </p>
                <p>
                    <asp:Button runat="server" Text="Entrar" CssClass="btn btn-default" ID="btnLogin" OnClick="btnLogin_Click"/>
                &nbsp;
                    <a class="btn" id="modal-775041" role="button" href="#modal-container-775041" data-toggle="modal">Esqueceu sua senha?</a>
			
			<div class="modal fade" id="modal-container-775041" role="dialog" aria-hidden="true" aria-labelledby="myModalLabel">
				<div class="modal-dialog">
					<div class="modal-content">
						<div class="modal-header">
							<button class="close" aria-hidden="true" type="button" data-dismiss="modal">
								×
							</button>
							<h4 class="modal-title" id="myModalLabel">
								Recuperar sua senha
							</h4>
						</div>
						<div class="modal-body">
							<asp:TextBox ID="txtrecsenha" class="form-control" runat="server" placeholder="Insira seu email"></asp:TextBox>
                            <asp:Label ID="lblerro" runat="server" Text="E-mail não encontrado!" Visible="False"></asp:Label>
						</div>
						<div class="modal-footer">
							<button class="btn btn-default" type="button" data-dismiss="modal">
								Cancelar
							</button> 
							<asp:Button cssclass="btn btn-primary" Text="Enviar" runat="server" type="button" ID="btnRec" OnClick="btnRec_Click">
								
							</asp:Button>
						</div>
					</div>
				</div>
			</div>
               </p>
                <p>
                    &nbsp;</p>
        </div>
    </div>
    </div>

</asp:Content>
