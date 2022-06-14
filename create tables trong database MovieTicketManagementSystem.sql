USE [MovieTicketManagementSystem]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Movies](
	[MovieID] [int] IDENTITY(1,1) NOT NULL,
	[MovieName] [nvarchar](50) NOT NULL,
	[Genres] [nvarchar](50) NOT NULL,
	[Synopsis] [nvarchar](max) NOT NULL,
	[RunTime] [nchar](10) NOT NULL,
	[ReleaseDate] [date] NOT NULL,
	[Poster] [image] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nchar](10) NOT NULL,
	[Password] [nchar](10) NOT NULL,
	[FullName] [nchar](20) NOT NULL,
	[Gender] [nchar](10) NOT NULL,
	[PhoneNumber] [varchar](50) NOT NULL,
	[Email] [nchar](20) NOT NULL,
 CONSTRAINT [PK_Customer_SignUp] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[Bookings](
	[BookingID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nchar](10) NOT NULL,
	[MovieName] [nvarchar](50) NOT NULL,
	[NumberOfSeats] [nchar](10) NOT NULL,
	[Type] [nchar](10) NOT NULL,
	[SeatPosition] [nchar](10) NOT NULL,
	[ShowTime] [nchar](10) NOT NULL,
	[Price] [nchar](10) NOT NULL
) ON [PRIMARY]

GO
