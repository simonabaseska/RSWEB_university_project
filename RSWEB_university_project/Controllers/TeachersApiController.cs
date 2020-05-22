﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RSWEB_university_project.Data;
using RSWEB_university_project.Models;

namespace RSWEB_university_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersApiController : ControllerBase
    {
        private readonly RSWEB_university_projectContext _context;

        public TeachersApiController(RSWEB_university_projectContext context)
        {
            _context = context;
        }

        // GET: api/TeachersApi
        [HttpGet]
        public List<Teacher> GetTeacher(string firstNameString, string lastNameString,
            string degreeString, string academicRankString)
        {
            IQueryable<Teacher> teachers = _context.Teacher.AsQueryable();
            if (!string.IsNullOrEmpty(firstNameString))
            {
                teachers = teachers.Where(t => t.FirstName == firstNameString);
            }
            if (!string.IsNullOrEmpty(lastNameString))
            {
                teachers = teachers.Where(t => t.LastName == lastNameString);
            }
            if (!string.IsNullOrEmpty(degreeString))
            {
                teachers = teachers.Where(t => t.Degree == degreeString);
            }
            if (!string.IsNullOrEmpty(academicRankString))
            {
                teachers = teachers.Where(t => t.AcademicRank == academicRankString);
            }
            return teachers.ToList();
        }

        // GET: api/TeachersApi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Teacher>> GetTeacher(int id)
        {
            var teacher = await _context.Teacher.FindAsync(id);

            if (teacher == null)
            {
                return NotFound();
            }

            return teacher;
        }

        // PUT: api/TeachersApi/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTeacher(int id, Teacher teacher)
        {
            if (id != teacher.TeacherId)
            {
                return BadRequest();
            }

            _context.Entry(teacher).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeacherExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TeachersApi
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Teacher>> PostTeacher(Teacher teacher)
        {
            _context.Teacher.Add(teacher);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTeacher", new { id = teacher.TeacherId }, teacher);
        }

        // DELETE: api/TeachersApi/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Teacher>> DeleteTeacher(int id)
        {
            var teacher = await _context.Teacher.FindAsync(id);
            if (teacher == null)
            {
                return NotFound();
            }

            _context.Teacher.Remove(teacher);
            await _context.SaveChangesAsync();

            return teacher;
        }

        private bool TeacherExists(int id)
        {
            return _context.Teacher.Any(e => e.TeacherId == id);
        }
    }
}
