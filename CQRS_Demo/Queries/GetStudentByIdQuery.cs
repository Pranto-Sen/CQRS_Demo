using CQRS_Demo.Models;
using MediatR;

namespace CQRS_Demo.Queries
{
	public class GetStudentByIdQuery:IRequest<StudentDetails>
	{
		public int Id { get; set; }
	}
}
