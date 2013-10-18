use voteLy
GO

create table VUser(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Login nvarchar(50) not null,
	Pass nvarchar(50) not null
)
GO

create table Voting(
	Id int PRIMARY KEY IDENTITY(1,1),
	UserId int,
	SessionId nvarchar(30) NULL,
	Name nvarchar(255),
	CONSTRAINT FK_Voting_User FOREIGN KEY (UserId) REFERENCES VUser(Id)
)
GO

create table Question(
	Id int PRIMARY KEY IDENTITY(1,1),
	VotingId int,
	Type nvarchar(10),
	Value nvarchar(1024),
	CONSTRAINT FK_Question_Voting FOREIGN KEY (VotingId) REFERENCES Voting(Id)
)
GO

create table Answear(
	Id int PRIMARY KEY IDENTITY(1,1),
	QuestionId int,
	Value nvarchar(1024),
	CONSTRAINT FK_Answear_Question FOREIGN KEY (QuestionId) REFERENCES Question(Id)
)GO

create table AnswearScores(
	Id int PRIMARY KEY IDENTITY(1,1),
	AnswearId int,
	VoterId nvarchar(512) NULL,
	SessionId nvarchar(30) NULL,
	CONSTRAINT FK_AnsweaScore_Answear FOREIGN KEY (AnswearId) REFERENCES Answear(Id)
)
GO

-- Indexes
create index vuser_login_idx on VUser(Login);
create index voting_userId_idx on Voting(userId);
create index question_voting_idx on Question(VotingId);
create index answear_question_idx on Answear(QuestionId);
create index answearScore_answear_idx on AnswearScores(AnswearId);


