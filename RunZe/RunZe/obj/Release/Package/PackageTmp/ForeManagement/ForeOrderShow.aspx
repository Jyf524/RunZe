<%@ Page Title="订单详细展示  " Language="C#" MasterPageFile="~/ForeManagement/ForeManagement.Master" AutoEventWireup="true" CodeBehind="ForeOrderShow.aspx.cs" Inherits="RunZe.ForeManagement.ForeOrderShow" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/ForeOrderShow.css" rel="stylesheet" />
        <style type="text/css">
        #TextArea1 {
            height: 122px;
            width: 250px;
        }

        .auto-style1 {
            height: 40px;
            width: 460px;
        }

        .auto-style2 {
            height: 82px;
            width: 460px;
        }
        .auto-style3 {
            width: 460px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="content_k">
        <div class="content_nav_kk">
            <div class="content_nav">
                <div class="content_nav_word">
                    订单详细展示
                </div>
            </div>
        </div>
        <div class="content_k2">
            <div id="content">
                <div class="table_k">
                    <table style="height: 217px; width: 415px; margin: auto">
                        <tr>
                            <td class="auto-style1">
                                <strong>订单号：</strong><asp:Label ID="Lbl_OrderID" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                       <tr>
                            <td class="auto-style1">
                                <strong>收件人：</strong><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1"><strong>收件人地址：</strong>：<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">
                                <strong>收件人邮编：</strong><asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">
                                <strong>收件人联系电话：</strong><asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">
                                <strong>送货方式：</strong><asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">
                                <strong>支付方式：</strong><asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">
                                <strong>总计金额：￥</strong><asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">
                                <strong>实付金额：￥</strong><asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style3">
                                <div class="btn_check_k">
                                    <asp:LinkButton ID="LinkButton1" runat="server" CssClass="btn_check" OnClick="LinkButton1_Click">关闭</asp:LinkButton>
                                </div>
                            </td>
                        </tr>
                    </table>
                    <table class="content_list_table_k" style="border-spacing: 0; padding: 0; border: 0;">
                        <tr>
                            <td style="width: 120px;">商品图片</td>
                            <td style="width: 120px;">商品名称</td>
                            <td style="width: 120px;">商品数量</td>
                            <td style="width: 120px;">小计</td>
                        </tr>
                    </table>
                    <telerik:RadListView ID="RadListView1" runat="server" AllowPaging="true" PageSize="2" OnItemCommand="RadListView1_ItemCommand" OnNeedDataSource="RadListView1_NeedDataSource">
                        <ItemTemplate>
                            <table class="content_list_table" style="border-spacing: 0; padding: 0; border: 0; font-size: 14px;">
                                <tr>
                                    <td style="width: 200px;">
                                        <a href="Forespxx.aspx?ID=<%#Eval ("CommodityID") %>">
                                            <asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("CommodityImage") %>' Width="100" Height="100" /></a></td>
                                    <td style="width: 200px;">
                                            <a href="Forespxx.aspx?ID=<%#Eval ("CommodityID") %>"><%#Eval("CommodityName") %></a>
                                        </div>
                                    </td>
                                     <td style="width: 200px;">
                                         <%#Eval("OrderNumber") %>
                                    </td>
                                    <td style="width: 200px;">
                                         ￥<%#Eval("SubTotal") %>
                                    </td>
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
                                    <telerik:RadDataPager ID="RadDataPager1" runat="server" PageSize="2" PagedControlID="RadListView1" Skin="Metro">
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
    </div>
</asp:Content>
