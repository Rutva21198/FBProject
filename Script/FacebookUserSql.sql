USE [FBDb]
GO

/****** Object:  Table [dbo].[FacebookUsers]    Script Date: 28-02-2020 18:07:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[FacebookUsers](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[MobileNo] [bigint] NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Password] [binary](132) NOT NULL,
	[DateOfBirth] [date] NOT NULL,
	[GenderAO] [int] NOT NULL,
	[CreatedDateTime] [datetimeoffset](7) NOT NULL,
	[LoginStatus] [bit] NOT NULL,
	[Salt] [binary](140) NOT NULL,
 CONSTRAINT [PK__Facebook__1788CCACF1837155] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[FacebookUsers]  WITH CHECK ADD  CONSTRAINT [FK_Gender_FBApplicationObjects] FOREIGN KEY([GenderAO])
REFERENCES [dbo].[FBApplicationObjects] ([ApplicationObjectId])
GO

ALTER TABLE [dbo].[FacebookUsers] CHECK CONSTRAINT [FK_Gender_FBApplicationObjects]
GO

