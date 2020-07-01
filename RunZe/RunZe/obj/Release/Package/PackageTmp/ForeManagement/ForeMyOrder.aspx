<%@ Page Title="我的订单" Language="C#" MasterPageFile="~/ForeManagement/ForeManagement.Master" AutoEventWireup="true" CodeBehind="ForeMyOrder.aspx.cs" Inherits="RunZe.ForeManagement.ForeMyOrder" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/ForeMyOrder.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div id="content_k">
        <div class="content_nav_kk">
            <div class="content_nav">
                <div class="content_nav_word">              
                    我的订单
                </div>
            </div>
        </div>  
        <div class="content_k2">
            <div id="content">
                <table class="content_list_table_k" style="border-spacing: 0; padding: 0; border: 0;">
                    <tr>
                        <td style="width: 140px;">订单号</td>
                        <td style="width: 120px;">合计金额</td>
                        <td style="width: 110px;">收货人</td>
                        <td style="width: 120px;">订货人</td>
                        <td style="width: 120px;">订购日期</td>
                        <td style="width: 120px;">订单状态</td>
                        <td style="width: 120px;">操作</td>
                    </tr>
                </table>
               <telerik:RadListView ID="RadListView1" DataKeyNames="OrderID" runat="server" AllowPaging="true" PageSize="10" OnItemCommand="RadListView1_ItemCommand" OnNeedDataSource="RadListView1_NeedDataSource" OnItemDataBound="RadListView1_ItemDataBound" >
                    <ItemTemplate>
                        <table class="content_list_table" style="border-spacing: 0; padding: 0; border: 0; font-size: 14px;">
                            <tr>
                                <td style="width: 200px;">
                                    <a href="ForeOrderShow.aspx?OrderID=<%#Eval ("OrderID") %>"><%#Eval ("OrderID") %>
                                </td>
                                <td style="width: 200px;">
                                  <%#Eval ("TotalMoney") %>
                                </td>
                                <td style="width: 200px;">
                                  <%#Eval ("AddresseeName") %>
                                </td>
                                <td style="width: 200px;">
                                  <%#Eval ("UserID") %>
                                </td>
                                <td style="width: 200px;">
                                  <%#Eval ("OrderDate") %>
                                </td>
                                <td style="width: 200px;">
                                  <%#Eval ("OrderState") %>
                                </td>
                                <td style="width: 200px;">
                                  <asp:LinkButton ID="LinkBtn_Pay" runat="server" CssClass="list_table_a" CommandName="Pay" CommandArgument='<%#Eval("OrderID") %>'>付款</asp:LinkButton>
                                  <asp:LinkButton ID="LinkBtn_Cancel" runat="server" CssClass="list_table_a" CommandName="Cancel" CommandArgument='<%#Eval("OrderID") %>'>取消</asp:LinkButton>
                                  <asp:LinkButton ID="LinkBtn_Hurry" runat="server" CssClass="list_table_a" CommandName="Hurry" CommandArgument='<%#Eval("OrderID") %>'>催单</asp:LinkButton>
                                  <asp:LinkButton ID="LinkBtn_Check" runat="server" CssClass="list_table_a" CommandName="Check" CommandArgument='<%#Eval("OrderID") %>'>确认收货</asp:LinkButton>
                                  <asp:LinkButton ID="LinBtn_Score" runat="server" CssClass="list_table_a" CommandName="Score" CommandArgument='<%#Eval("OrderID") %>'>无</asp:LinkButton>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                    <EmptyDataTemplate>
                        <asp:Image ID="Image2" runat="server" ImageUrl="~/image/none.png" />
                    </EmptyDataTemplate>
                </telerik:RadListView>
                <div class="content_fy">
                    <table style="margin: auto">
                        <tr>
                            <td>
                                <telerik:RadDataPager ID="RadDataPager1" runat="server" PageSize="10" PagedControlID="RadListView1" Skin="Metro">
                                    <Fields>
                                        <telerik:RadDataPagerButtonField FieldType="FirstPrev" FirstButtonText="首页" PrevButtonText="上一页" />
                                        <telerik:RadDataPagerButtonField FieldType="Numeric" />
                                        <telerik:RadDataPagerButtonField FieldType="NextLast" LastButtonText="尾页" NextButtonText="下一页" />
                                    </Fields>
                                </telerik:RadDataPager>
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
