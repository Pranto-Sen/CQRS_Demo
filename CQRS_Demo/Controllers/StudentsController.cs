﻿using CQRS_Demo.Commands;
using CQRS_Demo.Models;
using CQRS_Demo.Queries;
using CQRS_Demo.Repositories;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_Demo.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class StudentsController : ControllerBase
	{
		private readonly IMediator _mediator;

		public StudentsController(IMediator mediator)
		{
			_mediator = mediator;
		}

		// GET: api/Student
		[HttpGet]
		public async Task<ActionResult<List<StudentDetails>>> GetStudents()
		{
			try
			{
				var students = await _mediator.Send(new GetStudentListQuery());
				return Ok(students);
			}
			catch (Exception ex)
			{
				return NotFound(new { Message = ex.Message });
			}
		}

		[HttpPost]
		public async Task<ActionResult> InsertStudent([FromBody] StudentDetails student)
		{
			try
			{
				if (student == null)
				{
					return BadRequest("Student details are required.");
				}

				var studentId = await _mediator.Send(new CreateStudentCommand(student));

				return Ok();
			}
			catch (Exception ex)
			{
				return BadRequest(new { Message = ex.Message });
			}
		}
	}
}
