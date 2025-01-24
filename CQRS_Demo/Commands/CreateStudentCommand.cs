using CQRS_Demo.Models;
using MediatR;
using System;

namespace CQRS_Demo.Commands
{
	public class CreateStudentCommand : IRequest<StudentDetails>
	{
		public StudentDetails StudentDetails { get; set; }

		public CreateStudentCommand(StudentDetails studentDetails)
		{
			StudentDetails = studentDetails;
		}
	}

}
