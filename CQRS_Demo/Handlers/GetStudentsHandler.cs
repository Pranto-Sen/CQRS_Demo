using CQRS_Demo.Commands;
using CQRS_Demo.Models;
using CQRS_Demo.Queries;
using CQRS_Demo.Repositories;
using MediatR;

namespace CQRS_Demo.Handlers
{
	public class GetStudentsHandler : IRequestHandler<GetStudentListQuery, List<StudentDetails>>
	{
		private readonly IStudentRepository _studentRepository;

		public GetStudentsHandler(IStudentRepository studentRepository)
		{
			_studentRepository = studentRepository;
		}
		public async Task<List<StudentDetails>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
		{
			return await _studentRepository.GetStudentListAsync();
		}
	}
}
