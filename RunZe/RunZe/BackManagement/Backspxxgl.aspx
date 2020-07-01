<%@ Page Title="商品信息管理" Language="C#" MasterPageFile="~/BackManagement/BackManagement.Master" AutoEventWireup="true" CodeBehind="Backspxxgl.aspx.cs" Inherits="RunZe.BackManagement.Backspxxgl" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <script type="text/javascript">
         var id = -1;
         function GetCommodityID(sender, args) {
             id = args.getDataKeyValue("CommodityID");
         }
         function OpenEdit() {
             if (-1 == id) {
                 window.alert("请选择一条数据!");
             }
             else {
                 document.location.href = "Backspxx.aspx?ID=" + id;
             }
         }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
        <Scripts>
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js"></asp:ScriptReference>
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQuery.js"></asp:ScriptReference>
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQueryInclude.js"></asp:ScriptReference>
        </Scripts>
    </telerik:RadScriptManager>
    <br />
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
    </telerik:RadAjaxManager>
    <div class="content_main_right">
        <div class="content_main_search">
            商品：<telerik:RadTextBox ID="RadTextBox1" Runat="server">
            </telerik:RadTextBox>
            推荐:
            <telerik:RadDropDownList ID="ddlGoodsRecommend" runat="server">
                <Items>
                    <telerik:DropDownListItem runat="server" Text="全部" Value="1" />
                    <telerik:DropDownListItem runat="server" Text="推荐"  Value="2"/>
                    <telerik:DropDownListItem runat="server" Text="不推荐"  Value="3"/>
                </Items>
            </telerik:RadDropDownList>
            类别:
            <telerik:RadDropDownList ID="ddlGoodsFatherName" runat="server" AppendDataBoundItems="true" AutoPostBack="true" OnLoad="ddlGoodsFatherName_Load" OnSelectedIndexChanged="ddlGoodsFatherName_SelectedIndexChanged">
            </telerik:RadDropDownList>
            <telerik:RadDropDownList ID="ddlGoodsSonName" runat="server" AppendDataBoundItems="true" AutoPostBack="true">
            </telerik:RadDropDownList>
&nbsp;<asp:Button ID="Button1" runat="server" Text="查询" CssClass="content_main_Btn_Search" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="添加商品" CssClass="content_main_Btn_Search2" OnClick="Button2_Click" />
        </div>
        <div class="content_main_search2">
        </div>
        <div class="content_main_hygl">
            <telerik:RadGrid ID="RadGrid1" runat="server" CellSpacing="0" Culture="zh-CN" GridLines="None" OnNeedDataSource="RadGrid1_NeedDataSource" Skin="Web20" Width="1520px" OnItemCommand="RadGrid1_ItemCommand1">
                  <ClientSettings Selecting-AllowRowSelect="true">
                            <Selecting AllowRowSelect="true" />
                            <ClientEvents OnRowClick="GetCommodityID" />
                        </ClientSettings>
                <MasterTableView NoMasterRecordsText="暂无数据" AllowPaging="true" DataKeyNames="CommodityID" PageSize="10" AutoGenerateColumns="false" ClientDataKeyNames="CommodityID">
                    <Columns>
                        <telerik:GridTemplateColumn>
                            <HeaderTemplate>序号</HeaderTemplate>
                            <ItemTemplate>
                                <asp:Literal ID="Literal1" runat="server" Text="<%#Container.ItemIndex +1 %>"></asp:Literal>
                            </ItemTemplate>
                        </telerik:GridTemplateColumn>
                        <telerik:GridBoundColumn DataField="CommodityName" HeaderText="商品名称"></telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="MarketPrice" HeaderText="市场价"></telerik:GridBoundColumn>
                       <telerik:GridTemplateColumn>
                        <HeaderTemplate>类别</HeaderTemplate>
                        <ItemTemplate>
                            <%#Eval("CommodityFatherName")%>
                            —
                            <%#Eval("CommoditySonName")%>
                        </ItemTemplate>
                    </telerik:GridTemplateColumn>
                        <telerik:GridBoundColumn DataField="CommodityState" HeaderText="状态"></telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="CommodityTime" HeaderText="添加时间" DataFormatString="{0:yyyy-MM-dd}"></telerik:GridBoundColumn>
                        <telerik:GridTemplateColumn HeaderText="操作">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" OnClientClick="return confirm('确认要删除此行?');" CommandName="Delete" CommandArgument='<%#Eval("CommodityID") %>'>删除</asp:LinkButton>
                            </ItemTemplate>
                        </telerik:GridTemplateColumn>
                    </Columns>
                </MasterTableView>
                <ClientSettings EnableRowHoverStyle="true">
                    <Selecting AllowRowSelect="true" />
                </ClientSettings>
                <PagerStyle FirstPageToolTip="第一页" LastPageToolTip="最后一页" PrevPageToolTip="上一页" NextPageToolTip="下一页" PageSizeLabelText="每页显示数" PagerTextFormat="{4}共<strong>{5}</strong>条数据" />
                <PagerStyle PageSizeControlType="RadComboBox" />
            </telerik:RadGrid>
        </div>
        <div class="content_main_right_btnq">
            <asp:Button ID="Button3" runat="server" Text="修改" CssClass="content_main_right_btn_check" OnClick="Button3_Click" />
        </div>
    </div>
</asp:Content>
