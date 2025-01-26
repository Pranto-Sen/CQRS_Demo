using MediatR;

namespace CQRS_Demo.Commands
{
	public record DeleteStudentCommand(int Id):IRequest<int>;
}
