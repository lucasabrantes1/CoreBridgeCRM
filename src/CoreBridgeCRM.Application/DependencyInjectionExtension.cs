using CoreBridgeCRM.Application.AutoMapper;
using CoreBridgeCRM.Application.UseCases.Expenses.Delete;
using CoreBridgeCRM.Application.UseCases.Expenses.GetAll;
using CoreBridgeCRM.Application.UseCases.Expenses.GetById;
using CoreBridgeCRM.Application.UseCases.Expenses.Register;
using CoreBridgeCRM.Application.UseCases.Expenses.Reports.Excel;
using CoreBridgeCRM.Application.UseCases.Expenses.Reports.Pdf;
using CoreBridgeCRM.Application.UseCases.Expenses.Update;
using CoreBridgeCRM.Application.UseCases.Login.DoLogin;
using CoreBridgeCRM.Application.UseCases.Users.ChangePassword;
using CoreBridgeCRM.Application.UseCases.Users.Delete;
using CoreBridgeCRM.Application.UseCases.Users.Profile;
using CoreBridgeCRM.Application.UseCases.Users.Register;
using CoreBridgeCRM.Application.UseCases.Users.Update;
using Microsoft.Extensions.DependencyInjection;

namespace CoreBridgeCRM.Application;
public static class DependencyInjectionExtension
{
    public static void AddApplication(this IServiceCollection services)
    {
        AddAutoMapper(services);
        AddUseCases(services);
    }

    private static void AddAutoMapper(IServiceCollection services)
    {
        services.AddAutoMapper(typeof(AutoMapping));
    }

    private static void AddUseCases(IServiceCollection services)
    {
        services.AddScoped<IRegisterExpenseUseCase, RegisterExpenseUseCase>();
        services.AddScoped<IGetAllExpenseUseCase, GetAllExpenseUseCase>();
        services.AddScoped<IGetExpenseByIdUseCase, GetExpenseByIdUseCase>();
        services.AddScoped<IDeleteExpenseUseCase, DeleteExpenseUseCase>();
        services.AddScoped<IUpdateExpenseUseCase, UpdateExpenseUseCase>();
        services.AddScoped<IGenerateExpensesReportExcelUseCase, GenerateExpensesReportExcelUseCase>();
        services.AddScoped<IGenerateExpensesReportPdfUseCase, GenerateExpensesReportPdfUseCase>();
        services.AddScoped<IRegisterUserUseCase, RegisterUserUseCase>();
        services.AddScoped<IDoLoginUseCase, DoLoginUseCase>();
        services.AddScoped<IGetUserProfileUseCase, GetUserProfileUseCase>();
        services.AddScoped<IUpdateUserUseCase, UpdateUserUseCase>();
        services.AddScoped<IChangePasswordUseCase, ChangePasswordUseCase>();
        services.AddScoped<IDeleteUserAccountUseCase, DeleteUserAccountUseCase>();
    }
}
