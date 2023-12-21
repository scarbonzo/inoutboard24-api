using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using inoutboard24_api.Models;

namespace inoutboard24_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly MsSqlContext _context;

        public UsersController(MsSqlContext context)
        {
            _context = context;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            var results = _context.Users.ToListAsync();

            if (results.Result.Count < 1)
            {
                var users = new List<User>();
                users.Add(new User { Username = "jborg", DisplayName = "James", GroupId = 1, Enabled = true });
                users.Add(new User { Username = "dquander", DisplayName = "Denecia", GroupId = 1, Enabled = true });
                users.Add(new User { Username = "reodice", DisplayName = "Rich", GroupId = 2, Enabled = true });
                users.Add(new User { Username = "egadson", DisplayName = "Eric", GroupId = 2, Enabled = true });
                users.Add(new User { Username = "tlordi", DisplayName = "Tim", GroupId = 2, Enabled = true });
                users.Add(new User { Username = "dmanzo", DisplayName = "Dan", GroupId = 3, Enabled = true });
                users.Add(new User { Username = "sbekker", DisplayName = "Shafiqa", GroupId = 3, Enabled = true });

                _context.Users.AddRange(users);
                await _context.SaveChangesAsync();

                return users;
            }
            else
            {
                return await results;
            }
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
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

        // POST: api/Users
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUser", new { id = user.Id }, user);
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}
