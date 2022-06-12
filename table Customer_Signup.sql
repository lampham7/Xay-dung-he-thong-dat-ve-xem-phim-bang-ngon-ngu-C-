USE [MovieTicketManagementSystem]
GO

/****** Object:  Table [dbo].[Customer_SignUp]    Script Date: 12/06/2022 00:01:00 ******/
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

