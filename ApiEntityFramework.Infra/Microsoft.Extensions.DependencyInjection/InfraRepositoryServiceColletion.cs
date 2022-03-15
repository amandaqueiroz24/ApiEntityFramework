using ApiEntityFramework.Domain;
using ApiEntityFramework.Infra.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiEntityFramework.Infra.Repository.Microsoft.Extensions.DependencyInjection
{
	public static class InfraRepositoryServiceColletion
	{
		public static IServiceCollection AddInfraRepository(this IServiceCollection services)
		{
			if (services == null)
				throw new ArgumentException(nameof(services));

			services.AddScoped<TagWriteOnlyRepository, TagRepository>();
			//services.AddSingleton(new RegisterMapping());

			return services;
		}
	}
}
