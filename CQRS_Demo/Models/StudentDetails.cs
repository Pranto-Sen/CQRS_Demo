using Microsoft.AspNetCore.Http.HttpResults;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;

namespace CQRS_Demo.Models
{
	public class StudentDetails
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Address { get; set; }
		public int Age { get; set; }
	}
}


//--Create a database
//CREATE DATABASE StudentDB;
//GO

//-- Use the database
//USE StudentDB;
//GO

//-- Create the table
//CREATE TABLE StudentDetails (
//    Id INT PRIMARY KEY IDENTITY(1,1),
//	Name NVARCHAR(100) NOT NULL,
//	Email NVARCHAR(100) NOT NULL,
//	Address NVARCHAR(255),
//	Age INT NOT NULL
//);
//GO

//-- Create stored procedures

//-- Insert Procedure
//CREATE PROCEDURE InsertStudent
//    @Name NVARCHAR(100),
//	@Email NVARCHAR(100),
//	@Address NVARCHAR(255),
//	@Age INT
//AS
//BEGIN
//    INSERT INTO StudentDetails (Name, Email, Address, Age)
//    VALUES (@Name, @Email, @Address, @Age);

//SELECT SCOPE_IDENTITY() AS NewStudentId;
//END;
//GO

//-- Update Procedure
//CREATE PROCEDURE UpdateStudent
//    @Id INT,
//	@Name NVARCHAR(100),
//	@Email NVARCHAR(100),
//	@Address NVARCHAR(255),
//	@Age INT
//AS
//BEGIN
//    UPDATE StudentDetails
//    SET Name = @Name,
//		Email = @Email,
//		Address = @Address,
//		Age = @Age
//    WHERE Id = @Id;
//END;
//GO

//-- Delete Procedure
//CREATE PROCEDURE DeleteStudent
//    @Id INT
//AS
//BEGIN
//    DELETE FROM StudentDetails
//    WHERE Id = @Id;
//END;
//GO

//-- Fetch All Records Procedure
//CREATE PROCEDURE GetAllStudents
//AS
//BEGIN
//    SELECT * FROM StudentDetails;
//END;
//GO

//-- Fetch Record by ID Procedure
//CREATE PROCEDURE GetStudentById
//    @Id INT
//AS
//BEGIN
//    SELECT * FROM StudentDetails
//    WHERE Id = @Id;
//END;
//GO
