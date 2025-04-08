﻿using CoreBridgeCRM.Domain.Entities;

namespace CoreBridgeCRM.Domain.Repositories.Expenses;
public interface IExpensesReadOnlyRepository
{
    Task<List<Expense>> GetAll(Entities.User user);
    Task<Expense?> GetById(Entities.User user, long id);
    Task<List<Expense>> FilterByMonth(Entities.User user, DateOnly date);
}
