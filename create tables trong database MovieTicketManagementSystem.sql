USE [MovieTicketManagementSystem]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Customer_SignUp](
	[ID] [nchar](10) NOT NULL,
	[FullName] [nchar](10) NOT NULL,
	[UserName] [nchar](10) NOT NULL,
	[Password] [nchar](10) NOT NULL,
	[MobileNo] [int] NOT NULL,
	[Gender] [nchar](10) NOT NULL,
	[EmailAddress] [nchar](10) NOT NULL,
	[Nationality] [nchar](10) NULL
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[Movie_Book](
	[BookID] [nchar](10) NULL,
	[Username] [nchar](10) NULL,
	[Movie_Title] [nvarchar](50) NULL,
	[TotalCustomer] [nchar](10) NULL,
	[SelectQuality] [nchar](10) NULL,
	[SelectSit] [nchar](10) NULL,
	[ShowTime] [nchar](10) NULL,
	[PriceToPay] [nchar](10) NULL
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[Movie_Information](
	[Movie_ID] [int] NOT NULL,
	[Movie_Title] [nvarchar](50) NOT NULL,
	[Movie_Genre] [nvarchar](50) NOT NULL,
	[Movie_Synopsis] [nvarchar](max) NOT NULL,
	[Movie_RunTime] [nchar](10) NULL,
	[Movie_ReleaseDate] [date] NOT NULL,
	[Movie_Image] [image] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


