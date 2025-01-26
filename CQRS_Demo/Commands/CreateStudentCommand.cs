using CQRS_Demo.Models;
using MediatR;
using System;

namespace CQRS_Demo.Commands
{
	public record CreateStudentCommand(StudentDetails StudentDetails) : IRequest<StudentDetails>;

}
