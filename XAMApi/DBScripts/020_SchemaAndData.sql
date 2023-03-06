USE [XAMFoodies]
GO

/****** Object:  Table [dbo].[Users]    Script Date: 3/6/2023 3:00:49 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Users]') AND type in (N'U'))
begin
	DROP INDEX if exists [IX_Users_UserName] ON [dbo].[Users]
	DROP INDEX if exists [IX_Users_Email] ON [dbo].[Users]
	DROP TABLE [dbo].[Users]
end
GO
/****** Object:  Table [dbo].[Restaurants]    Script Date: 3/6/2023 3:00:49 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Restaurants]') AND type in (N'U'))
begin
	ALTER TABLE [dbo].[Restaurants] DROP CONSTRAINT if exists [DF_Restaurants_IsDeleted]
	ALTER TABLE [dbo].[Restaurants] DROP CONSTRAINT if exists [DF_Restaurants_ModifiedAt]
	ALTER TABLE [dbo].[Restaurants] DROP CONSTRAINT if exists [DF_Restaurants_CreatedAt]

	ALTER TABLE [dbo].[Restaurants] DROP CONSTRAINT if exists [UX_Restaurants]

	DROP TABLE [dbo].[Restaurants]
end
GO

/****** Object:  Table [dbo].[Restaurants]    Script Date: 3/6/2023 3:00:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Restaurants](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[DisplayName] [nvarchar](128) NOT NULL,
	[Address] [nvarchar](256) NOT NULL,
	[PriceForTwo] [float] NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[CreatedBy] [bigint] NOT NULL,
	[ModifiedAt] [datetime2](7) NOT NULL,
	[ModifiedBy] [bigint] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Restaurants] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER AUTHORIZATION ON [dbo].[Restaurants] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Users]    Script Date: 3/6/2023 3:00:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[DisplayName] [nvarchar](128) NOT NULL,
	[Username] [nvarchar](256) NOT NULL,
	[Password] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NOT NULL,
	[Address] [nvarchar](256) NOT NULL,
	[IsAdmin] [bit] NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[CreatedBy] [bigint] NOT NULL,
	[ModifiedAt] [datetime2](7) NOT NULL,
	[ModifiedBy] [bigint] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER AUTHORIZATION ON [dbo].[Users] TO  SCHEMA OWNER 
GO

SET IDENTITY_INSERT [dbo].[Users] ON 
GO
INSERT [dbo].[Users] ([Id], [DisplayName], [Username], [Password], [Email], [Address], [IsAdmin], [CreatedAt], [CreatedBy], [ModifiedAt], [ModifiedBy], [IsDeleted]) VALUES (1, N'Tushar G. W.', N'tushargw', N'passwordpassword', N'tushar.w@winwire.com', N'Mumbai', 1, CAST(N'2023-03-05T06:17:43.4866667' AS DateTime2), 1, CAST(N'2023-03-05T06:17:43.4866667' AS DateTime2), 1, 0)
GO
INSERT [dbo].[Users] ([Id], [DisplayName], [Username], [Password], [Email], [Address], [IsAdmin], [CreatedAt], [CreatedBy], [ModifiedAt], [ModifiedBy], [IsDeleted]) VALUES (2, N'Ritu B.', N'ritub', N'passwordpassword', N'ritu.b@winwire.com', N'Delhi', 1, CAST(N'2023-03-05T06:55:28.3000000' AS DateTime2), 1, CAST(N'2023-03-05T06:55:28.3000000' AS DateTime2), 1, 0)
GO
INSERT [dbo].[Users] ([Id], [DisplayName], [Username], [Password], [Email], [Address], [IsAdmin], [CreatedAt], [CreatedBy], [ModifiedAt], [ModifiedBy], [IsDeleted]) VALUES (3, N'Sirisha V.', N'sirishav', N'passwordpassword', N'sirisha.v@winwire.com', N'Bangalore', 0, CAST(N'2023-03-05T06:55:28.3000000' AS DateTime2), 1, CAST(N'2023-03-05T06:55:28.3000000' AS DateTime2), 1, 0)
GO
INSERT [dbo].[Users] ([Id], [DisplayName], [Username], [Password], [Email], [Address], [IsAdmin], [CreatedAt], [CreatedBy], [ModifiedAt], [ModifiedBy], [IsDeleted]) VALUES (4, N'Vikas G.', N'vikasv', N'passwordpassword', N'vikas.g@winwire.com', N'Hyderabad', 0, CAST(N'2023-03-05T06:55:28.3000000' AS DateTime2), 1, CAST(N'2023-03-05T06:55:28.3000000' AS DateTime2), 1, 0)
GO
INSERT [dbo].[Users] ([Id], [DisplayName], [Username], [Password], [Email], [Address], [IsAdmin], [CreatedAt], [CreatedBy], [ModifiedAt], [ModifiedBy], [IsDeleted]) VALUES (5, N'Rana D.', N'ranad', N'passwordpassword', N'rana.d@winwire.com', N'Bangalore', 1, CAST(N'2023-03-05T06:55:28.3000000' AS DateTime2), 1, CAST(N'2023-03-05T06:55:28.3000000' AS DateTime2), 1, 0)
GO
INSERT [dbo].[Users] ([Id], [DisplayName], [Username], [Password], [Email], [Address], [IsAdmin], [CreatedAt], [CreatedBy], [ModifiedAt], [ModifiedBy], [IsDeleted]) VALUES (6, N'Vishal S.', N'vishals', N'passwordpassword', N'vishal.s@winwire.com', N'Hyderabad', 0, CAST(N'2023-03-05T06:55:28.3000000' AS DateTime2), 1, CAST(N'2023-03-05T06:55:28.3000000' AS DateTime2), 1, 0)
GO
INSERT [dbo].[Users] ([Id], [DisplayName], [Username], [Password], [Email], [Address], [IsAdmin], [CreatedAt], [CreatedBy], [ModifiedAt], [ModifiedBy], [IsDeleted]) VALUES (7, N'Hrishikesh B.', N'hrishikeshb', N'passwordpassword', N'hrishikesh.b@winwire.com', N'Delhi', 0, CAST(N'2023-03-05T06:55:28.3000000' AS DateTime2), 1, CAST(N'2023-03-05T06:55:28.3000000' AS DateTime2), 1, 0)
GO
INSERT [dbo].[Users] ([Id], [DisplayName], [Username], [Password], [Email], [Address], [IsAdmin], [CreatedAt], [CreatedBy], [ModifiedAt], [ModifiedBy], [IsDeleted]) VALUES (8, N'Tejaswi S. G.', N'tejaswisg', N'passwordpassword', N'tejaswi.sg@winwire.com', N'Mumbai', 0, CAST(N'2023-03-05T06:55:28.3000000' AS DateTime2), 1, CAST(N'2023-03-05T06:55:28.3000000' AS DateTime2), 1, 0)
GO
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UX_Restaurants]    Script Date: 3/6/2023 3:00:50 PM ******/
ALTER TABLE [dbo].[Restaurants] ADD  CONSTRAINT [UX_Restaurants] UNIQUE NONCLUSTERED 
(
	[DisplayName] ASC,
	[Address] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Users_Email]    Script Date: 3/6/2023 3:00:50 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Users_Email] ON [dbo].[Users]
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Users_UserName]    Script Date: 3/6/2023 3:00:50 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Users_UserName] ON [dbo].[Users]
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Restaurants] ADD  CONSTRAINT [DF_Restaurants_CreatedAt]  DEFAULT (getutcdate()) FOR [CreatedAt]
GO
ALTER TABLE [dbo].[Restaurants] ADD  CONSTRAINT [DF_Restaurants_ModifiedAt]  DEFAULT (getutcdate()) FOR [ModifiedAt]
GO
ALTER TABLE [dbo].[Restaurants] ADD  CONSTRAINT [DF_Restaurants_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
