USE [XAMFoodie]
GO


/****** Object:  Table [dbo].[Restaurants]    Script Date: 3/5/2023 2:59:50 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Restaurants]') AND type in (N'U'))
begin
	ALTER TABLE [dbo].[Restaurants] DROP CONSTRAINT if exists [DF_Restaurants_IsDeleted]

	ALTER TABLE [dbo].[Restaurants] DROP CONSTRAINT if exists [DF_Restaurants_ModifiedAt]

	ALTER TABLE [dbo].[Restaurants] DROP CONSTRAINT if exists [DF_Restaurants_CreatedAt]

	ALTER TABLE [dbo].[Restaurants] DROP CONSTRAINT if exists [UX_Restaurants]

	DROP TABLE [dbo].[Restaurants]
end
GO

/****** Object:  Table [dbo].[Restaurants]    Script Date: 3/5/2023 2:59:50 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Restaurants](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[DisplayName] [nvarchar](256) NOT NULL,
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

ALTER TABLE [dbo].[Restaurants] ADD  CONSTRAINT [DF_Restaurants_CreatedAt]  DEFAULT (getutcdate()) FOR [CreatedAt]
GO

ALTER TABLE [dbo].[Restaurants] ADD  CONSTRAINT [DF_Restaurants_ModifiedAt]  DEFAULT (getutcdate()) FOR [ModifiedAt]
GO

ALTER TABLE [dbo].[Restaurants] ADD  CONSTRAINT [DF_Restaurants_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO

ALTER TABLE dbo.Restaurants ADD CONSTRAINT
	UX_Restaurants UNIQUE NONCLUSTERED 
	(
	DisplayName,
	Address
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO


/*********************************************************************************************************************************************************************/

/****** Object:  Table [dbo].[Users]    Script Date: 3/5/2023 12:15:17 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Users]') AND type in (N'U'))
DROP TABLE [dbo].[Users]
GO

/****** Object:  Table [dbo].[Users]    Script Date: 3/5/2023 12:15:17 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[DisplayName] [nvarchar](256) NOT NULL,
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

INSERT INTO [dbo].[Users]
           ([DisplayName]
           ,[UserName]
           ,[Password]
           ,[Email]
           ,[Address]
           ,[IsAdmin]
           ,[CreatedAt]
           ,[CreatedBy]
           ,[ModifiedAt]
           ,[ModifiedBy]
           ,[IsDeleted])
     VALUES
           ('Tushar G. W.', 'tushargw', 'passwordpassword', 'tushar.w@winwire.com', 'Mumbai', 1, GETUTCDATE(), 1, GETUTCDATE(), 1, 0),
           ('Ritu B.', 'ritub', 'passwordpassword', 'ritu.b@winwire.com', 'Delhi', 1, GETUTCDATE(), 1, GETUTCDATE(), 1, 0),
           ('Sirisha V.', 'sirishav', 'passwordpassword', 'sirisha.v@winwire.com', 'Bangalore', 0, GETUTCDATE(), 1, GETUTCDATE(), 1, 0),
           ('Vikas G.', 'vikasv', 'passwordpassword', 'vikas.g@winwire.com', 'Hyderabad', 0, GETUTCDATE(), 1, GETUTCDATE(), 1, 0),
           ('Rana D.', 'ranad', 'passwordpassword', 'rana.d@winwire.com', 'Bangalore', 1, GETUTCDATE(), 1, GETUTCDATE(), 1, 0),
           ('Vishal S.', 'vishals', 'passwordpassword', 'vishal.s@winwire.com', 'Hyderabad', 0, GETUTCDATE(), 1, GETUTCDATE(), 1, 0),
           ('Hrishikesh B.', 'hrishikeshb', 'passwordpassword', 'hrishikesh.b@winwire.com', 'Delhi', 0, GETUTCDATE(), 1, GETUTCDATE(), 1, 0),
           ('Tejaswi S. G.', 'tejaswisg', 'passwordpassword', 'tejaswi.sg@winwire.com', 'Mumbai', 0, GETUTCDATE(), 1, GETUTCDATE(), 1, 0)
GO

/*********************************************************************************************************************************************************************/
