﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinanceAPI.Data;
using FinanceAPI.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinanceAPI.Controllers
{
    [Route("api/expenses")]
    [ApiController]
    public class ExpensesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ExpensesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Expense>>> GetExpenses()
        {
            return await _context.Expenses.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Expense>> GetExpense(int id)
        {
            var expense = await _context.Expenses.FindAsync(id);

            if (expense == null)
            {
                return NotFound();
            }

            return expense;
        }

        [HttpPost]
        public async Task<ActionResult<Expense>> PostExpense(Expense expense)
        {
            _context.Expenses.Add(expense);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetExpense), new { id = expense.ExpenseID }, expense);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutExpense(int id, Expense expense)
        {
            if (id != expense.ExpenseID)
            {
                return BadRequest();
            }

            _context.Entry(expense).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExpenseExists(id))
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
        public async Task<IActionResult> DeleteExpense(int id)
        {
            var expense = await _context.Expenses.FindAsync(id);
            if (expense == null)
            {
                return NotFound();
            }

            _context.Expenses.Remove(expense);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ExpenseExists(int id)
        {
            return _context.Expenses.Any(e => e.ExpenseID == id);
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
//    public class ExpensesController : ControllerBase
//    {
//        private readonly AppDbContext _context;

//        public ExpensesController(AppDbContext context)
//        {
//            _context = context;
//        }

//        [HttpGet]
//        public async Task<ActionResult<IEnumerable<Expense>>> GetExpenses()
//        {
//            return await _context.Expenses.ToListAsync();
//        }

//        [HttpPost]
//        public async Task<ActionResult<Expense>> AddExpense(Expense expense)
//        {
//            _context.Expenses.Add(expense);
//            await _context.SaveChangesAsync();
//            return CreatedAtAction(nameof(GetExpenses), new { id = expense.ExpenseID }, expense);
//        }

//        [HttpDelete("{id}")]
//        public async Task<IActionResult> DeleteExpense(int id)
//        {
//            var expense = await _context.Expenses.FindAsync(id);
//            if (expense == null)
//                return NotFound();

//            _context.Expenses.Remove(expense);
//            await _context.SaveChangesAsync();
//            return NoContent();
//        }
//    }
//}