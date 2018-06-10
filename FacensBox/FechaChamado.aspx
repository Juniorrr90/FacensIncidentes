<%@ Page Title="" Language="C#" MasterPageFile="~/InicioMaster.Master" AutoEventWireup="true" CodeBehind="FechaChamado.aspx.cs" Inherits="FacensBox.FechaChamado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
				    <div class="row">
                        <center><H2>Encerrar chamado Tecnico</H2></center>
                        <div class="col-md-4">
                            <label for="txtusr">Nome UE</label>
                            <asp:TextBox ID="ue" runat="server" class="form-control"></asp:TextBox>
                            <label for="exampleInputFile">Data Abertura</label>
                            <asp:TextBox ID="dtabertura" runat="server" class="form-control" TextMode="Date"></asp:TextBox>
                            <label for="exampleInputFile">Data Encerramento</label>
                            <asp:TextBox ID="dtencerramento" runat="server" class="form-control" TextMode="Date"></asp:TextBox>
                            <label for="txtusr">Estado</label>
                            <asp:DropDownList ID="ddlestado" runat="server" class="form-control"></asp:DropDownList>
                            <label for="txtusr">Usuario</label>
                            <asp:TextBox ID="txtusr2" runat="server" class="form-control"></asp:TextBox>
                            <label for="txtusr">Tecnico</label>
                            <asp:TextBox ID="txtusr" runat="server" class="form-control"></asp:TextBox>
                        </div>
                        <div class="col-md-8">
                            <label for="exampleInputFile">Solucao</label>
                            <asp:TextBox ID="Solucao" runat="server" class="form-control" Rows="11" TextMode="MultiLine"></asp:TextBox>

                            <asp:Button runat="server" Text="Atualizar" CssClass="btn btn-default" ID="btnEnviar" OnClick="btnEnviar_Click"/>
                        </div>
                    </div>
		</div>
</asp:Content>
