using CQRS_Demo.Models;
using MediatR;

namespace CQRS_Demo.Queries
{
	public record GetStudentByIdQuery(int id):IRequest<StudentDetails>;
	
}
