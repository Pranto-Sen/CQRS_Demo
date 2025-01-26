using CQRS_Demo.Models;
using CQRS_Demo.Queries;
using CQRS_Demo.Repositories;
using MediatR;

namespace CQRS_Demo.Handlers
{
	public class GetStudentByIdHandler : IRequestHandler<GetStudentByIdQuery, StudentDetails>
	{
		private readonly IStudentRepository _studentRepository;

		public GetStudentByIdHandler(IStudentRepository studentRepository)
		{
			_studentRepository = studentRepository;
		}
		public async Task<StudentDetails> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
		{
			return await _studentRepository.GetStudentByIdAsync(request.id);
		}
	}
}
