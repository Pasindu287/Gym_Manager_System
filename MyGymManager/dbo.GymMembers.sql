CREATE TABLE [dbo].[GymMembers]
(
	[MemberID] INT NOT NULL PRIMARY KEY, 
    [Fname] VARCHAR(50) NOT NULL, 
    [Lname] VARCHAR(50) NOT NULL, 
    [Gender] VARCHAR(50) NOT NULL, 
    [DOB] VARBINARY(50) NOT NULL, 
    [Mobile] BIGINT NOT NULL, 
    [JoinDate] VARCHAR(50) NOT NULL, 
    [Shedule] VARCHAR(50) NOT NULL, 
    [MemberShipTime] VARCHAR(50) NOT NULL
)
