
using Business.Abstracts;
using Business.DTOs.User.Request;
using Business.Messages;
using Core.Business;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Entity.Concrete;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.JWT;

namespace Business.Rules;

public class AuthBusinessRules : BaseBusinessRules
{
    private readonly IUserService _userService;
    public AuthBusinessRules(IUserService userService)
    {
        _userService = userService;
    }

    public async Task EmailCanNotBeDuplicatedWhenRegistered(string email)
    {
        var userToCheck = await _userService.GetByMail(email);
        if (userToCheck != null) throw new BusinessException(Messages.AuthMessages.UserAlreadyExists);
    }

    public async Task<UserAuth> LoginInformationCheck(UserForLoginRequest userForLoginRequest)
    {
        var userToCheck = await _userService.GetByMail(userForLoginRequest.Email);
        if (userToCheck == null)
        {
            throw new BusinessException(Messages.AuthMessages.UserNotFound);
        }
        if (!HashingHelper.VerifyPasswordHash(userForLoginRequest.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
        {
            throw new BusinessException(Messages.AuthMessages.PasswordError);
        }
        return userToCheck;
    }

    public Task ThrowExceptionIfCreateAccessTokenIsNull(AccessToken accessToken)
    {
        if (accessToken == null)
            throw new BusinessException(Messages.AuthMessages.CreateAccessTokenNot);
        return Task.CompletedTask;
    }
}