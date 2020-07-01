<%@ Page Title="润泽购物首页" Language="C#" MasterPageFile="~/ForeManagement/ForeManagement.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="RunZe.HomePage" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/HomePage.css" rel="stylesheet" />
    <link href="css/lanren.css" rel="stylesheet" />
    <link href="css/lanrenzhijia.css" rel="stylesheet" />
    <script src="js/jquery.js"></script>
    <link href="css/css.css" rel="stylesheet" />
    <script src="http://www.jq22.com/jquery/jquery-1.10.2.js"></script>
    <script src="http://localhost:10440/js/index.js"></script>
    <script src="js/index.js"></script>

    <script>
        function setTab(name, cursel) {
            cursel_0 = cursel;
            for (var i = 1; i <= links_len; i++) {
                var menu = document.getElementById(name + i);
                var menudiv = document.getElementById("con_" + name + "_" + i);
                if (i == cursel) {
                    menu.className = "off";
                    menudiv.style.display = "block";
                }
                else {
                    menu.className = "";
                    menudiv.style.display = "none";
                }
            }
        }

        function Next() {
            cursel_0++;
            if (cursel_0 > links_len) cursel_0 = 1
            setTab(name_0, cursel_0);
        }
        var name_0 = 'one';
        var cursel_0 = 1;
        var ScrollTime = 30000;//循环周期，可任意更改（毫秒）
        var links_len, iIntervalId;
        onload = function () {
            var links = document.getElementById("tab1").getElementsByTagName('li')
            links_len = links.length;
            for (var i = 0; i < links_len; i++) {
                links[i].onmouseover = function () {
                    clearInterval(iIntervalId);
                    this.onmouseout = function () {
                        iIntervalId = setInterval(Next, ScrollTime);;
                    }
                }
            }
            document.getElementById("con_" + name_0 + "_" + links_len).parentNode.onmouseover = function () {
                clearInterval(iIntervalId);
                this.onmouseout = function () {
                    iIntervalId = setInterval(Next, ScrollTime);;
                }
            }
            setTab(name_0, cursel_0);
            iIntervalId = setInterval(Next, ScrollTime);
        }
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="content_kk">
        <div id="content_1">
            <div class="nav_k">
                <div class="nav">
                    <div class="lanren" style="margin-left: 18%">
                        <div id="nav-2015">
                            <div id="category-2015" onmouseover="this.className='on'" onmouseleave="this.className=''">
                                <div class="ld">
                                    <h2>全部商品分类<b></b></h2>
                                </div>

                                <div id="allsort">
                                    <telerik:RadListView ID="RadLV_Father" runat="server" OnNeedDataSource="RadLV_Father_NeedDataSource" OnItemDataBound="RadLV_Father_ItemDataBound" DataKeyNames="CommodityFatherID" OnItemCommand="RadLV_Father_ItemCommand">
                                        <ItemTemplate>
                                            <div class="item" onmouseover="this.className='item on'" onmouseleave="this.className='item'">
                                                <span>
                                                    <asp:LinkButton ID="LinkBtn_Father" CssClass="link2" runat="server" CommandArgument=' <%#Eval ("CommodityFatherID") %>'><%#Eval ("CommodityFatherName") %></asp:LinkButton>
                                                </span>
                                                <div class="i-mc">
                                                    <telerik:RadListView ID="RadLV_Son" runat="server" OnItemCommand="RadLV_Son_ItemCommand">
                                                        <ItemTemplate>
                                                            <asp:LinkButton ID="Link_Son" CssClass="link2" runat="server" OnClick="LinkButton1_Click" CommandArgument=' <%#Eval ("CommoditySonID") %>'>  <%#Eval ("CommoditySonName") %></asp:LinkButton>
                                                        </ItemTemplate>
                                                    </telerik:RadListView>
                                                </div>
                                            </div>
                                        </ItemTemplate>
                                    </telerik:RadListView>
                                </div>
                            </div>
                            <div id="navitems-2015">
                                <li><a href="HomePage.aspx">首页</a></li>
                                <telerik:RadListView ID="RadLV_Father1" runat="server" OnNeedDataSource="RadLV_Father1_NeedDataSource" OnItemCommand="RadLV_Father1_ItemCommand">
                                    <ItemTemplate>
                                        <li>
                                            <asp:LinkButton ID="LinkBtn_Father1" runat="server" CommandArgument=' <%#Eval ("CommodityFatherID") %>'><%#Eval ("CommodityFatherName") %></asp:LinkButton></li>
                                    </ItemTemplate>
                                </telerik:RadListView>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="banner_1">
                <div class="box2">
                    <div class="list2">
                        <ul>
                            <li><a href="#">
                                <img src="image/banner_macbook_air.png" alt="" /></a></li>
                            <li><a href="#">
                                <img src="image/banner_nike.png" alt="" /></a></li>
                            <li><a href="#">
                                <img src="image/banner_adidas.png" alt="" /></a></li>
                            <li><a href="#">
                                <img src="image/banner_Vans.png" alt="" /></a></li>
                            <li><a href="#">
                                <img src="image/banner_BoyLondon.png" alt="" /></a></li>
                        </ul>
                    </div>
                    <div class="btn2 prev">&lt;</div>
                    <div class="btn2 next">&gt;</div>
                    <div class="ico2"></div>
                </div>
            </div>
            <div class="content_left_k">
                <div class="content_left">
                    <div class="content_newsp_k">
                        <div class="content_newsp">
                            <div class="content_newsp_word">
                                <asp:Image ID="Image1" runat="server" ImageUrl="~/image/newsp.png" />
                            </div>
                            <telerik:RadListView ID="RadLV_newsp" runat="server" OnNeedDataSource="RadLV_newsp_NeedDataSource" AllowPaging="true" PageSize="5">
                                <ItemTemplate>
                                    <table style="width: 120px; float: left; margin-top: 3%;">
                                        <tr>
                                            <td>
                                                <a href="ForeManagement/Forespxx.aspx?ID=<%#Eval ("CommodityID") %>">
                                                    <asp:Image ID="Image3" runat="server" ImageUrl='<%#Eval("CommodityImage") %>' Width="100" Height="100" /></a>
                                            </td>
                                            <tr />
                                            <tr>
                                                <td>
                                                    <div class="jiequ">
                                                        <a href="ForeManagement/Forespxx.aspx?ID=<%#Eval ("CommodityID") %>"><%#Eval ("CommodityName") %></a>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <s>￥<%#Eval ("MarketPrice") %></s></td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <font color="Red">￥<%#Eval ("VIPPrice") %></font></s></td>
                                            </tr>
                                        </tr>
                                    </table>
                                </ItemTemplate>
                            </telerik:RadListView>
                        </div>
                    </div>
                    <div class="content_tuijiansp_kk">
                        <div class="content_tuijiansp_k">
                            <div class="content_tuijiansp">
                                <div class="content_tuijiansp_word">
                                    <asp:Image ID="Image2" runat="server" ImageUrl="~/image/tjsp.png" />
                                </div>
                                <telerik:RadListView ID="RadLVtuijiansp" runat="server" AllowPaging="true" PageSize="5" OnNeedDataSource="RadLVtuijiansp_NeedDataSource">
                                    <ItemTemplate>
                                        <table style="width: 120px; float: left; margin-top: 3%;">
                                            <tr>
                                                <td>
                                                    <a href="ForeManagement/Forespxx.aspx?ID=<%#Eval ("CommodityID") %>">
                                                        <asp:Image ID="Image3" runat="server" ImageUrl='<%#Eval("CommodityImage") %>' Width="100" Height="100" /></a>
                                                </td>
                                                <tr />
                                                <tr>
                                                    <td>
                                                        <div class="jiequ">
                                                            <a href="ForeManagement/Forespxx.aspx?ID=<%#Eval ("CommodityID") %>"><%#Eval ("CommodityName") %></a>
                                                        </div>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <s>￥<%#Eval ("MarketPrice") %></s></td>
                                                </tr>
                                                <tr>
                                                    <td>
                                                        <font color="Red">￥<%#Eval ("VIPPrice") %></font></s></td>
                                                </tr>
                                            </tr>
                                        </table>
                                    </ItemTemplate>
                                </telerik:RadListView>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
            <div class="content_right_k">
                <div class="content_right">
                    <div class="content_VIPjfph">
                        <div class="tab1" id="tab1">
                            <div class="menu">
                                <ul>
                                    <li id="one1" onclick="setTab('one',1)">会员积分排行</li>
                                    <li id="one2" onclick="setTab('one',2)">最受欢迎商品排行</li>
                                </ul>
                            </div>
                            <div class="menudiv">
                                <div id="con_one_1">
                                    <telerik:RadListView ID="RadLVVipjfph" runat="server" OnNeedDataSource="RadLVVipjfph_NeedDataSource">
                                        <ItemTemplate>
                                            <table style="width: 290px; float: left;">
                                                <tr>
                                                    <td>
                                                        <div class="jiequ">
                                                            <a href="#"><%#Eval ("Username") %></a>
                                                        </div>
                                                    </td>
                                                    <td>积分：<%#Eval ("UserScore") %></td>
                                                </tr>
                                            </table>
                                        </ItemTemplate>
                                    </telerik:RadListView>
                                </div>
                                <div id="con_one_2" style="display: none;">
                                    <telerik:RadListView ID="RadLVzshyph" runat="server" OnNeedDataSource="RadLVzshyph_NeedDataSource" AllowPaging="true" PageSize="10">
                                        <ItemTemplate>
                                            <table style="width: 290px; float: left;">
                                                <tr>
                                                    <td>
                                                        <div class="jiequ">
                                                            <a href="ForeManagement/Forespxx.aspx?ID=<%#Eval ("CommodityID") %>"><%#Eval ("CommodityName") %></a>
                                                        </div>
                                                    </td>
                                                    <td>销量：<%#Eval ("CommoditySaled") %></td>
                                                </tr>
                                            </table>
                                        </ItemTemplate>
                                    </telerik:RadListView>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
