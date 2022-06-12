USE [MovieTicketManagementSystem]
GO

/****** Object:  Table [dbo].[Movie_Information]    Script Date: 12/06/2022 00:01:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Movie_Information](
	[Movie_ID] [int] NOT NULL,
	[Movie_Title] [nvarchar](50) NOT NULL,
	[Movie_Genre] [nvarchar](50) NOT NULL,
	[Movie_Synopsis] [nvarchar](max) NOT NULL,
	[Movie_RunTime] [int] NULL,
	[Movie_ReleaseDate] [nchar](10) NOT NULL,
	[Movie_Image] [image] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

