using Data.BaseRepository;
using Data.UnitOfWork;

namespace Web_API.Extensions
{
    /// <summary>
    /// Provides extension methods for registering repository services.
    /// </summary>
    public static class RepositoryExtensions
    {
        /// <summary>
        /// Registers repository services used in the application.
        /// </summary>
        /// <param name="services">The IServiceCollection instance to add repository services to.</param>
        /// <returns>The updated IServiceCollection instance.</returns>
        /// <remarks>
        /// This method registers the following repositories:
        /// - IErrorLogRepository with ErrorLogRepository
        /// - IUserRepository with UserRepository
        /// Ensure that these repositories are properly implemented and follow the application's data access patterns.
        /// </remarks>
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}

