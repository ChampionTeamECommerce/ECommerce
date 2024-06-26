﻿using Core.Ioc;
using Core.Utilities.Security.JWT;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class CoreServiceRegistration
    {
        public static IServiceCollection AddCoreServices(this IServiceCollection services)
        {
            //services.AddMemoryCache();
            //services.AddScoped<ICacheManager, MemoryCacheManager>();


            //services.AddScoped<IFileUploadAdapter, CloudinaryAdapter>();

            //services.AddScoped<Stopwatch>();

            //services.AddScoped<IVerificationService, TCKNVerificationService>();
            //services.AddScoped<IEmailService, EmailService>();

            //services.AddTransient<FileLogger>();
            //services.AddTransient<MsSqlLogger>();


            services.AddScoped<ITokenHelper, JwtHelper>();
            services.AddScoped<IHttpContextAccessor, HttpContextAccessor>();


            ServiceTool.Create(services);

            return services;
        }
    }
}