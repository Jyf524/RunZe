<%@ Page Title="子类别管理" Language="C#" MasterPageFile="~/BackManagement/BackManagement.Master" AutoEventWireup="true" CodeBehind="Backzlbgl.aspx.cs" Inherits="RunZe.BackManagement.Backzlbgl" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <script type="text/javascript">
            var id = -1;
            function GetCommoditySonID(sender, args) {
                id = args.getDataKeyValue("CommoditySonID");
            }
            function OpenEdit() {
                if (-1 == id) {
                    window.alert("请选择一条数据!");
                }
                else {
                    var oWnd = radopen("BackSonchange.aspx?ID=" + id, "RadWindowManager1");
                    oWnd.setSize(400, 260);
                    oWnd.center();
                    oWnd.show();
                }
            }
            function CommoditySonID(sender, args) {
                id = args.getDataKeyValue("CommoditySonID");
            }
            function OpenEdit2() {
                var oWnd = radopen("BackSonadd.aspx?ID=" + id, "RadWindowManager1");
                oWnd.setSize(400, 260);
                oWnd.center();
                oWnd.show();
            }
            function refreshGrid(arg) {
                $find("<%= RadAjaxManager1.ClientID%>").ajaxRequest("Rebind");
             }
         </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <telerik:RadWindowManager ID="RadWindowManager1" runat="server" Behaviors="Close" Modal="true" VisibleStatusbar="false" Height="20px">
            <Localization Close="关闭" Reload="刷新" Maximize="最大化" Restore="恢复" OK="确定" Cancel="取消" />
        </telerik:RadWindowManager>
    <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
        <Scripts>
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js">
            </asp:ScriptReference>
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQuery.js">
            </asp:ScriptReference>
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQueryInclude.js">
            </asp:ScriptReference>
        </Scripts>
    </telerik:RadScriptManager>

    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server" OnAjaxRequest="RadAjaxManager1_AjaxRequest">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="RadAjaxManager1">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RadGrid1" UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
    <div class="content_main_right">
        <div class="content_main_search">
 子类别：<telerik:RadTextBox ID="RadTextBox1" runat="server"></telerik:RadTextBox>
     <asp:Button ID="Button4" runat="server" Text="查询" CssClass="content_main_Btn_Search" OnClick="Button4_Click" />
 </div>
 <div class="content_main_zlbgl">
  <div class="content_main_word">
 商品子类列表
 </div>
     <telerik:RadGrid ID="RadGrid1" runat="server" CellSpacing="0" Culture="zh-CN" GridLines="None" OnItemCommand="RadGrid1_ItemCommand" OnNeedDataSource="RadGrid1_NeedDataSource1" OnPageIndexChanged="RadGrid1_PageIndexChanged" Skin="Web20"   Width="1520px">
             <ClientSettings Selecting-AllowRowSelect="true">
                        <Selecting AllowRowSelect="true" />
                        <ClientEvents OnRowClick="GetCommoditySonID" />
                    </ClientSettings>
            <MasterTableView NoMasterRecordsText="暂无数据"  AllowPaging="true" DataKeyNames ="CommoditySonID" PageSize="10" AutoGenerateColumns ="false" ClientDataKeyNames="CommoditySonID" >
                <Columns>
                    <telerik:GridTemplateColumn>
                        <HeaderTemplate>序号</HeaderTemplate>
                        <ItemTemplate>
                            <asp:Literal ID="Literal1" runat="server" Text="<%#Container.ItemIndex +1 %>"></asp:Literal>
                        </ItemTemplate>
                    </telerik:GridTemplateColumn>
                    <telerik:GridBoundColumn DataField="CommoditySonName" HeaderText="商品名称"></telerik:GridBoundColumn>
                    <telerik:GridTemplateColumn HeaderText="操作">
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton1" runat="server" OnClientClick="return confirm('确认要删除此行?');" CommandName="Delete" CommandArgument='<%#Eval("CommoditySonID") %>'>删除</asp:LinkButton>
                        </ItemTemplate>
                    </telerik:GridTemplateColumn>
                </Columns>
            </MasterTableView>
            <ClientSettings EnableRowHoverStyle="true">
                <Selecting AllowRowSelect="true" />
            </ClientSettings>
            <PagerStyle FirstPageToolTip="第一页" LastPageToolTip="最后一页" PrevPageToolTip ="上一页" NextPageToolTip="下一页" PageSizeLabelText="每页显示数" PagerTextFormat ="{4}共<strong>{5}</strong>条数据" />
                    <PagerStyle PageSizeControlType ="RadComboBox" /> 
        </telerik:RadGrid>

<div class="content_main_right_btny">
    <asp:Button ID="Button1" runat="server" Text="修改" CssClass="content_main_right_btn_checkyy1" />
    <asp:Button ID="Button2" runat="server" Text="返回" CssClass="content_main_right_btn_checkyy1" OnClick="Button2_Click"/>
    <asp:Button ID="Button3" runat="server" Text="添加" CssClass="content_main_right_btn_checkyy1" />
</div>
 </div>
 </div>
</asp:Content>
