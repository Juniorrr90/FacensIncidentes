<%@ Page Title="" Language="C#" MasterPageFile="~/InicioMaster.Master" AutoEventWireup="true" CodeBehind="abrechamado.aspx.cs" Inherits="FacensBox.abrechamado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <div class="jumbotron">
				    <div class="row">
                        <center><H2>Abrir chamado Tecnico</H2></center>
                        <div class="col-md-4">
                            <label for="txtusr">Local</label>
                            <asp:TextBox ID="ue" runat="server" class="form-control"></asp:TextBox>
                            <label for="exampleInputFile">Data Abertura</label>
                            <asp:TextBox ID="dtabertura" runat="server" class="form-control"></asp:TextBox>
                            <label for="txtusr">Estado</label>
                            <asp:TextBox ID="estado" runat="server" class="form-control" Text="Aberto"></asp:TextBox>
                            <label for="txtusr">Usuario</label>
                            <asp:TextBox ID="txtusr2" runat="server" class="form-control"></asp:TextBox>

                        </div>
                        <div class="col-md-8">
                            <label for="exampleInputFile">Problema</label>
                            <asp:TextBox ID="problema" runat="server" class="form-control" Rows="11" TextMode="MultiLine"></asp:TextBox>
                            <label for="txtusr">Foto</label>
                            <asp:FileUpload runat="server" CssClass="form-control" />
                            <asp:Button runat="server" Text="Enviar" CssClass="btn btn-default" ID="btnEnviar" OnClick="btnEnviar_Click"/>
                        </div>
                    </div>
		</div>
</asp:Content>
