<%@ Page Title="Categorias" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="rCategorias.aspx.cs" Inherits="Categorias.UI.Registros.rCategorias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="form-row">
        <%--CategoriaId--%>
        <div class="form-group col-md-3">
            <asp:Label Text="Categoria Id" class="text-primary" runat="server" />
            <asp:TextBox ID="CategoriaIdTextBox" class="form-control input-group" TextMode="Number" placeholder="0" runat="server" />
        </div>        

        <%--Boton--%>
        <div class="col-lg-1 p-0">
            <asp:LinkButton ID="BuscarLinkButton" CssClass="btn btn-outline-info mt-4" runat="server" >
                <span class="fas fa-search"></span>
                     Buscar
            </asp:LinkButton>
        </div>
    </div>

    <div class="form-row">
        <%--Descripcion--%>
        <div class="form-group col-md-3">
            <asp:Label Text="Descripcion" runat="server" />
            <asp:TextBox ID="DescripcionTextBox" class="form-control input-group" runat="server" />
        </div>
    </div>

    <div class="form-row">
        <%--Presupuesto--%>
        <div class="form-group col-md-3">
            <asp:Label Text="Presupuesto" runat="server" />
            <asp:TextBox ID="PresupuestoTextBox" TextMode="Number" class="form-control input-group" runat="server" />
        </div>
    </div>
            

    <asp:Label ID="MensajeLabel" runat="server" Text=""></asp:Label>

    <%--Botones--%>
    <div class="panel-footer">
        <div class="text-center">
            <div class="form-group" style="display: inline-block">
                <asp:Button Text="Nuevo" class="btn btn-outline-info btn-md" runat="server" ID="NuevoButton"  />
                <asp:Button Text="Guardar" class="btn btn-outline-success btn-md" runat="server" ID="GuadarButton"  />
                <asp:Button Text="Eliminar" class="btn btn-outline-danger btn-md" runat="server" ID="EliminarButton"  />

            </div>
        </div>
    </div>




</asp:Content>
