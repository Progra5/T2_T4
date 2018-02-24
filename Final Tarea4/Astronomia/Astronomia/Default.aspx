<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Astronomia._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Universo</title>
    <link type="text/css" href="css/style.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style4 {
            width: 380px;
            height: 26px;
        }
        .auto-style6 {
            width: 332px;
        }
        .auto-style16 {
            width: 203px;
        }
        .auto-style18 {
            width: 164px;
            height: 26px;
        }
        #tabla {
            margin-left: 416px;
        }
        .auto-style21 {
            width: 164px;
        }
        .auto-style23 {
            width: 380px;
        }
        .auto-style24 {
            width: 176px;
        }
        .auto-style25 {
            width: 270px;
        }
    </style>
</head>
<body>
    <div class="parallax">
        <p><br /></p>
</div>
    <div id="contenedor">
        
        <form id="form1" runat="server" style="margin-left=10px;">
            <%--<div id="cabecera">
                <ul id="nav">
                    <li title="Registro" runat="server">Registrar Cuerpos Celestes</li>
                    <li title="Asociar" runat="server">Registrar Cuerpos Celestes</li>
                    <li title="" runat="server">Registrar Cuerpos Celestes</li>
                </ul>
            </div>--%>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Registrar Cuerpos Celestes" Width="250px" Height="45px" Font-Size="10pt" style="opacity:1; margin-right: 10px; margin-left: 37px;" Font-Bold="True" BackColor="Black" BorderStyle="None" ForeColor="White" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Asociar cuerpos" Height="45px" style="margin-left: 0px; margin-right: 10px" Width="250px" Font-Bold="True" BackColor="Black" BorderStyle="None" Font-Size="10pt" ForeColor="White" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Insertar tipos asosiación" Height="45px" Width="250px" Font-Bold="True" BackColor="Black" BorderStyle="None" Font-Size="10pt" ForeColor="White" />
        
            <asp:MultiView runat="server" ID="MultiView1" ActiveViewIndex="0">
                <asp:View ID="View1" runat="server">
                    <div class="col-sm-12">
                        <div><p><br /><br /></p></div>
                        <h3 class="header blue lighter smaller">
                            <i class="ace-icon fa fa-check-square smaller-90"></i>
                            Registro de cuerpos celestes
                        </h3>
                        <div><p><br /></p></div>
                        <table style="margin-left: 380px">
                            <tr>
                                <td align="right" class="auto-style18">Nombre: </td>
                                <td class="auto-style4" align="left">
                                    <asp:TextBox ID="txtnombre" runat="server" style="margin-left: 90px"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td class="auto-style21" align="right">Fue descubierto por: </td>
                                <td align="left" class="auto-style23">
                                    <asp:TextBox ID="txtDescubridor" runat="server" style="margin-left:90px;"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td class="auto-style21">
                                    <br />
                                </td>
                            </tr>
                            <tr style="align-items:center";>
                                <td class="auto-style21" align="right">Fotografia:</td>
                                <td align="left"; class="auto-style23" >
																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																																											<asp:Label id="Label1" runat="server" AssociatedControlID="fileUploader1" Text="Seleccionar una imagen:" />
                                    &nbsp;<br />
                                    <br />
                                    &nbsp;<asp:FileUpload ID="fileUploader1" runat="server" style="margin-left: 89px" Width="233px"/>
                                    <br />
                                    <br />
                                    <asp:Button ID="cargarImagen" runat="server"
                                        Text="Cargar imágenes" OnClick="cargarImagenes_Click" style="margin-left: 93px" />
                                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                                </td>
                            </tr>
                        </table>

                    </div>
                    <asp:Panel ID="Panel1" runat="server" Width="1000px">
                        <br />
                        <br />
                        <br />
                        <br />
                    </asp:Panel>
                </asp:View>
                <asp:View ID="View2" runat="server">
                
                    <div class="col-sm-12">
                        <h3 class="header blue lighter smaller">
                            &nbsp;</h3>
                            <h3 class="header blue lighter smaller">Asociar cuerpos celestes </h3>
                        <p class="header blue lighter smaller">
                            &nbsp;</p>
                            <table id="tabla">
                                <tr>
                                    <td align="right" class="auto-style16">Cuerpos celestes</td>
                                    <td class="auto-style6">
                                        <br />
                                        <asp:DropDownList ID="ddlCuerposCelestes1" runat="server" Width="150px"></asp:DropDownList>
                                        <br />
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" class="auto-style16">Tipo de relacion</td>
                                    <td class="auto-style6">
                                        <br />
                                        <asp:DropDownList ID="ddlTipoRelacion" runat="server" Width="150px"></asp:DropDownList>
                                        <br />
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" class="auto-style16">Cuerpos celestes</td>
                                    <td class="auto-style6">
                                        <br />
                                        <asp:DropDownList ID="ddlCuerposCelestes2" runat="server" Width="150px"></asp:DropDownList>
                                        <br />
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2">
                                        <br />
                                        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                                        <br />
                                        <asp:Button ID="btnAsociar" runat="server" Text="Asociar" OnClick="btnAsociar_Click" /></td>
                                </tr>
                            </table>
                        </div>
                    <asp:Panel ID="Panel2" runat="server" Width="1000px">
                        <br />
                        <br />
                        <br />
                        <br />
                    </asp:Panel>

                </asp:View>
                <asp:View ID="View3" runat="server">
                    <div class="col-sm-12">
                        <h3 class="header blue lighter smaller">
                            &nbsp;</h3>
                        
                            <h3 class="header blue lighter smaller">Asociar cuerpos celestes</h3>
                        <h3 class="header blue lighter smaller">&nbsp;</h3>
                        
                            <table style="text-align:right; margin-left: 414px;">
                                <tr>
                                    <td class="auto-style24">Insertar tipo de relaci&oacute;n</td>
                                    <td class="auto-style25"><asp:TextBox ID="txtTipoRelacion" runat="server"></asp:TextBox>
                                        <br />
                                        <br />
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2"><asp:Button ID="btnInsertarTipo" runat="server" Text="Insertar" OnClick="btnInsertarTipo_Click" />
                                        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                                        <br />
                                    </td>
                                </tr>
                            </table>
                        <asp:Panel ID="Panel3" runat="server" Width="1000px">
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                        </asp:Panel>
                        </div>
                </asp:View>
            </asp:MultiView>    
        </form>
    </div>
    <div class="parallax1">
        <p><br /></p>
    </div>
</body>


</html>

