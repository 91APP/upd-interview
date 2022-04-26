
USE [MyCheckList]
GO

/****** Object:  Table [dbo].[Members]    Script Date: 4/26/2022 11:54:43 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Members](
	[MemberId] [int] IDENTITY(1,1) NOT NULL,
	[MemberName] [nvarchar](max) NULL,
 CONSTRAINT [PK_Members] PRIMARY KEY CLUSTERED 
(
	[MemberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


USE [MyCheckList]
GO

/****** Object:  Table [dbo].[Items]    Script Date: 4/26/2022 11:54:32 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Items](
	[ItemId] [int] IDENTITY(1,1) NOT NULL,
	[ItemName] [nvarchar](max) NULL,
 CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED 
(
	[ItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO



USE [MyCheckList]
GO

/****** Object:  Table [dbo].[CheckedItem]    Script Date: 4/26/2022 11:54:00 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CheckedItem](
	[CheckedItemId] [int] IDENTITY(1,1) NOT NULL,
	[ItemId] [int] NOT NULL,
	[MemberId] [int] NOT NULL,
 CONSTRAINT [PK_CheckedItem] PRIMARY KEY CLUSTERED 
(
	[CheckedItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CheckedItem]  WITH CHECK ADD  CONSTRAINT [FK_CheckedItem_Members_MemberId] FOREIGN KEY([MemberId])
REFERENCES [dbo].[Members] ([MemberId])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[CheckedItem] CHECK CONSTRAINT [FK_CheckedItem_Members_MemberId]
GO


USE [MyCheckList]
GO

INSERT INTO [dbo].[Items]
           ([ItemName])
     VALUES
           ('Item 1'),('Item 2'),('Item 3'),('Item 4')
GO



