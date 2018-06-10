<%@ Page Title="" Language="C#" MasterPageFile="~/tec.Master" AutoEventWireup="true" CodeBehind="tecchamadosfechados.aspx.cs" Inherits="FacensBox.tecchamadosfechados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div class="jumbotron"> 
        <div class="container">
          <h2>Chamados Encerrados</h2>                                                                                   
          <div class="table-responsive">          
          <table class="table">
            <thead>
              <tr>
                <th>Codigo</th>
                <th>Unidade</th>
                <th>Data Abertura</th>
                <th>Data Encerramento</th>
                <th>Problema</th>
              </tr>
            </thead>
            <tbody>
              <tr>
                <td>1</td>
                <td>FACENS</td>
                <td>15/01/2017</td>
                <td>20/01/2017</td>
                <td>Teste</td>
                <td><asp:Button runat="server" ID="Button1" Text="Imprimir" /></td>
              </tr>
            </tbody>
          </table>
          </div>
        </div>
    </div>
</asp:Content>
