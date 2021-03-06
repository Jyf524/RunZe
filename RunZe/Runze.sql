USE [RunZe]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 01/18/2019 14:41:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [varchar](50) NOT NULL,
	[Username] [varchar](50) NULL,
	[UserPassword] [varchar](50) NULL,
	[UserRealName] [varchar](50) NULL,
	[UserSex] [varchar](50) NULL,
	[UserEmail] [varchar](50) NULL,
	[UserGrade] [varchar](50) NULL,
	[UserScore] [int] NULL,
	[Province] [varchar](50) NULL,
	[City] [varchar](50) NULL,
	[Address1] [varchar](50) NULL,
	[UserIdentity] [varchar](50) NULL,
	[RegistTime] [datetime] NULL,
	[Phone] [varchar](50) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Users] ([UserID], [Username], [UserPassword], [UserRealName], [UserSex], [UserEmail], [UserGrade], [UserScore], [Province], [City], [Address1], [UserIdentity], [RegistTime], [Phone]) VALUES (N'1', N'mahuateng', N'mahuateng', N'马化腾', N'男', N'11@qq.com', N'会员', 1, N'广东', N'深圳 ', N'x', N'管理员', CAST(0x0000A9C000000000 AS DateTime), N'18651401705')
INSERT [dbo].[Users] ([UserID], [Username], [UserPassword], [UserRealName], [UserSex], [UserEmail], [UserGrade], [UserScore], [Province], [City], [Address1], [UserIdentity], [RegistTime], [Phone]) VALUES (N'10', N'Tim Cook', N'Tim Cook', N'库克', N'男', N'14@qq.com', N'VIP', 10, NULL, NULL, N'x', N'管理员', CAST(0x0000A9C000000000 AS DateTime), N'18651401705')
INSERT [dbo].[Users] ([UserID], [Username], [UserPassword], [UserRealName], [UserSex], [UserEmail], [UserGrade], [UserScore], [Province], [City], [Address1], [UserIdentity], [RegistTime], [Phone]) VALUES (N'11', N'Kobe', N'kobe', N'科比', N'男', N'14@qq.com', N'会员', 11, NULL, NULL, N'x', N'管理员', CAST(0x0000A9C000000000 AS DateTime), N'18651401705')
INSERT [dbo].[Users] ([UserID], [Username], [UserPassword], [UserRealName], [UserSex], [UserEmail], [UserGrade], [UserScore], [Province], [City], [Address1], [UserIdentity], [RegistTime], [Phone]) VALUES (N'2', N'mayun', N'mayun', N'马云', N'男', N'12@qq.com', N'VIP', 2, N'浙江', N'杭州', N'x', N'管理员', CAST(0x0000A9C000000000 AS DateTime), N'18651401705')
INSERT [dbo].[Users] ([UserID], [Username], [UserPassword], [UserRealName], [UserSex], [UserEmail], [UserGrade], [UserScore], [Province], [City], [Address1], [UserIdentity], [RegistTime], [Phone]) VALUES (N'3', N'liuqiangdong', N'liuqiangdong', N'刘强东', N'男', N'13@qq.com', N'会员', 3, N'北京', NULL, N'x', N'管理员', CAST(0x0000A9C000000000 AS DateTime), N'18651401705')
INSERT [dbo].[Users] ([UserID], [Username], [UserPassword], [UserRealName], [UserSex], [UserEmail], [UserGrade], [UserScore], [Province], [City], [Address1], [UserIdentity], [RegistTime], [Phone]) VALUES (N'4', N'leijun', N'leijun', N'雷军', N'男', N'14@qq.com', N'VIP', 4, NULL, NULL, N'x', N'管理员', CAST(0x0000A9C000000000 AS DateTime), N'18651401705')
INSERT [dbo].[Users] ([UserID], [Username], [UserPassword], [UserRealName], [UserSex], [UserEmail], [UserGrade], [UserScore], [Province], [City], [Address1], [UserIdentity], [RegistTime], [Phone]) VALUES (N'5', N'dinglei', N'dinglei', N'丁磊', N'男', N'14@qq.com', N'会员', 5, NULL, NULL, N'x', N'管理员', CAST(0x0000A9C000000000 AS DateTime), N'18651401705')
INSERT [dbo].[Users] ([UserID], [Username], [UserPassword], [UserRealName], [UserSex], [UserEmail], [UserGrade], [UserScore], [Province], [City], [Address1], [UserIdentity], [RegistTime], [Phone]) VALUES (N'6', N'wangjianlin', N'wangjianlin', N'王健林', N'男', N'14@qq.com', N'VIP', 6, N'北京', NULL, N'x', N'管理员', CAST(0x0000A9C000000000 AS DateTime), N'18651401705')
INSERT [dbo].[Users] ([UserID], [Username], [UserPassword], [UserRealName], [UserSex], [UserEmail], [UserGrade], [UserScore], [Province], [City], [Address1], [UserIdentity], [RegistTime], [Phone]) VALUES (N'7', N'wangsicong', N'wangsicong', N'王思聪', N'男', N'14@qq.com', N'会员', 7, N'北京', NULL, N'x', N'管理员', CAST(0x0000A9C000000000 AS DateTime), N'18651401705')
INSERT [dbo].[Users] ([UserID], [Username], [UserPassword], [UserRealName], [UserSex], [UserEmail], [UserGrade], [UserScore], [Province], [City], [Address1], [UserIdentity], [RegistTime], [Phone]) VALUES (N'8', N'liyanhong', N'liyanhong', N'李彦宏', N'男', N'14@qq.com', N'VIP', 8, NULL, NULL, N'x', N'管理员', CAST(0x0000A9C000000000 AS DateTime), N'18651401705')
INSERT [dbo].[Users] ([UserID], [Username], [UserPassword], [UserRealName], [UserSex], [UserEmail], [UserGrade], [UserScore], [Province], [City], [Address1], [UserIdentity], [RegistTime], [Phone]) VALUES (N'9', N'Steve Jobs', N'Steve Jobs', N'乔布斯', N'男', N'14@qq.com', N'会员', 9, NULL, NULL, N'x', N'管理员', CAST(0x0000A9C000000000 AS DateTime), N'18651401705')
/****** Object:  Table [dbo].[ShoppingCart]    Script Date: 01/18/2019 14:41:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ShoppingCart](
	[ShoppingCartID] [varchar](50) NOT NULL,
	[UserID] [varchar](50) NULL,
	[CommodityID] [varchar](50) NULL,
	[OrderNumber] [int] NULL,
	[Subtotal] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ShoppingCart] PRIMARY KEY CLUSTERED 
(
	[ShoppingCartID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ShoppingCart] ([ShoppingCartID], [UserID], [CommodityID], [OrderNumber], [Subtotal]) VALUES (N'20190114024042', N'11', N'6', 110, N'')
INSERT [dbo].[ShoppingCart] ([ShoppingCartID], [UserID], [CommodityID], [OrderNumber], [Subtotal]) VALUES (N'20190114123956', N'11', N'1', 999, N'')
/****** Object:  Table [dbo].[Orders]    Script Date: 01/18/2019 14:41:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [varchar](50) NOT NULL,
	[UserID] [varchar](50) NULL,
	[OrderDate] [datetime] NULL,
	[OrderState] [varchar](50) NULL,
	[CommodityID] [varchar](50) NULL,
	[OrderNumber] [varchar](50) NULL,
	[AddresseeName] [varchar](50) NULL,
	[AddresseeAddress] [varchar](50) NULL,
	[AddresseeZipCode] [varchar](50) NULL,
	[AddresseePhone] [varchar](50) NULL,
	[TotalMoney] [decimal](18, 2) NULL,
	[PayType] [varchar](50) NULL,
	[Delivery] [varchar](50) NULL,
	[Message] [varchar](50) NULL,
	[OrderImage] [varchar](50) NULL,
	[CommodityName] [varchar](50) NULL,
	[Price] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Orders] ([OrderID], [UserID], [OrderDate], [OrderState], [CommodityID], [OrderNumber], [AddresseeName], [AddresseeAddress], [AddresseeZipCode], [AddresseePhone], [TotalMoney], [PayType], [Delivery], [Message], [OrderImage], [CommodityName], [Price]) VALUES (N'1', N'卢本伟', CAST(0x0000901A00000000 AS DateTime), N'1', N'1', N'1', N'1', N'1', N'1', N'1', CAST(1.00 AS Decimal(18, 2)), N'1', N'', N'1', NULL, NULL, NULL)
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 01/18/2019 14:41:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[OrderDetailID] [varchar](50) NOT NULL,
	[OrderID] [varchar](50) NULL,
	[CommodityID] [varchar](50) NULL,
	[UserID] [varchar](50) NULL,
	[OrderNumber] [int] NULL,
	[AppraiseGrade] [int] NULL,
	[Subtotal] [varchar](50) NULL,
 CONSTRAINT [PK_OrderDetail] PRIMARY KEY CLUSTERED 
(
	[OrderDetailID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [CommodityID], [UserID], [OrderNumber], [AppraiseGrade], [Subtotal]) VALUES (N'1', NULL, N'1', N'11', NULL, 80, NULL)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [CommodityID], [UserID], [OrderNumber], [AppraiseGrade], [Subtotal]) VALUES (N'2', NULL, N'2', N'11', NULL, 80, NULL)
/****** Object:  Table [dbo].[CommoditySon]    Script Date: 01/18/2019 14:41:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CommoditySon](
	[CommoditySonID] [varchar](50) NOT NULL,
	[CommodityFatherID] [varchar](50) NULL,
	[CommoditySonName] [varchar](50) NULL,
 CONSTRAINT [PK_CommoditySon] PRIMARY KEY CLUSTERED 
(
	[CommoditySonID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CommoditySon] ([CommoditySonID], [CommodityFatherID], [CommoditySonName]) VALUES (N'1', N'1', N'电视')
INSERT [dbo].[CommoditySon] ([CommoditySonID], [CommodityFatherID], [CommoditySonName]) VALUES (N'10', N'3', N'华为')
INSERT [dbo].[CommoditySon] ([CommoditySonID], [CommodityFatherID], [CommoditySonName]) VALUES (N'11', N'4', N'DNF')
INSERT [dbo].[CommoditySon] ([CommoditySonID], [CommodityFatherID], [CommoditySonName]) VALUES (N'12', N'4', N'CF')
INSERT [dbo].[CommoditySon] ([CommoditySonID], [CommodityFatherID], [CommoditySonName]) VALUES (N'13', N'4', N'LOL')
INSERT [dbo].[CommoditySon] ([CommoditySonID], [CommodityFatherID], [CommoditySonName]) VALUES (N'14', N'6', N'中美合拍西游记')
INSERT [dbo].[CommoditySon] ([CommoditySonID], [CommodityFatherID], [CommoditySonName]) VALUES (N'15', N'6', N'章口就莱')
INSERT [dbo].[CommoditySon] ([CommoditySonID], [CommodityFatherID], [CommoditySonName]) VALUES (N'2', N'1', N'空调')
INSERT [dbo].[CommoditySon] ([CommoditySonID], [CommodityFatherID], [CommoditySonName]) VALUES (N'3', N'1', N'取暖器')
INSERT [dbo].[CommoditySon] ([CommoditySonID], [CommodityFatherID], [CommoditySonName]) VALUES (N'4', N'1', N'冰箱')
INSERT [dbo].[CommoditySon] ([CommoditySonID], [CommodityFatherID], [CommoditySonName]) VALUES (N'5', N'2', N'平板电脑')
INSERT [dbo].[CommoditySon] ([CommoditySonID], [CommodityFatherID], [CommoditySonName]) VALUES (N'6', N'2', N'笔记本')
INSERT [dbo].[CommoditySon] ([CommoditySonID], [CommodityFatherID], [CommoditySonName]) VALUES (N'7', N'2', N'路由器')
INSERT [dbo].[CommoditySon] ([CommoditySonID], [CommodityFatherID], [CommoditySonName]) VALUES (N'8', N'3', N'Apple')
INSERT [dbo].[CommoditySon] ([CommoditySonID], [CommodityFatherID], [CommoditySonName]) VALUES (N'9', N'3', N'小米')
/****** Object:  Table [dbo].[CommodityFather]    Script Date: 01/18/2019 14:41:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CommodityFather](
	[CommodityFatherID] [varchar](50) NOT NULL,
	[CommodityFatherName] [varchar](50) NULL,
 CONSTRAINT [PK_CommodityFather] PRIMARY KEY CLUSTERED 
(
	[CommodityFatherID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CommodityFather] ([CommodityFatherID], [CommodityFatherName]) VALUES (N'1', N'家电')
INSERT [dbo].[CommodityFather] ([CommodityFatherID], [CommodityFatherName]) VALUES (N'2', N'数码')
INSERT [dbo].[CommodityFather] ([CommodityFatherID], [CommodityFatherName]) VALUES (N'3', N'手机')
INSERT [dbo].[CommodityFather] ([CommodityFatherID], [CommodityFatherName]) VALUES (N'4', N'游戏')
INSERT [dbo].[CommodityFather] ([CommodityFatherID], [CommodityFatherName]) VALUES (N'6', N'影视')
INSERT [dbo].[CommodityFather] ([CommodityFatherID], [CommodityFatherName]) VALUES (N'7', N'西游记')
/****** Object:  Table [dbo].[Commodity]    Script Date: 01/18/2019 14:41:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Commodity](
	[CommodityID] [varchar](50) NOT NULL,
	[CommodityFatherID] [varchar](50) NULL,
	[CommoditySonID] [varchar](50) NULL,
	[CommodityName] [varchar](50) NULL,
	[CommodityPrice] [varchar](50) NULL,
	[MarketPrice] [decimal](18, 2) NULL,
	[VIPPrice] [decimal](18, 2) NULL,
	[Stock] [int] NULL,
	[BuyScore] [varchar](50) NULL,
	[CommodityImage] [varchar](50) NULL,
	[CommodityType] [varchar](50) NULL,
	[CommoditySaled] [int] NULL,
	[Introduce] [varchar](max) NULL,
	[CommodityTime] [datetime] NULL,
	[Recommend] [varchar](50) NULL,
	[CommodityState] [varchar](50) NULL,
	[Score] [varchar](50) NULL,
	[ScoreTimes] [varchar](50) NULL,
 CONSTRAINT [PK_Commodity] PRIMARY KEY CLUSTERED 
(
	[CommodityID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Commodity] ([CommodityID], [CommodityFatherID], [CommoditySonID], [CommodityName], [CommodityPrice], [MarketPrice], [VIPPrice], [Stock], [BuyScore], [CommodityImage], [CommodityType], [CommoditySaled], [Introduce], [CommodityTime], [Recommend], [CommodityState], [Score], [ScoreTimes]) VALUES (N'1', N'1', N'1', N'小米电视4k超清电视', N'', CAST(2299.00 AS Decimal(18, 2)), CAST(2299.00 AS Decimal(18, 2)), 999, N'99', N'/Upload/20181227/2018122714361763.png', N'小米', 6000, N'<ul style="list-style-type: none;" class=" list-paddingleft-2"><li><p>证书编号：2015011606799882</p></li><li><p>证书状态：有效</p></li><li><p>产品名称：TD-LTE 数字移动电话机</p></li><li><p>3C规格型号：A1699（电源适配器：A1443 输出：5VDC 1A），（电源适配器可选）</p></li><li><p>产品名称：Apple/苹果 iPhone 6s Pl...</p></li><li><p>Apple型号:&nbsp;iPhone 6s Plus</p></li><li><p>机身颜色:&nbsp;银色&nbsp;金色&nbsp;深空灰色&nbsp;玫瑰金色</p></li><li><p>运行内存RAM:&nbsp;不详</p></li><li><p>存储容量:&nbsp;32GB&nbsp;128GB</p></li><li><p>网络模式:&nbsp;无需合约版</p></li><li><p>CPU型号:&nbsp;其他</p></li></ul><p><br/></p>', CAST(0x0000A9CA00CD6F68 AS DateTime), N'推荐', N'上架', NULL, NULL)
INSERT [dbo].[Commodity] ([CommodityID], [CommodityFatherID], [CommoditySonID], [CommodityName], [CommodityPrice], [MarketPrice], [VIPPrice], [Stock], [BuyScore], [CommodityImage], [CommodityType], [CommoditySaled], [Introduce], [CommodityTime], [Recommend], [CommodityState], [Score], [ScoreTimes]) VALUES (N'10', N'1', N'3', N'Robam油烟机ssssssssssssss', NULL, CAST(1999.00 AS Decimal(18, 2)), CAST(1999.00 AS Decimal(18, 2)), NULL, NULL, N'/Upload/201913/2019010314295685.png', N'Robam', 4396, NULL, CAST(0x0000A9D600CD6F68 AS DateTime), N'推荐', NULL, NULL, NULL)
INSERT [dbo].[Commodity] ([CommodityID], [CommodityFatherID], [CommoditySonID], [CommodityName], [CommodityPrice], [MarketPrice], [VIPPrice], [Stock], [BuyScore], [CommodityImage], [CommodityType], [CommoditySaled], [Introduce], [CommodityTime], [Recommend], [CommodityState], [Score], [ScoreTimes]) VALUES (N'11', N'1', N'3', N'海尔扫地机器人', NULL, CAST(1199.00 AS Decimal(18, 2)), CAST(1199.00 AS Decimal(18, 2)), NULL, NULL, N'/Upload/201913/2019010314295685.png', N'海尔', 2000, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Commodity] ([CommodityID], [CommodityFatherID], [CommoditySonID], [CommodityName], [CommodityPrice], [MarketPrice], [VIPPrice], [Stock], [BuyScore], [CommodityImage], [CommodityType], [CommoditySaled], [Introduce], [CommodityTime], [Recommend], [CommodityState], [Score], [ScoreTimes]) VALUES (N'2', N'6', N'14', N'文体两开花', NULL, CAST(999.00 AS Decimal(18, 2)), CAST(999.00 AS Decimal(18, 2)), 111, NULL, N'/Upload/201913/2019010312255379.png', N'爱奇艺', 1785, N'<ul style="list-style-type: none;" class=" list-paddingleft-2"><li><p>证书编号：2015011606799882</p></li><li><p>证书状态：有效</p></li><li><p>产品名称：TD-LTE 数字移动电话机</p></li><li><p>3C规格型号：A1699（电源适配器：A1443 输出：5VDC 1A），（电源适配器可选）</p></li><li><p>产品名称：Apple/苹果 iPhone 6s Pl...</p></li><li><p>Apple型号:&nbsp;iPhone 6s Plus</p></li><li><p>机身颜色:&nbsp;银色&nbsp;金色&nbsp;深空灰色&nbsp;玫瑰金色</p></li><li><p>运行内存RAM:&nbsp;不详</p></li><li><p>存储容量:&nbsp;32GB&nbsp;128GB</p></li><li><p>网络模式:&nbsp;无需合约版</p></li><li><p>CPU型号:&nbsp;其他</p></li></ul><p><br/></p>', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Commodity] ([CommodityID], [CommodityFatherID], [CommoditySonID], [CommodityName], [CommodityPrice], [MarketPrice], [VIPPrice], [Stock], [BuyScore], [CommodityImage], [CommodityType], [CommoditySaled], [Introduce], [CommodityTime], [Recommend], [CommodityState], [Score], [ScoreTimes]) VALUES (N'20190103022110', N'2', N'6', N'外星人Alienware笔记本', NULL, CAST(22499.00 AS Decimal(18, 2)), CAST(22499.00 AS Decimal(18, 2)), 49, N'225', N'/Upload/201913/2019010314202377.png', N'Alienware', 453, N'<ul style="list-style-type: none;" class=" list-paddingleft-2"><li><p>证书编号：2016010902898806</p></li><li><p>证书状态：有效</p></li><li><p>产品名称：便携式计算机</p></li><li><p>3C规格型号：P69F; P69F…;P31E; P31E…; Alienware 15 R3;Alienware...</p></li><li><p>产品名称：alienware ALW17C- 3748</p></li><li><p>品牌:&nbsp;alienware</p></li><li><p>型号:&nbsp;3748</p></li><li><p>内存容量:&nbsp;16G</p></li><li><p>机械硬盘容量:&nbsp;1TB</p></li><li><p>CPU:&nbsp;i7-8750H</p></li><li><p>屏幕尺寸:&nbsp;17.3英寸</p></li><li><p>显存容量:&nbsp;8GB</p></li><li><p>显卡类型:&nbsp;1070</p></li><li><p>操作系统:&nbsp;windows 10</p></li></ul><p><br/></p>', CAST(0x0000A9CA00EC86C8 AS DateTime), N'推荐', N'上架', NULL, NULL)
INSERT [dbo].[Commodity] ([CommodityID], [CommodityFatherID], [CommoditySonID], [CommodityName], [CommodityPrice], [MarketPrice], [VIPPrice], [Stock], [BuyScore], [CommodityImage], [CommodityType], [CommoditySaled], [Introduce], [CommodityTime], [Recommend], [CommodityState], [Score], [ScoreTimes]) VALUES (N'20190103022254', N'1', N'4', N'Midea/美的 BCD', N'', CAST(1399.00 AS Decimal(18, 2)), CAST(1399.00 AS Decimal(18, 2)), 100, N'139', N'/Upload/201913/2019010314222312.png', N'美的', 1234, N'<ul style="list-style-type: none;" class=" list-paddingleft-2"><li><p>证书编号：2014010701690481</p></li><li><p>证书状态：有效</p></li><li><p>申请人名称：合肥美的电冰箱有限公司</p></li><li><p>制造商名称：合肥美的电冰箱有限公司</p></li><li><p>产品名称：冷藏冷冻箱</p></li><li><p>3C产品型号：BCD-216TGM, BCD-216TMA, BCD-216TM(E) 220V～ 50Hz 0....</p></li><li><p>3C规格型号：BCD-216TGM, BCD-216TMA, BCD-216TM(E), BCD-216TMA(Y...</p></li><li><p>产品名称：Midea/美的 BCD-213TM(...</p></li><li><p>美的冰箱型号:&nbsp;BCD-213TM(E)</p></li><li><p>冰箱冷柜机型:&nbsp;冷藏冷冻冰箱</p></li><li><p>制冷方式:&nbsp;直冷</p></li><li><p>箱门结构:&nbsp;三门式</p></li><li><p>能效等级:&nbsp;二级</p></li></ul><p><br/></p>', CAST(0x0000A9CA00ED5634 AS DateTime), N'不推荐', N'上架', NULL, NULL)
INSERT [dbo].[Commodity] ([CommodityID], [CommodityFatherID], [CommoditySonID], [CommodityName], [CommodityPrice], [MarketPrice], [VIPPrice], [Stock], [BuyScore], [CommodityImage], [CommodityType], [CommoditySaled], [Introduce], [CommodityTime], [Recommend], [CommodityState], [Score], [ScoreTimes]) VALUES (N'20190103023041', N'4', N'13', N'LOL代练', NULL, CAST(10.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), 999, N'1', N'/Upload/201913/2019010314295685.png', N'Game', 123, N'<p>代练<br/></p>', CAST(0x0000A9CA00EF23EC AS DateTime), N'不推荐', N'上架', NULL, NULL)
INSERT [dbo].[Commodity] ([CommodityID], [CommodityFatherID], [CommoditySonID], [CommodityName], [CommodityPrice], [MarketPrice], [VIPPrice], [Stock], [BuyScore], [CommodityImage], [CommodityType], [CommoditySaled], [Introduce], [CommodityTime], [Recommend], [CommodityState], [Score], [ScoreTimes]) VALUES (N'20190103023210', N'2', N'7', N'TP-Link/普联技术', NULL, CAST(115.00 AS Decimal(18, 2)), CAST(115.00 AS Decimal(18, 2)), 100, N'11.5', N'/Upload/201913/2019010314314662.png', N'普联', 245, N'<ul style="list-style-type: none;" class=" list-paddingleft-2"><li><p>证书编号：2018011608039049</p></li><li><p>证书状态：有效</p></li><li><p>产品名称：AC1200双频无线路由器、AC1200双频千兆无线路由器(集线器功能）</p></li><li><p>3C规格型号：TL-WDR5620：9VDC 0.85A（电源适配器：T090085-2A1、M090085- 2...</p></li><li><p>产品名称：TP-Link/普联技术 TL-W...</p></li><li><p>TP-Link型号:&nbsp;TL-WDR5620</p></li><li><p>是否无线:&nbsp;无线</p></li><li><p>是否内置防火墙:&nbsp;是</p></li><li><p>是否支持WDS:&nbsp;支持</p></li><li><p>是否支持WPS:&nbsp;不支持</p></li><li><p>是否可拆:&nbsp;不可拆</p></li></ul><p><br/></p>', CAST(0x0000A9CA00EF8C38 AS DateTime), N'不推荐', N'上架', NULL, NULL)
INSERT [dbo].[Commodity] ([CommodityID], [CommodityFatherID], [CommoditySonID], [CommodityName], [CommodityPrice], [MarketPrice], [VIPPrice], [Stock], [BuyScore], [CommodityImage], [CommodityType], [CommoditySaled], [Introduce], [CommodityTime], [Recommend], [CommodityState], [Score], [ScoreTimes]) VALUES (N'20190103023404', N'2', N'5', N'Ipad mini 7.9英寸', NULL, CAST(2688.00 AS Decimal(18, 2)), CAST(2688.00 AS Decimal(18, 2)), 100, N'268', N'/Upload/201913/2019010314332797.png', N'Apple', 7864, N'<ul style="list-style-type: none;" class=" list-paddingleft-2"><li><p>证书编号：2015010902799877</p></li><li><p>证书状态：有效</p></li><li><p>产品名称：便携式电脑</p></li><li><p>3C规格型号：A1538 : 5.1VDC, 2.1A （电源适配器可选: A1357)</p></li><li><p>产品名称：Apple/苹果 iPad mini 4</p></li><li><p>操作系统:&nbsp;iOS</p></li><li><p>存储容量:&nbsp;128GB</p></li><li><p>品牌:&nbsp;Apple/苹果</p></li><li><p>型号:&nbsp;iPad mini 4</p></li><li><p>内存容量:&nbsp;不详</p></li><li><p>屏幕尺寸:&nbsp;7.9 英寸 (对角线) LED 背光 Mul</p></li></ul><p><br/></p>', CAST(0x0000A9CA00F011D0 AS DateTime), N'推荐', N'上架', NULL, NULL)
INSERT [dbo].[Commodity] ([CommodityID], [CommodityFatherID], [CommoditySonID], [CommodityName], [CommodityPrice], [MarketPrice], [VIPPrice], [Stock], [BuyScore], [CommodityImage], [CommodityType], [CommoditySaled], [Introduce], [CommodityTime], [Recommend], [CommodityState], [Score], [ScoreTimes]) VALUES (N'20190103023458', N'1', N'2', N'AUX/奥克斯 KFR', NULL, CAST(2999.00 AS Decimal(18, 2)), CAST(2999.00 AS Decimal(18, 2)), 100, N'299', N'/Upload/201913/2019010314343218.png', N'奥克斯', 3453, N'<ul style="list-style-type: none;" class=" list-paddingleft-2"><li><p>证书编号：2017010703967000</p></li><li><p>证书状态：有效</p></li><li><p>产品名称：变频分体热泵型挂壁式房间空气调节器</p></li><li><p>3C规格型号：见附件</p></li><li><p>产品名称：AUX/奥克斯 KFR-35GW/B...</p></li><li><p>空调类型:&nbsp;壁挂式</p></li><li><p>冷暖类型:&nbsp;冷暖电辅</p></li><li><p>空调功率:&nbsp;1.5匹</p></li><li><p>工作方式:&nbsp;变频</p></li><li><p>能效等级:&nbsp;一级</p></li><li><p>奥克斯空调型号:&nbsp;KFR-35GW/BpEYA1+1</p></li><li><p>适用面积:&nbsp;16-24㎡</p></li></ul><p><br/></p>', CAST(0x0000A9CA00F05118 AS DateTime), N'推荐', N'上架', NULL, NULL)
INSERT [dbo].[Commodity] ([CommodityID], [CommodityFatherID], [CommoditySonID], [CommodityName], [CommodityPrice], [MarketPrice], [VIPPrice], [Stock], [BuyScore], [CommodityImage], [CommodityType], [CommoditySaled], [Introduce], [CommodityTime], [Recommend], [CommodityState], [Score], [ScoreTimes]) VALUES (N'20190103023648', N'3', N'10', N'HuaWei/华为 Mate 20', NULL, CAST(4999.00 AS Decimal(18, 2)), CAST(4999.00 AS Decimal(18, 2)), 100, N'499', N'/Upload/201913/2019010314362949.png', N'华为', 4534, N'<ul style="list-style-type: none;" class=" list-paddingleft-2"><li><p>证书编号：2018011606104341</p></li><li><p>证书状态：有效</p></li><li><p>产品名称：TD-LTE数字移动电话机</p></li><li><p>3C规格型号：HMA-AL00（开关电源适配器：HW-050450C00 输出：5.0VDC，2A或4.5VDC，...</p></li><li><p>产品名称：Huawei/华为 Mate 20</p></li><li><p>华为型号:&nbsp;Mate 20</p></li><li><p>机身颜色:&nbsp;翡冷翠&nbsp;宝石蓝&nbsp;极光色&nbsp;樱粉金&nbsp;亮黑色</p></li><li><p>运行内存RAM:&nbsp;6GB</p></li><li><p>存储容量:&nbsp;6+64GB&nbsp;6+128GB</p></li><li><p>网络模式:&nbsp;双卡双待</p></li></ul><p><br/></p>', CAST(0x0000A9CA00F0D200 AS DateTime), N'推荐', N'上架', NULL, NULL)
INSERT [dbo].[Commodity] ([CommodityID], [CommodityFatherID], [CommoditySonID], [CommodityName], [CommodityPrice], [MarketPrice], [VIPPrice], [Stock], [BuyScore], [CommodityImage], [CommodityType], [CommoditySaled], [Introduce], [CommodityTime], [Recommend], [CommodityState], [Score], [ScoreTimes]) VALUES (N'20190103023752', N'1', N'3', N'奥克斯取暖器', NULL, CAST(129.00 AS Decimal(18, 2)), CAST(129.00 AS Decimal(18, 2)), 100, N'12.9', N'/Upload/201913/2019010314372727.png', N'奥克斯', 1230, N'<ul style="list-style-type: none;" class=" list-paddingleft-2"><li><p>证书编号：2009010707360784</p></li><li><p>证书状态：有效</p></li><li><p>申请人名称：宁波卡帝亚电器有限公司</p></li><li><p>制造商名称：宁波卡帝亚电器有限公司</p></li><li><p>产品名称：室内加热器(暖风机)</p></li><li><p>3C产品型号：NSBE-150-B, NSBE-150-C, NSBE-150-D, NSBE-150-E, NS...</p></li><li><p>3C规格型号：NSBE-150-B, NSBE-150-C, NSBE-150-D, NSBE-150-E, NS...</p></li><li><p>产品名称：AUX/奥克斯 NSBE-150-B</p></li><li><p>品牌:&nbsp;AUX/奥克斯</p></li><li><p>型号:&nbsp;NSBE-150-B</p></li><li><p>暖风机/取暖器类别:&nbsp;桌面取暖器</p></li><li><p>颜色分类:&nbsp;金色&nbsp;黑色&nbsp;香槟金</p></li><li><p>适用面积:&nbsp;11m^2 (含)-20m^2 (含)</p></li><li><p>电暖器最大功率:&nbsp;1200W(含)-2000W(含)</p></li><li><p>生产企业:&nbsp;宁波卡帝亚电器有限公司</p></li><li><p>最大采暖面积(平方米):&nbsp;20m^2以下</p></li><li><p>控制方式:&nbsp;机械式</p></li><li><p>档位:&nbsp;3档</p></li><li><p>取暖器加热方式:&nbsp;陶瓷加热</p></li><li><p>适用场景:&nbsp;办公室</p></li><li><p>采购地:&nbsp;中国大陆</p></li><li><p>保修期:&nbsp;12个月</p></li></ul><p><br/></p>', CAST(0x0000A9CA00F11D00 AS DateTime), N'推荐', N'上架', NULL, NULL)
INSERT [dbo].[Commodity] ([CommodityID], [CommodityFatherID], [CommoditySonID], [CommodityName], [CommodityPrice], [MarketPrice], [VIPPrice], [Stock], [BuyScore], [CommodityImage], [CommodityType], [CommoditySaled], [Introduce], [CommodityTime], [Recommend], [CommodityState], [Score], [ScoreTimes]) VALUES (N'20190103024002', N'3', N'9', N'小米6X', NULL, CAST(1089.00 AS Decimal(18, 2)), CAST(1089.00 AS Decimal(18, 2)), 100, N'10.8', N'/Upload/201913/2019010314392515.png', N'小米', 4456, N'<p>&nbsp;&nbsp;&nbsp;&nbsp;</p><p class="attr-list-hd tm-clear" style="margin-top: 0px; margin-bottom: 0px; padding: 5px 20px; line-height: 22px; color: rgb(153, 153, 153); font-family: tahoma, arial, 微软雅黑, sans-serif; font-size: 12px; white-space: normal; background-color: rgb(255, 255, 255);"><span style="margin: 0px; padding: 0px; font-weight: 700; float: left;">产品参数：</span></p><ul style="list-style-type: none;" class=" list-paddingleft-2"><li><p>证书编号：2018011606056750</p></li><li><p>证书状态：有效</p></li><li><p>产品名称：TD-LTE数字移动电话机</p></li><li><p>3C规格型号：M1804D2SE、M1804D2ST、M1804D2SC（电源适配器：MDY-08-EV 输出：5...</p></li><li><p>产品名称：Xiaomi/小米 6X</p></li><li><p>型号:&nbsp;6X</p></li><li><p>机身颜色:&nbsp;曜石黑&nbsp;流沙金&nbsp;赤焰红&nbsp;冰川蓝&nbsp;樱花粉</p></li><li><p>运行内存RAM:&nbsp;4GB&nbsp;6GB</p></li><li><p>存储容量:&nbsp;4+64GB&nbsp;6+64GB&nbsp;6+128GB&nbsp;4+32GB</p></li><li><p>网络模式:&nbsp;双卡双待</p></li></ul><p><br/></p>', CAST(0x0000A9CA00F1B558 AS DateTime), N'不推荐', N'上架', NULL, NULL)
INSERT [dbo].[Commodity] ([CommodityID], [CommodityFatherID], [CommoditySonID], [CommodityName], [CommodityPrice], [MarketPrice], [VIPPrice], [Stock], [BuyScore], [CommodityImage], [CommodityType], [CommoditySaled], [Introduce], [CommodityTime], [Recommend], [CommodityState], [Score], [ScoreTimes]) VALUES (N'20190103122658', N'3', N'8', N'iphone6s Plus', N'', CAST(2679.00 AS Decimal(18, 2)), CAST(2679.00 AS Decimal(18, 2)), 999, N'267', N'/Upload/201913/2019010312255379.png', N'Apple', 4567, N'<ul style="list-style-type: none;" class=" list-paddingleft-2"><li><p>证书编号：2015011606799882</p></li><li><p>证书状态：有效</p></li><li><p>产品名称：TD-LTE 数字移动电话机</p></li><li><p>3C规格型号：A1699（电源适配器：A1443 输出：5VDC 1A），（电源适配器可选）</p></li><li><p>产品名称：Apple/苹果 iPhone 6s Pl...</p></li><li><p>Apple型号:&nbsp;iPhone 6s Plus</p></li><li><p>机身颜色:&nbsp;银色&nbsp;金色&nbsp;深空灰色&nbsp;玫瑰金色</p></li><li><p>运行内存RAM:&nbsp;不详</p></li><li><p>存储容量:&nbsp;32GB&nbsp;128GB</p></li><li><p>网络模式:&nbsp;无需合约版</p></li><li><p>CPU型号:&nbsp;其他</p></li></ul><p><br/></p>', CAST(0x0000A9CA00EDCC90 AS DateTime), N'推荐', N'上架', NULL, NULL)
INSERT [dbo].[Commodity] ([CommodityID], [CommodityFatherID], [CommoditySonID], [CommodityName], [CommodityPrice], [MarketPrice], [VIPPrice], [Stock], [BuyScore], [CommodityImage], [CommodityType], [CommoditySaled], [Introduce], [CommodityTime], [Recommend], [CommodityState], [Score], [ScoreTimes]) VALUES (N'3', N'4', N'11', N'DNF代练', NULL, CAST(10.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), 111, NULL, N'/Upload/201913/2019010312255379.png', N'Game', 14258, NULL, CAST(0x0000A9CA00EDCC90 AS DateTime), NULL, NULL, NULL, NULL)
INSERT [dbo].[Commodity] ([CommodityID], [CommodityFatherID], [CommoditySonID], [CommodityName], [CommodityPrice], [MarketPrice], [VIPPrice], [Stock], [BuyScore], [CommodityImage], [CommodityType], [CommoditySaled], [Introduce], [CommodityTime], [Recommend], [CommodityState], [Score], [ScoreTimes]) VALUES (N'4', N'4', N'12', N'CF代练', NULL, CAST(10.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), 111, NULL, N'/Upload/201913/2019010314222312.png', N'Game', 24542, NULL, CAST(0x0000A9CA00F011D0 AS DateTime), NULL, NULL, NULL, NULL)
INSERT [dbo].[Commodity] ([CommodityID], [CommodityFatherID], [CommoditySonID], [CommodityName], [CommodityPrice], [MarketPrice], [VIPPrice], [Stock], [BuyScore], [CommodityImage], [CommodityType], [CommoditySaled], [Introduce], [CommodityTime], [Recommend], [CommodityState], [Score], [ScoreTimes]) VALUES (N'5', N'3', N'8', N'iphone X', N'', CAST(6288.00 AS Decimal(18, 2)), CAST(6288.00 AS Decimal(18, 2)), 111, NULL, N'/Upload/201913/2019010314295685.png', N'Apple', 42456, NULL, CAST(0x0000A9CA00F011D0 AS DateTime), NULL, NULL, NULL, NULL)
INSERT [dbo].[Commodity] ([CommodityID], [CommodityFatherID], [CommoditySonID], [CommodityName], [CommodityPrice], [MarketPrice], [VIPPrice], [Stock], [BuyScore], [CommodityImage], [CommodityType], [CommoditySaled], [Introduce], [CommodityTime], [Recommend], [CommodityState], [Score], [ScoreTimes]) VALUES (N'6', N'3', N'8', N'iphone X Max', N'', CAST(10999.00 AS Decimal(18, 2)), CAST(10999.00 AS Decimal(18, 2)), 111, NULL, N'/Upload/201913/2019010314295685.png', N'Apple', 999, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Commodity] ([CommodityID], [CommodityFatherID], [CommoditySonID], [CommodityName], [CommodityPrice], [MarketPrice], [VIPPrice], [Stock], [BuyScore], [CommodityImage], [CommodityType], [CommoditySaled], [Introduce], [CommodityTime], [Recommend], [CommodityState], [Score], [ScoreTimes]) VALUES (N'7', N'3', N'8', N'iphone XS', NULL, CAST(8699.00 AS Decimal(18, 2)), CAST(8699.00 AS Decimal(18, 2)), 111, NULL, N'/Upload/201913/2019010314295685.png', N'Apple', 245, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Commodity] ([CommodityID], [CommodityFatherID], [CommoditySonID], [CommodityName], [CommodityPrice], [MarketPrice], [VIPPrice], [Stock], [BuyScore], [CommodityImage], [CommodityType], [CommoditySaled], [Introduce], [CommodityTime], [Recommend], [CommodityState], [Score], [ScoreTimes]) VALUES (N'8', N'3', N'8', N'iphone XR', NULL, CAST(6499.00 AS Decimal(18, 2)), CAST(6499.00 AS Decimal(18, 2)), 111, NULL, N'/Upload/201913/2019010314295685.png', N'Apple', 9452, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Commodity] ([CommodityID], [CommodityFatherID], [CommoditySonID], [CommodityName], [CommodityPrice], [MarketPrice], [VIPPrice], [Stock], [BuyScore], [CommodityImage], [CommodityType], [CommoditySaled], [Introduce], [CommodityTime], [Recommend], [CommodityState], [Score], [ScoreTimes]) VALUES (N'9', N'1', N'3', N'Panasonic面包机', NULL, CAST(3299.00 AS Decimal(18, 2)), CAST(3299.00 AS Decimal(18, 2)), NULL, NULL, N'/Upload/201913/2019010314295685.png', N'Panasonic', 1424, NULL, NULL, NULL, NULL, NULL, NULL)
/****** Object:  Table [dbo].[Appraise]    Script Date: 01/18/2019 14:41:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Appraise](
	[AppriseID] [varchar](50) NOT NULL,
	[UserID] [varchar](50) NULL,
	[CommodityID] [varchar](50) NULL,
 CONSTRAINT [PK_Appraise] PRIMARY KEY CLUSTERED 
(
	[AppriseID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Appraise] ([AppriseID], [UserID], [CommodityID]) VALUES (N'20190110033545', N'2', N'1')
INSERT [dbo].[Appraise] ([AppriseID], [UserID], [CommodityID]) VALUES (N'20190110034756', N'1', N'1')
INSERT [dbo].[Appraise] ([AppriseID], [UserID], [CommodityID]) VALUES (N'20190114094446', N'11', N'1')
