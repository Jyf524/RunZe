<%@ Page Title="Orders" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Maticsoft.Web.Orders.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script language="javascript" src="/js/CheckBox.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<!--Title -->

            <!--Title end -->

            <!--Add  -->

            <!--Add end -->

            <!--Search -->
            <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>
                    <td style="width: 80px" align="right" class="tdbg">
                         <b>关键字：</b>
                    </td>
                    <td class="tdbg">                       
                    <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSearch" runat="server" Text="查询"  OnClick="btnSearch_Click" >
                    </asp:Button>                    
                        
                    </td>
                    <td class="tdbg">
                    </td>
                </tr>
            </table>
            <!--Search end-->
            <br />
            <asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" CellPadding="3"  OnPageIndexChanging ="gridView_PageIndexChanging"
                    BorderWidth="1px" DataKeyNames="OrderID" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="OrderID" HeaderText="OrderID" SortExpression="OrderID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UserID" HeaderText="UserID" SortExpression="UserID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="OrderDate" HeaderText="OrderDate" SortExpression="OrderDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="OrderState" HeaderText="OrderState" SortExpression="OrderState" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CommodityID" HeaderText="CommodityID" SortExpression="CommodityID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="OrderNumber" HeaderText="OrderNumber" SortExpression="OrderNumber" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="AddresseeName" HeaderText="AddresseeName" SortExpression="AddresseeName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="AddresseeAddress" HeaderText="AddresseeAddress" SortExpression="AddresseeAddress" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="AddresseeZipCode" HeaderText="AddresseeZipCode" SortExpression="AddresseeZipCode" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="AddresseePhone" HeaderText="AddresseePhone" SortExpression="AddresseePhone" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="TotalMoney" HeaderText="TotalMoney" SortExpression="TotalMoney" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PayType" HeaderText="PayType" SortExpression="PayType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Delivery" HeaderText="Delivery" SortExpression="Delivery" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Message" HeaderText="Message" SortExpression="Message" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="OrderImage" HeaderText="OrderImage" SortExpression="OrderImage" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CommodityName" HeaderText="CommodityName" SortExpression="CommodityName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="OrderID" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="OrderID" DataNavigateUrlFormatString="Modify.aspx?id={0}"
                                Text="编辑"  />
                            <asp:TemplateField ControlStyle-Width="50" HeaderText="删除"   Visible="false"  >
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
                                         Text="删除"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                </asp:GridView>
               <table border="0" cellpadding="0" cellspacing="1" style="width: 100%;">
                <tr>
                    <td style="width: 1px;">                        
                    </td>
                    <td align="left">
                        <asp:Button ID="btnDelete" runat="server" Text="删除" OnClick="btnDelete_Click"/>                       
                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
