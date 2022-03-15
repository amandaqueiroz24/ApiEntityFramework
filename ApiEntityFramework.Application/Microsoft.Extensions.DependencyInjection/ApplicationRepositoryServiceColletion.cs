using ApiEntityFramework.Domain.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiEntityFramework.Application.Microsoft.Extensions.DependencyInjection
{
	public static class ApplicationRepositoryServiceColletion
	{
		public static IServiceCollection AddApplicationRepository(this IServiceCollection services,
																 ApplicationConfiguration applicationConfiguration)
		{
			if (services == null)
				throw new ArgumentException(nameof(services));

			services.AddSingleton(applicationConfiguration);
			services.AddScoped<ITagService, TagService>();
			//services.AddSingleton(new RegisterMapping());

			return services;
		}
	}
}
