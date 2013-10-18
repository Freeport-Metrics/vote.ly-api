use voteLy
GO

--VUser
INSERT INTO [voteLy].[dbo].[VUser]
           ([login]
           ,[pass])
     VALUES
           ('Grzegorz'
           ,'Lato')
GO

--Voting
INSERT INTO [voteLy].[dbo].[Voting]
           ([UserId]
           ,[SessionId]
           ,[Name])
     VALUES
           (1
           ,''
           ,'Voting for new personel')
GO

INSERT INTO [voteLy].[dbo].[Voting]
           ([UserId]
           ,[SessionId]
           ,[Name])
     VALUES
           (1
           ,''
           ,'Rating current personel')
GO

--question
INSERT INTO [voteLy].[dbo].[Question]
           ([VotingId]
           ,[Type]
           ,[Value])
     VALUES
           (1
           ,'Enumerated'
           ,'Which of below should be the new chairman?')
GO

INSERT INTO [voteLy].[dbo].[Question]
           ([VotingId]
           ,[Type]
           ,[Value])
     VALUES
           (1
           ,'Enumerated'
           ,'Which of below should be the new coach?')
GO

INSERT INTO [voteLy].[dbo].[Question]
           ([VotingId]
           ,[Type]
           ,[Value])
     VALUES
           (2
           ,'Numeric'
           ,'Please rate current chairman (1-bad, 5-excellent)')
GO

--answear
INSERT INTO [voteLy].[dbo].[Answear]
           ([QuestionId]
           ,[Value])
     VALUES	
		(1,'Grzegorz Lato'),
		(1,'Zbigniew Boniek'),
		(1,'Roman Kosecki'),
		(1,'Waldemar Fornalik')
GO

INSERT INTO [voteLy].[dbo].[Answear]
           ([QuestionId]
           ,[Value])
     VALUES	
		(2,'Franciszek Smuda'),
		(2,'Zdzislaw Krecina')
GO

INSERT INTO [voteLy].[dbo].[Answear]
           ([QuestionId]
           ,[Value])
     VALUES	
		(3,'1'),
		(3,'2'),
		(3,'3'),
		(3,'4'),
		(3,'5')
GO






