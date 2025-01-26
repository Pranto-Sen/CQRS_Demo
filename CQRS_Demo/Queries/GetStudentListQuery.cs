using CQRS_Demo.Models;
using MediatR;
using System;

namespace CQRS_Demo.Queries
{
	public record GetStudentListQuery : IRequest<List<StudentDetails>>;

}
