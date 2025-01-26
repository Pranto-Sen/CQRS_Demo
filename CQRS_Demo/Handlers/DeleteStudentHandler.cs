using CQRS_Demo.Commands;
using CQRS_Demo.Repositories;
using MediatR;

namespace CQRS_Demo.Handlers
{
	public class DeleteStudentHandler : IRequestHandler<DeleteStudentCommand, int>
	{
		private readonly IStudentRepository _studentRepository;

		public DeleteStudentHandler(IStudentRepository studentRepository)
		{
			_studentRepository = studentRepository;
		}
		public async Task<int> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
		{
			return await _studentRepository.DeleteStudentAsync(request.Id);
		}
	}
}
