using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NexusIdentity.Data;
using NexusIdentity.Models;

namespace NexusIdentity.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    // 1. Declaramos a variável do banco
    private readonly AppDbContext _context;

    // 2. Injeção de Dependência: O .NET entrega o banco pronto pra gente usar
    public UserController(AppDbContext context)
    {
        _context = context;
    }

    // GET: api/user
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        // Vai no banco, transforma em lista e retorna
        var users = await _context.Users.ToListAsync();
        return Ok(users);
    }

    // GET: api/user/{id}
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var user = await _context.Users.FindAsync(id);
        
        if (user == null) 
            return NotFound();

        return Ok(user);
    }

    // POST: api/user
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] User newUser)
    {
        // Adiciona no contexto (prepara para salvar)
        _context.Users.Add(newUser);
        
        // Comita a transação no banco (Salva de verdade)
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetById), new { id = newUser.Id }, newUser);
    }

    // PUT: api/user/{id}
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] User updatedUser)
    {
        if (id != updatedUser.Id) return BadRequest();

        // Marca o objeto como "Modificado" para o EF saber que precisa atualizar tudo
        _context.Entry(updatedUser).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Users.Any(u => u.Id == id))
                return NotFound();
            else
                throw;
        }

        return NoContent();
    }

    // DELETE: api/user/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var user = await _context.Users.FindAsync(id);
        if (user == null) return NotFound();

        _context.Users.Remove(user);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}