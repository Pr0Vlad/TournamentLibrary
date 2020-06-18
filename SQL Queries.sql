//ran these queries to make stored procedures for the SQL

/////////////////
CREATE PROCEDURE spPrizes_GetByTournament (for 7 procedures each one a different name)
AS
SELECT * FROM Tournaments
GO;
/////////////////

-----------------------------------------
dbo.spMatchups_GetByTournament
-----------------------------------------

USE [Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spPrizes_GetByTournament]    Script Date: 4/8/2019 11:43:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Gets all the prizes for a given tournament
ALTER PROCEDURE [dbo].[spPrizes_GetByTournament] -- CREATE PROCEDURE (on first run). Method
	-- Add the parameters for the stored procedure here
	@TournamentId int -- Parameter name & Parameter type
AS
BEGIN -- Everything for stored procedure between BEGIN and END
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON; -- doesn't send how many rows back to caller

	select p.* -- select all from dbo.Prizes table (renamed to p)
	from dbo.Prizes p -- Give me all info from Prizes table, dbo.Prizes table renamed to p
	inner join dbo.TournamentPrizes t on p.id = t.PrizeId -- inner join connects two different tables, connects based on Prize tables id equal (=) to TournamentPrizes id (renamed to t, so t.PrizeId)
	where t.TournamentId = @TournamentId; -- where TournamentPrizes.TournamentId equals (=) @TournamentId (@TournamentId is the id you enter into parameter when you call method)
END

------------------------------------------------
dbo.spMatchups_GetByTournament
------------------------------------------------

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE dbo.spMatchups_GetByTournament
	@TournamentId int
AS
BEGIN
	SET NOCOUNT ON;

	select mu.*
	from matchups mu
	where mu.TournamentId = @TournamentId
	order by mu.MatchupRound
END
GO

---------------------------------------
dbo.spMatchupEntries_GetByMatchup
---------------------------------------

USE [Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spMatchupEntries_GetByMatchup]    Script Date: 4/9/2019 1:03:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spMatchupEntries_GetByMatchup]
	@MatchupId int
AS
BEGIN
	SET NOCOUNT ON;

	select mue.*
	from MatchupEntries mue
	inner join dbo.MatchupEntries mu on mue.MatchupId = mu.id
	where mu.id = @MatchupId
END

---------------------------------------
dbo.spPeople_GetAll
---------------------------------------

USE [Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spPeople_GetAll]    Script Date: 4/9/2019 12:50:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spPeople_GetAll]

AS
BEGIN
	SET NOCOUNT ON;

	select ppl.*
	from People ppl
	order by LastName
END

---------------------------------------
dbo.spTeam_GetByTournament
---------------------------------------

USE [Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spTeam_GetByTournament]    Script Date: 4/9/2019 1:08:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spTeam_GetByTournament]
	@TournamentId int
AS
BEGIN
	SET NOCOUNT ON;

	select te.*
	from TournamentEntries te
	inner join dbo.Tournaments t on te.TournamentId = t.id
	where t.id = @TournamentId
END

-----------------------------------------
dbo.spTeamMembers_GetByTeam
-----------------------------------------

USE [Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spTeamMembers_GetByTeam]    Script Date: 4/9/2019 12:59:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spTeamMembers_GetByTeam] 
	@TeamId int
AS
BEGIN
	SET NOCOUNT ON;

    select tm.*
	from TeamMembers tm
	inner join dbo.Teams t on tm.TeamId = t.id
	where t.id = @TeamId
END

-----------------------------------------
dbo.spTournaments_GetAll
-----------------------------------------

USE [Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spTournaments_GetAll]    Script Date: 4/9/2019 12:53:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spTournaments_GetAll]

AS
BEGIN
	SET NOCOUNT ON;

    select t.*
	from Tournaments t
END
