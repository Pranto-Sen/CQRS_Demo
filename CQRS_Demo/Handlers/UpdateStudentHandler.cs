using CQRS_Demo.Commands;
using CQRS_Demo.Models;
using CQRS_Demo.Repositories;
using MediatR;

namespace CQRS_Demo.Handlers
{
	public class UpdateStudentHandler : IRequestHandler<UpdateStudentCommand, int>
	{
		private readonly IStudentRepository _studentRepository;

		public UpdateStudentHandler(IStudentRepository studentRepository)
		{
			_studentRepository = studentRepository;
		}
	

		public async Task<int> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
		{
			return await _studentRepository.UpdateStudentAsync(request.StudentDetails);
		}
	}
}
