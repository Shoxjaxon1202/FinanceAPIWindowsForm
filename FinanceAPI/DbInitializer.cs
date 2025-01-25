using FinanceAPI.Entities;
using System;
using System.Linq;

namespace FinanceAPI.Data
{
    public static class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            // Agar oldin ma'lumot qo'shilgan bo'lsa, hech narsa qilmaymiz
            if (context.Expenses.Any() || context.Incomes.Any())
            {
                return;
            }

            // Expenses (Xarajatlar)
            var expenses = new Expense[]
            {
                new Expense { Date = DateTime.Parse("2024-01-01"), Amount = 150, Category = "Food", Description = "Lunch at a restaurant" },
                new Expense { Date = DateTime.Parse("2024-01-02"), Amount = 200.50M, Category = "Transport", Description = "Gasoline for car" },
                new Expense { Date = DateTime.Parse("2024-01-03"), Amount = 50, Category = "Entertainment", Description = "Movie ticket" }
            };

            context.Expenses.AddRange(expenses);

            // Incomes (Daromadlar)
            var incomes = new Income[]
            {
                new Income { Date = DateTime.Parse("2024-01-01"), Amount = 2500, Source = "Salary", Description = "January Salary" },
                new Income { Date = DateTime.Parse("2024-01-02"), Amount = 500, Source = "Freelance", Description = "Website development" },
                new Income { Date = DateTime.Parse("2024-01-03"), Amount = 100, Source = "Gift", Description = "Birthday gift from a friend" }
            };

            context.Incomes.AddRange(incomes);

            // O‘zgarishlarni saqlash
            context.SaveChanges();
        }
    }
}
