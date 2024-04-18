using Business.DTOs.User.Request;
using Core.Entity.Concrete;
using Core.Utilities.Security.JWT;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{public interface IAuthService
    {
        //{
        //    Task<AccessToken> Register(UserForRegisterRequest userForRegisterRequest, string password);
        //    Task<AccessToken> Login(UserForLoginRequest userForLoginRequest);
        //    Task<AccessToken> CreateAccessToken(UserAuth userAuth);
        Task<AccessToken> Register(UserForRegisterRequest userForRegisterRequest, string password);
        Task<AccessToken> Login(UserForLoginRequest userForLoginRequest);
        Task<AccessToken> CreateAccessToken(UserAuth userAuth);

        //Task<AccessToken> Register(UserForRegisterRequest userForRegisterRequest, string password);
        //    Task<UserAuth> Login(UserForLoginRequest userForLoginRequest);
        //    Task<AccessToken> CreateAccessToken(UserAuth userAuth);
           // Task ChangePassword(ChangePasswordRequest changePasswordRequest);
         //   Task<bool> PasswordResetAsync(string email);
  


        //Task<AccessToken> Login(UserForLoginDto userForLoginDto);
        //Task<DataResult<AccessToken>> EmployeeRegister(EmployeeForRegisterDto employeeForRegisterDto);
        //Task<DataResult<AccessToken>> InstructorRegister(InstructorForRegisterDto instructorForRegisterDto);
        //Task<DataResult<AccessToken>> ApplicantRegister(ApplicantForRegisterDto applicantForRegisterDto);
        //Task<DataResult<AccessToken>> CreateAccessToken(User user);
    }
}
