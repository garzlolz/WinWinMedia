USE [WinWin]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 2024/2/23 下午 06:08:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Locations]    Script Date: 2024/2/23 下午 06:08:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Locations](
	[location_id] [int] IDENTITY(1,1) NOT NULL,
	[location_name] [nvarchar](max) NOT NULL,
	[location_province_id] [int] NULL,
 CONSTRAINT [PK_Locations] PRIMARY KEY CLUSTERED 
(
	[location_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provinces]    Script Date: 2024/2/23 下午 06:08:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provinces](
	[province_id] [int] IDENTITY(1,1) NOT NULL,
	[province_name] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Provinces] PRIMARY KEY CLUSTERED 
(
	[province_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 2024/2/23 下午 06:08:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[user_email] [nvarchar](50) NOT NULL,
	[user_password] [nvarchar](100) NOT NULL,
	[user_name] [nvarchar](50) NOT NULL,
	[user_age] [int] NULL,
	[user_sex] [bit] NOT NULL,
	[user_location_id] [int] NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240223071149_init', N'8.0.2')
GO
SET IDENTITY_INSERT [dbo].[Locations] ON 
GO
INSERT [dbo].[Locations] ([location_id], [location_name], [location_province_id]) VALUES (1, N'廣州', 1)
GO
INSERT [dbo].[Locations] ([location_id], [location_name], [location_province_id]) VALUES (2, N'深圳', 1)
GO
INSERT [dbo].[Locations] ([location_id], [location_name], [location_province_id]) VALUES (3, N'珠海', 1)
GO
INSERT [dbo].[Locations] ([location_id], [location_name], [location_province_id]) VALUES (4, N'福州', 2)
GO
INSERT [dbo].[Locations] ([location_id], [location_name], [location_province_id]) VALUES (5, N'廈門', 2)
GO
INSERT [dbo].[Locations] ([location_id], [location_name], [location_province_id]) VALUES (6, N'南寧', 3)
GO
INSERT [dbo].[Locations] ([location_id], [location_name], [location_province_id]) VALUES (7, N'桂林', 3)
GO
INSERT [dbo].[Locations] ([location_id], [location_name], [location_province_id]) VALUES (8, N'上海', 4)
GO
INSERT [dbo].[Locations] ([location_id], [location_name], [location_province_id]) VALUES (9, N'北京', 4)
GO
SET IDENTITY_INSERT [dbo].[Locations] OFF
GO
SET IDENTITY_INSERT [dbo].[Provinces] ON 
GO
INSERT [dbo].[Provinces] ([province_id], [province_name]) VALUES (1, N'廣東')
GO
INSERT [dbo].[Provinces] ([province_id], [province_name]) VALUES (2, N'福建')
GO
INSERT [dbo].[Provinces] ([province_id], [province_name]) VALUES (3, N'廣西')
GO
INSERT [dbo].[Provinces] ([province_id], [province_name]) VALUES (4, N'上海')
GO
SET IDENTITY_INSERT [dbo].[Provinces] OFF
GO
SET IDENTITY_INSERT [dbo].[users] ON 
GO
INSERT [dbo].[users] ([user_id], [user_email], [user_password], [user_name], [user_age], [user_sex], [user_location_id]) VALUES (1, N'xxx.@gm.ew', N'string', N'www', 10, 1, 8)
GO
INSERT [dbo].[users] ([user_id], [user_email], [user_password], [user_name], [user_age], [user_sex], [user_location_id]) VALUES (2, N'string2', N'string', N'string', 10, 0, 4)
GO
INSERT [dbo].[users] ([user_id], [user_email], [user_password], [user_name], [user_age], [user_sex], [user_location_id]) VALUES (3, N'string5', N'string', N'string', 103, 0, 3)
GO
INSERT [dbo].[users] ([user_id], [user_email], [user_password], [user_name], [user_age], [user_sex], [user_location_id]) VALUES (4, N'str3ing5', N'string', N'string', 103, 0, 7)
GO
INSERT [dbo].[users] ([user_id], [user_email], [user_password], [user_name], [user_age], [user_sex], [user_location_id]) VALUES (5, N'ewqeqweqw', N'string', N'string', 103, 1, 7)
GO
INSERT [dbo].[users] ([user_id], [user_email], [user_password], [user_name], [user_age], [user_sex], [user_location_id]) VALUES (6, N'strinewqeqg', N'stringewq', N'steeeering', 0, 1, 7)
GO
INSERT [dbo].[users] ([user_id], [user_email], [user_password], [user_name], [user_age], [user_sex], [user_location_id]) VALUES (7, N'strineqg', N'stringewq', N'steeeering', 0, 1, 7)
GO
INSERT [dbo].[users] ([user_id], [user_email], [user_password], [user_name], [user_age], [user_sex], [user_location_id]) VALUES (8, N'sewqg', N'stringewq', N'steeeering', 0, 1, 7)
GO
SET IDENTITY_INSERT [dbo].[users] OFF
GO
ALTER TABLE [dbo].[Locations]  WITH CHECK ADD  CONSTRAINT [FK_Locations_Provinces_location_province_id] FOREIGN KEY([location_province_id])
REFERENCES [dbo].[Provinces] ([province_id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Locations] CHECK CONSTRAINT [FK_Locations_Provinces_location_province_id]
GO
ALTER TABLE [dbo].[users]  WITH CHECK ADD  CONSTRAINT [FK_users_Locations_user_location_id] FOREIGN KEY([user_location_id])
REFERENCES [dbo].[Locations] ([location_id])
GO
ALTER TABLE [dbo].[users] CHECK CONSTRAINT [FK_users_Locations_user_location_id]
GO
