<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="Maticsoft.Web.Commodity.Modify" Title="修改页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		CommodityID
	：</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblCommodityID" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CommodityFatherID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCommodityFatherID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CommoditySonID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCommoditySonID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CommodityName
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCommodityName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CommodityPrice
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCommodityPrice" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MarketPrice
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMarketPrice" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		VIPPrice
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtVIPPrice" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Stock
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtStock" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BuyScore
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBuyScore" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CommodityImage
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCommodityImage" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CommodityType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCommodityType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CommoditySaled
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCommoditySaled" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Introduce
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtIntroduce" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CommodityTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtCommodityTime" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Recommend
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRecommend" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CommodityState
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCommodityState" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Score
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtScore" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ScoreTimes
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtScoreTimes" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
</table>
<script src="/js/calendar1.js" type="text/javascript"></script>

            </td>
        </tr>
        <tr>
            <td class="tdbg" align="center" valign="bottom">
                <asp:Button ID="btnSave" runat="server" Text="保存"
                    OnClick="btnSave_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
                <asp:Button ID="btnCancle" runat="server" Text="取消"
                    OnClick="btnCancle_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
            </td>
        </tr>
    </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>

