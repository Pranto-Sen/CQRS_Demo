using CQRS_Demo.Commands;
using CQRS_Demo.Models;
using CQRS_Demo.Repositories;
using MediatR;

namespace CQRS_Demo.Handlers
{
	public class AddStudentHandler : IRequestHandler<CreateStudentCommand, StudentDetails>
	{
		private readonly IStudentRepository _studentRepository;

		public AddStudentHandler(IStudentRepository studentRepository)
		{
			_studentRepository = studentRepository;
		}
		public async Task<StudentDetails> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
		{
			return await _studentRepository.AddStudentAsync(request.StudentDetails);
		}
	}
}
