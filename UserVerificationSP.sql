
CREATE Proc spVerification (@Username varchar(50))
as 
Select Usernames, Passwords
From Users
Where @Username = Usernames

GO


