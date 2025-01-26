using CQRS_Demo.Models;
using MediatR;

namespace CQRS_Demo.Commands
{
	public record UpdateStudentCommand(StudentDetails StudentDetails):IRequest<int>;
	
}
