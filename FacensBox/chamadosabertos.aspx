<%@ Page Title="" Language="C#" MasterPageFile="~/InicioMaster.Master" AutoEventWireup="true" CodeBehind="chamadosabertos.aspx.cs" Inherits="FacensBox.chamadosabertos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <div class="container">
            <h2>Chamados Abertos</h2>
            <div class="table-responsive">
                <asp:Repeater ID="rptCustomers" runat="server" OnItemCommand="rptCustomers_ItemCommand">
                    <HeaderTemplate>
                        <table class="table">
                            <tr>
                                <th scope="col" style="width: 5%">Codigo
                                </th>
                                <th scope="col" style="width: 15%">Local
                                </th>
                                <th scope="col" style="width: 15%">Data Abertura
                                </th>
                                <th scope="col" style="width: 55%">Problema
                                </th>
                                  <th scope="col" style="width: 10%">
                                </th>
                            </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td>
                                <asp:Label ID="lblId" runat="server" Text='<%# Eval("Id") %>' />
                            </td>
                            <td>
                                <asp:Label ID="lblUnidade" runat="server" Text='<%# Eval("Unidade") %>' />
                            </td>
                            <td>
                                <asp:Label ID="lblData" runat="server" Text='<%# Eval("DataAbertura") %>' />
                            </td>
                            <td>
                                <asp:Label ID="lblProblema" runat="server" Text='<%# Eval("Problema") %>' />
                            </td>
                            <td>
                                <asp:LinkButton ID="btnImprimir" runat="server" Text="Imprimir" CommandArgument='<%# DataBinder.Eval(Container.DataItem, "Id") %>' />
                            </td>
                        </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        </table>
                    </FooterTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
</asp:Content>
