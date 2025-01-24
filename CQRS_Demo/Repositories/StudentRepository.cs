using CQRS_Demo.Models;
using Dapper;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Data;
using System.Data.SqlClient;

namespace CQRS_Demo.Repositories
{
	public class StudentRepository : IStudentRepository
	{
		private readonly string _connectionstring;
		public StudentRepository(IConfiguration config)
		{
			_connectionstring = config.GetConnectionString("DefaultConnection");
		}

		public Task<StudentDetails> GetStudentByIdAsync(int Id)
		{
			throw new NotImplementedException();
		}

		public async Task<List<StudentDetails>> GetStudentListAsync()
		{
			using (IDbConnection _dbConnection = new SqlConnection(_connectionstring))
			{
				var students = await _dbConnection.QueryAsync<StudentDetails>("GetAllStudents", commandType: CommandType.StoredProcedure);
				return students.ToList();
			}
		}

		public async Task<StudentDetails> AddStudentAsync(StudentDetails studentDetails)
		{
			if (studentDetails == null)
			{
				throw new ArgumentNullException(nameof(studentDetails), "Student details cannot be null");
			}
			using (IDbConnection _dbConnection = new SqlConnection(_connectionstring))
			{
				var parameters = new DynamicParameters();
				//parameters.Add("@Id", studentDetails.Id);
				parameters.Add("@Name", studentDetails.Name);
				parameters.Add("@Email", studentDetails.Email);
				parameters.Add("@Address", studentDetails.Address);
				parameters.Add("@Age", studentDetails.Age);

				await _dbConnection.ExecuteAsync("InsertStudent", parameters, commandType: CommandType.StoredProcedure);

				return studentDetails;
			}
			
		}

		public Task<int> DeleteStudentAsync(int Id)
		{
			throw new NotImplementedException();
		}

		

		public Task<int> UpdateStudentAsync(StudentDetails studentDetails)
		{
			throw new NotImplementedException();
		}
	}
}
