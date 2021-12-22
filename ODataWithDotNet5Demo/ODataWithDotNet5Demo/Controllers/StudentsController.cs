using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using ODataWithDotNet5Demo.Models;
using System;
using System.Collections.Generic;


namespace ODataWithDotNet5Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        [EnableQuery]
        public ActionResult<List<Student>> GetAllStudents()
        {
            return Ok(new List<Student>
            {
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "MM",
                    Grade = 100
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "MM2",
                    Grade = 200
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "MM3",
                    Grade = 999
                }
            });
        }
    }
}
