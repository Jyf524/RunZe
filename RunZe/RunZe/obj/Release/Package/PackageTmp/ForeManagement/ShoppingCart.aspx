<%@ Page Title="我的购物车" Language="C#" MasterPageFile="~/ForeManagement/ForeManagement.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="RunZe.ForeManagement.ShoppingCart" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/ShoppingCart.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server"></telerik:RadAjaxManager>
    <div id="content_k">
        <div class="content_nav">
            <div class="content_nav_word">
                我的购物车
            </div>
        </div>
        <div id="content">
            <div class="content_lb">
                <table class="content_list_table_k" style="border-spacing: 0; padding: 0; border: 0;">
                    <tr>
                        <td style="width: 160px;">商品图片</td>
                        <td style="width: 160px;">商品名称</td>
                        <td style="width: 160px;">商品数量</td>
                        <td style="width: 120px;margin-left:20px">会员价格</td>
                        <td style="width: 120px;">小计</td>
                         <td style="width: 120px;">操作</td>
                    </tr>
                </table>
                <telerik:RadListView ID="RadListView1" runat="server" AllowPaging="true" PageSize="5" OnItemCommand="RadListView1_ItemCommand" OnNeedDataSource="RadListView1_NeedDataSource" OnPageIndexChanged="RadListView1_PageIndexChanged">
                    <ItemTemplate>
                        <table class="content_list_table" style="border-spacing: 0; padding: 0; border: 0; font-size: 14px;">
                            <tr>
                                <td style="width: 280px;">
                                    <a href="Forespxx.aspx?ID=<%#Eval ("CommodityID") %>">
                                        <asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("CommodityImage") %>' Width="100" Height="100" /></a></td>
                                <td style="width: 360px;">
                                    <div class="jiequ_k">
                                        <div class="jiequ">
                                            <a href="Forespxx.aspx?ID=<%#Eval ("CommodityID") %>"><%#Eval("CommodityName") %></a>
                                        </div>
                                    </div>
                                </td>
                                <td style="width: 200px;">
                                    <div class="content_main_right_spNumber">
                                        <asp:Button ID="Btn_jian" runat="server" CssClass="content_btnjian" Text="-" OnClick="Btn_jian_Click" CommandName="Jian" CommandArgument='<%#Eval ("CommodityID") %>' />
                                        <div class="content_txtnum1">
                                            <telerik:RadNumericTextBox ID="Commoditynum" NumberFormat-DecimalDigits="0" DbValue='<%#Eval("OrderNumber") %>' ReadOnly="true"  MinValue="1"  runat="server" CssClass="content_table_txtnum" Height="25px" Width="70px" MaxLength="7"></telerik:RadNumericTextBox>
                                        </div>
                                        <asp:Button ID="Btn_add" runat="server" CssClass="content_btnadd" Text="+" OnClick="Btn_add_Click" CommandName="Add" CommandArgument='<%#Eval ("CommodityID") %>' />

                                    </div>

                                </td>
                                <td style="width: 200px;"><font color="Red">￥<%#Eval ("VIPPrice") %></font></td>

                                <td style="width: 260px;">￥<asp:Label ID="Lbl_Subtotal" runat="server" Text='<%#Eval("Subtotal") %>'></asp:Label></td>

                                <td style="width: 260px;"><asp:LinkButton ID="LinkButton2" runat="server"  CommandName="Delete" CommandArgument='<%#Eval ("ShoppingCartID") %>'>删除</asp:LinkButton></td>
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
                                <telerik:RadDataPager ID="RadDataPager1" runat="server" PageSize="5" PagedControlID="RadListView1" Skin="Metro">
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
                <div id="content_buy" runat="server">
                    <div class="delete_all">
                        <div class="delete_all_word">
                            <asp:LinkButton ID="Linkbtn_delete_all_word" runat="server" OnClick="Linkbtn_delete_all_word_Click">清空购物车</asp:LinkButton>
                        </div>
                    </div>
                    <div class="continue">
                        <div class="continue_word">
                            <asp:LinkButton ID="Linkbtn_continue_word" runat="server" OnClick="Linkbtn_continue_word_Click">继续购物</asp:LinkButton>
                        </div>
                    </div>
                    <div class="discount">
                        <div class="discount_word">
                            折扣率：<asp:Label ID="Lbl_discount" runat="server" Text=""></asp:Label>
                        </div>
                    </div>
                    <div class="totalprice">
                        <div class="totalprice_word">
                            总价：￥<asp:Label ID="Lbl_totalprice" runat="server" Text=""></asp:Label>
                        </div>
                    </div>
                    <div class="buyall">
                        <asp:LinkButton ID="Linkbtn_buyall_word" runat="server" CssClass="buyall_word" OnClick="Linkbtn_buyall_word_Click">下订单</asp:LinkButton>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
