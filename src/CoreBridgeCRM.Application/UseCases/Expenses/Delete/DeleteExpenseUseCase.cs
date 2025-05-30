﻿using CoreBridgeCRM.Domain.Repositories;
using CoreBridgeCRM.Domain.Repositories.Expenses;
using CoreBridgeCRM.Domain.Services.LoggedUser;
using CoreBridgeCRM.Exception;
using CoreBridgeCRM.Exception.ExceptionsBase;

namespace CoreBridgeCRM.Application.UseCases.Expenses.Delete;
public class DeleteExpenseUseCase : IDeleteExpenseUseCase
{
    private readonly IExpensesReadOnlyRepository _expensesReadOnly;
    private readonly IExpensesWriteOnlyRepository _repository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly ILoggedUser _loggedUser;

    public DeleteExpenseUseCase(
        IExpensesWriteOnlyRepository repository,
        IExpensesReadOnlyRepository expensesReadOnly,
        IUnitOfWork unitOfWork,
        ILoggedUser loggedUser)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
        _loggedUser = loggedUser;
        _expensesReadOnly = expensesReadOnly;
    }

    public async Task Execute(long id)
    {
        var loggedUser = await _loggedUser.Get();

        var expense = await _expensesReadOnly.GetById(loggedUser, id);
        if (expense is null)
        {
            throw new NotFoundException(ResourceErrorMessages.EXPENSE_NOT_FOUND);
        }

        await _repository.Delete(id);

        await _unitOfWork.Commit();
    }
}
