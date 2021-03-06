USE [MYdb]
GO
/****** Object:  StoredProcedure [dbo].[InsertUpdateEmpData]    Script Date: 15-Feb-22 06:22:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[InsertUpdateEmpData]
	-- Add the parameters for the stored procedure here
	@emp_id int,
	@emp_name varchar(100),
	@email_id varchar(100),
	@Contact_no varchar (50),
	@deppartment varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	  IF  EXISTS (SELECT * FROM Employess WHERE emp_id=@emp_id)
	  BEGIN
	  UPDATE Employess SET emp_name=@emp_name,email_id=@email_id ,contct_no=@Contact_no,department=@deppartment
	  WHERE emp_id=@emp_id
	  END
	  ELSE
	  BEGIN
	  INSERT INTO Employess values(@emp_id,@emp_name,@email_id,@Contact_no,@deppartment)

	  
END
End