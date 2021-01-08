using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrackRecordAPI.Models;

namespace TrackRecordAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentDbContext _context;

        public StudentController(StudentDbContext context)
        {
            _context = context;
        }

        // GET: api/Student
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
        {
            return await _context.Students.ToListAsync();
        }

        // GET: api/Student
        [HttpGet]
        [Route("GetTrackRecord")]
        public async Task<ActionResult<IEnumerable<TrackRecord>>> GetTrackRecord()
        {
            return await _context.TrackRecords.ToListAsync();
        }

        // GET: api/Student/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetStudent(int id)
        {
            var student = await _context.Students.FindAsync(id);

            if (student == null)
            {
                return NotFound();
            }

            return student;
        }

        //// PUT: api/Student/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutStudent(int id, Student student)
        //{
        //    if (id != student.StudentId)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(student).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!StudentExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateWithTracking(int id, Student student)
        {
            var existingStudent = await _context.Students.FindAsync(id);

            if (id != student.StudentId)
            {
                return BadRequest();
            }

            var existingStudentData = new Student()
            {
                FirstName = existingStudent.FirstName,
                LastName = existingStudent.LastName,
                StudentAge = existingStudent.StudentAge,
                DOB = existingStudent.DOB
            };

            var trackRecordData = new TrackRecord()
            {
                UpdatedColumn = "",
                OldValue = "",
                UpdatedValue = "",
                UpdatedTime = new TimeSpan()
            };


            if (existingStudentData.FirstName != student.FirstName)
            {
                student.IsUpdated = true;
                trackRecordData.UpdatedColumn = "FirstName";
                trackRecordData.OldValue = existingStudentData.FirstName;
                trackRecordData.UpdatedValue = student.FirstName;
                trackRecordData.UpdatedTime =DateTime.Now.TimeOfDay;
            }

            else if (existingStudentData.LastName != student.LastName)
            {
                student.IsUpdated = true;
                trackRecordData.UpdatedColumn = "LastName";
                trackRecordData.OldValue = existingStudentData.LastName;
                trackRecordData.UpdatedValue = student.LastName;
                trackRecordData.UpdatedTime = DateTime.Now.TimeOfDay;
            }
            else if (existingStudentData.StudentAge != student.StudentAge)
            {
                student.IsUpdated = true;
                trackRecordData.UpdatedColumn = "StudentAge";
                trackRecordData.OldValue = Convert.ToString(existingStudentData.StudentAge);
                trackRecordData.UpdatedValue = Convert.ToString(student.StudentAge);
                trackRecordData.UpdatedTime = DateTime.Now.TimeOfDay;
            }
            else if (existingStudentData.DOB != student.DOB)
            {
                student.IsUpdated = true;
                trackRecordData.UpdatedColumn = "DOB";
                trackRecordData.OldValue = Convert.ToString(existingStudentData.DOB);
                trackRecordData.UpdatedValue = Convert.ToString(student.DOB);
                trackRecordData.UpdatedTime = DateTime.Now.TimeOfDay;
            }

            _context.TrackRecords.Add(trackRecordData);

            _context.Entry(existingStudent).State = EntityState.Detached;
            _context.Entry(student).State = EntityState.Modified;

            _context.SaveChanges();


            try
            {
                await _context.SaveChangesAsync();
            }

            catch (DbUpdateConcurrencyException)
            {
                if (!StudentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok();
        }

        // POST: api/Student
        [HttpPost]
        public async Task<ActionResult<Student>> PostStudent(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStudent", new { id = student.StudentId }, student);
        }

        // DELETE: api/Student/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }

            _context.Students.Remove(student);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StudentExists(int id)
        {
            return _context.Students.Any(e => e.StudentId == id);
        }
    }
}
