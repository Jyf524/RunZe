<%@ Page Title="会员管理" Language="C#" MasterPageFile="~/BackManagement/BackManagement.Master" AutoEventWireup="true" CodeBehind="Backhygl.aspx.cs" Inherits="RunZe.BackManagement.Backhygl" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <telerik:RadScriptManager ID="RadScriptManager1" runat="server">
        <Scripts>
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js"></asp:ScriptReference>
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQuery.js"></asp:ScriptReference>
            <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQueryInclude.js"></asp:ScriptReference>
        </Scripts>
    </telerik:RadScriptManager>
    <script type="text/javascript">
        var id = -1;
        function GetUserId(sender, args) {
            id = args.getDataKeyValue("UserID");
        }
        function OpenEdit() {
            if (-1 == id) {
                window.alert("请选择一条数据!");
            }
            else {
                document.location.href = "Backyhxxxx.aspx?ID=" + id;
            }
        }
    </script>
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server"></telerik:RadAjaxManager>
    <div id="content">
        <div class="content_main">
            <div class="content_main_right">
                <div class="content_main_search">
                    会员：<telerik:RadTextBox ID="RadTextBox1" runat="server">
                    </telerik:RadTextBox>
                    等级：<telerik:RadDropDownList ID="RadDropDownList1" runat="server">
                         <Items>
                    <telerik:DropDownListItem runat="server" Text="请选择" Value=""/>
                    <telerik:DropDownListItem runat="server" Text="会员" Value="会员"/>
                    <telerik:DropDownListItem runat="server" Text="VIP" Value="VIP"/>
                </Items>
                    </telerik:RadDropDownList>
                    &nbsp;<asp:Button ID="Button2" runat="server" Text="查询" CssClass="content_main_Btn_Search" OnClick="Button2_Click" />
                </div>
                <div class="content_main_hygl">
                    <telerik:RadGrid ID="RadGrid1" CssClass="content_table" runat="server" CellSpacing="0" Culture="zh-CN" GridLines="None" OnNeedDataSource="RadGrid1_NeedDataSource1" OnItemCommand="RadGrid1_ItemCommand" Skin="Web20" OnPageIndexChanged="RadGrid1_PageIndexChanged1"  Width="1520px">
                        <ClientSettings Selecting-AllowRowSelect="true">
                            <Selecting AllowRowSelect="true" />
                            <ClientEvents OnRowClick="GetUserId" />
                        </ClientSettings>
                        <MasterTableView NoMasterRecordsText="暂无数据" AllowPaging="true" DataKeyNames="UserID" PageSize="10" AutoGenerateColumns="false" ClientDataKeyNames="UserID">
                            <Columns>
                                <telerik:GridTemplateColumn>
                                    <HeaderTemplate>序号</HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:Literal ID="Literal1" runat="server" Text="<%#Container.ItemIndex +1 %>"></asp:Literal>
                                    </ItemTemplate>
                                </telerik:GridTemplateColumn>
                                <telerik:GridBoundColumn DataField="Username" HeaderText="用户名"></telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="UserRealName" HeaderText="真实姓名"></telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="RegistTime" HeaderText="注册时间" DataFormatString="{0:yyyy-MM-dd}"></telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="UserGrade" HeaderText="会员等级"></telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="UserScore" HeaderText="会员积分"></telerik:GridBoundColumn>
                                <telerik:GridTemplateColumn HeaderText="操作">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="LinkButton1" runat="server" OnClientClick="return confirm('确认要删除此行?');" CommandName="Delete" CommandArgument='<%#Eval("UserID") %>'>删除</asp:LinkButton>
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
                    <div class="content_main_right_btnq">
                        <asp:Button ID="Button1" runat="server" Text="修改" CssClass="content_main_right_btn_check" OnClick="Button1_Click" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
