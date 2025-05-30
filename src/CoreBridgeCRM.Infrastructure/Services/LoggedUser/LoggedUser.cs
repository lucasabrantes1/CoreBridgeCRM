﻿using CoreBridgeCRM.Domain.Entities;
using CoreBridgeCRM.Domain.Security.Tokens;
using CoreBridgeCRM.Domain.Services.LoggedUser;
using CoreBridgeCRM.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace CoreBridgeCRM.Infrastructure.Services.LoggedUser;
internal class LoggedUser : ILoggedUser
{
    private readonly CoreBridgeCRMDbContext _dbContext;
    private readonly ITokenProvider _tokenProvider;

    public LoggedUser(CoreBridgeCRMDbContext dbContext, ITokenProvider tokenProvider)
    {
        _dbContext = dbContext;
        _tokenProvider = tokenProvider;
    }

    public async Task<User> Get()
    {
        string token = _tokenProvider.TokenOnRequest();

        var tokenHandler = new JwtSecurityTokenHandler();

        var jwtSecurityToken = tokenHandler.ReadJwtToken(token);

        var identifier = jwtSecurityToken.Claims.First(claim => claim.Type == ClaimTypes.Sid).Value;

        return await _dbContext
            .Users
            .AsNoTracking()
            .FirstAsync(user => user.UserIdentifier == Guid.Parse(identifier));
    }
}
