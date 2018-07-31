USE [Sandbox]
GO

CREATE TABLE Users(
	[Usernames] [varchar](50) NOT NULL,
	[Passwords] [varchar](50) NOT NULL
)

Create Unique Index UniqueUsername
on Users (Usernames);

