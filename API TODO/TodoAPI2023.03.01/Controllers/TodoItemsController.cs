using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoAPI.Data;
using TodoAPI2023._03._01.Models;

//Created By Muhammed EROGLU
namespace TodoAPI2023._03._01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoItemsController : ControllerBase
    {
        private readonly TodoAPIContext _context;

        public TodoItemsController(TodoAPIContext context)
        {
            _context = context;
        }

        // GET: api/TodoItems
        /// <summary>
        /// To get all the TODO List Items.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TodoItem>>> GetTodoItem()
        {
            try
            {
                if (_context.TodoItem == null)
                {
                    return NotFound("Todo listesi bulunamadi.");
                }
                var todoItems = await _context.TodoItem.ToListAsync();
                return Ok(todoItems);
            }
            catch
            {
                return Problem("Todo listesi alinirken bir hata olustu.");
            }
        }

        // GET: api/TodoItems/5
        /// <summary>
        /// To get onlt one todo item.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<TodoItem>> GetTodoItem(int id)
        {
            try
            {
                if (_context.TodoItem == null)
                {
                    return NotFound("Todo item listesi bos.");
                }
                var todoItem = await _context.TodoItem.FindAsync(id);

                if (todoItem == null)
                {
                    return NotFound("Todo item bulunamadi. Lutfen id bilgisini kontrol ediniz.");
                }

                return todoItem;
            }
            catch
            {
                return Problem("Todo bilgisi alinirken bir hata olustu.");
            }
        }

        // PUT: api/TodoItems/5
        /// <summary>
        /// To update the todo item.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="todoItem"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTodoItem(int id, TodoItem todoItem)
        {
            if (id != todoItem.Id)
            {
                return BadRequest("Lutfen id bilgisini kontrol ediniz.");
            }

            _context.Entry(todoItem).State = EntityState.Modified; // set entity state as editing.

            try
            {
                await _context.SaveChangesAsync(); // Trying to update DB object.
            }
            catch
            {
                if (!TodoItemExists(id)) // If there is no item exist in DB.
                {
                    return NotFound("DB nesnesi bulunamadi. Lutfen id bilgilerinizi kontrol ediniz.");
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }

        // POST: api/TodoItems
        /// <summary>
        /// To create a todo item.
        /// </summary>
        /// <param name="todoItem"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<TodoItem>> PostTodoItem(TodoItem todoItem)
        {
          if (_context.TodoItem == null)
          {
              return Problem("Database ile ilgili bir sorun mevcut.");
          }
            try
            {
                _context.TodoItem.Add(todoItem);
                await _context.SaveChangesAsync();
                return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            }
            catch
            {
                return NotFound("DB nesnesi olusturulamadi.");
            }
        }

        // DELETE: api/TodoItems/5
        /// <summary>
        /// To delete specific todo item.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodoItem(int id)
        {
            if (_context.TodoItem == null)
            {
                return NotFound("Todo listesi mevcut değil.");
            }
            var todoItem = await _context.TodoItem.FindAsync(id);
            if (todoItem == null)
            {
                return NotFound("Belirtilen id numarasına sahip todo item mevcut değil.");
            }

            try
            {
                _context.TodoItem.Remove(todoItem);
                await _context.SaveChangesAsync();
            }
            catch 
            {
                return Problem("Todo silinirken hata oluştu.");
            }
            return NoContent();
        }

        /// <summary>
        /// Checks wheather the todo item exist or not.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool TodoItemExists(int id)
        {
            return (_context.TodoItem?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
