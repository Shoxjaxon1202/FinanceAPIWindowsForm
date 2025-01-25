using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinanceAPI.Data;
using FinanceAPI.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinanceAPI.Controllers
{
    [Route("api/incomes")]
    [ApiController]
    public class IncomeController : ControllerBase
    {
        private readonly AppDbContext _context;

        public IncomeController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Income>>> GetIncomes()
        {
            return await _context.Incomes.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Income>> GetIncome(int id)
        {
            var income = await _context.Incomes.FindAsync(id);

            if (income == null)
            {
                return NotFound();
            }

            return income;
        }

        [HttpPost]
        public async Task<ActionResult<Income>> PostIncome(Income income)
        {
            _context.Incomes.Add(income);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetIncome), new { id = income.IncomeID }, income);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutIncome(int id, Income income)
        {
            if (id != income.IncomeID)
            {
                return BadRequest();
            }

            _context.Entry(income).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IncomeExists(id))
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

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIncome(int id)
        {
            var income = await _context.Incomes.FindAsync(id);
            if (income == null)
            {
                return NotFound();
            }

            _context.Incomes.Remove(income);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool IncomeExists(int id)
        {
            return _context.Incomes.Any(e => e.IncomeID == id);
        }
    }
}




//using FinanceAPI.Data;
//using FinanceAPI.Entities;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;

//namespace FinanceAPI.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class IncomesController : ControllerBase
//    {
//        private readonly AppDbContext _context;

//        public IncomesController(AppDbContext context)
//        {
//            _context = context;
//        }

//        [HttpGet]
//        public async Task<ActionResult<IEnumerable<Income>>> GetIncomes()
//        {
//            return await _context.Incomes.ToListAsync();
//        }

//        [HttpPost]
//        public async Task<ActionResult<Income>> AddIncome(Income income)
//        {
//            _context.Incomes.Add(income);
//            await _context.SaveChangesAsync();
//            return CreatedAtAction(nameof(GetIncomes), new { id = income.IncomeID }, income);
//        }

//        [HttpDelete("{id}")]
//        public async Task<IActionResult> DeleteIncome(int id)
//        {
//            var income = await _context.Incomes.FindAsync(id);
//            if (income == null)
//                return NotFound();

//            _context.Incomes.Remove(income);
//            await _context.SaveChangesAsync();
//            return NoContent();
//        }
//    }
//}