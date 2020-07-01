<%@ Page Title="订单管理" Language="C#" MasterPageFile="~/BackManagement/BackManagement.Master" AutoEventWireup="true" CodeBehind="Backddgl.aspx.cs" Inherits="RunZe.BackManagement.Backddgl" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        var id = -1;
        function GetOrderID(sender, args) {
            id = args.getDataKeyValue("OrderID");
        }
        function OpenEdit() {
            if (-1 == id) {
                window.alert("请选择一条数据!");
            }
            else {
                document.location.href = "Backddxx.aspx?ID=" + id;
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
    <div id="content">
        <div class="content_main">

            <div class="content_main_right">
                <div class="content_main_search">
                    订单号：<telerik:RadTextBox ID="RadTextBox1" runat="server">
                    </telerik:RadTextBox>
                    &nbsp;&nbsp;订单状态：<telerik:RadDropDownList ID="RadDropDownList1" runat="server">
                        <Items>
                            <telerik:DropDownListItem Text="全部" Value="1" />
                            <telerik:DropDownListItem Text="待付款" Value="2" />
                            <telerik:DropDownListItem Text="已付款待发货" Value="3" />
                            <telerik:DropDownListItem Text="已发货" Value="4" />
                            <telerik:DropDownListItem Text="完成" Value="5" />
                            <telerik:DropDownListItem Text="订单取消" Value="6" />
                        </Items>
                                     </telerik:RadDropDownList>
                    &nbsp;<asp:Button ID="Button2" runat="server" Text="查询" CssClass="content_main_Btn_Search" OnClick="Button2_Click" />
                </div>
                <div class="content_main_hygl">
                    <telerik:RadGrid ID="RadGrid1" runat="server" CellSpacing="0" Culture="zh-CN" GridLines="None" OnNeedDataSource="RadGrid1_NeedDataSource" OnItemCommand="RadGrid1_ItemCommand" Skin="Web20">
                        <ClientSettings Selecting-AllowRowSelect="true">
                            <Selecting AllowRowSelect="true" />
                            <ClientEvents OnRowClick="GetOrderID" />
                        </ClientSettings>
                        <MasterTableView NoMasterRecordsText="暂无数据" AllowPaging="true" DataKeyNames="OrderID" PageSize="10" AutoGenerateColumns="false" Width="1520px" ClientDataKeyNames="OrderID">
                            <Columns>
                                <telerik:GridTemplateColumn>
                                    <HeaderTemplate>序号</HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:Literal ID="Literal1" runat="server" Text="<%#Container.ItemIndex +1 %>"></asp:Literal>
                                    </ItemTemplate>
                                </telerik:GridTemplateColumn>
                                <telerik:GridBoundColumn DataField="OrderID" HeaderText="订单号"></telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="UserID" HeaderText="下单用户"></telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="OrderDate" HeaderText="下单时间" DataFormatString="{0:yyyy-MM-dd}"></telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="OrderState" HeaderText="下单状态"></telerik:GridBoundColumn>
                            </Columns>
                        </MasterTableView>
                        <ClientSettings EnableRowHoverStyle="true">
                            <Selecting AllowRowSelect="true" />
                        </ClientSettings>
                        <PagerStyle FirstPageToolTip="第一页" LastPageToolTip="最后一页" PrevPageToolTip="上一页" NextPageToolTip="下一页" PageSizeLabelText="每页显示数" PagerTextFormat="{4}共<strong>{5}</strong>条数据" />
                        <PagerStyle PageSizeControlType="RadComboBox" />
                    </telerik:RadGrid>
                     
                    <div class="content_main_right_btnz">
                        <asp:Button ID="Button1" runat="server" Text="查看" CssClass="content_main_right_btn_check" OnClick="Button1_Click" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
