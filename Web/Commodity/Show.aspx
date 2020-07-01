<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Maticsoft.Web.Commodity.Show" Title="显示页" %>
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
		<asp:Label id="lblCommodityID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CommodityFatherID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCommodityFatherID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CommoditySonID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCommoditySonID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CommodityName
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCommodityName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CommodityPrice
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCommodityPrice" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MarketPrice
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMarketPrice" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		VIPPrice
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblVIPPrice" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Stock
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblStock" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BuyScore
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBuyScore" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CommodityImage
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCommodityImage" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CommodityType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCommodityType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CommoditySaled
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCommoditySaled" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Introduce
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIntroduce" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CommodityTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCommodityTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Recommend
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRecommend" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CommodityState
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCommodityState" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Score
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblScore" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ScoreTimes
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblScoreTimes" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




