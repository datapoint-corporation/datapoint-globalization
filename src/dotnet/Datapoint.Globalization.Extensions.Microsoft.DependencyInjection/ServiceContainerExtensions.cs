using Microsoft.Extensions.DependencyInjection;

namespace Datapoint.Globalization.Extensions.Microsoft.DependencyInjection
{
	public static class ServiceContainerExtensions
	{
		/// <summary>
		///		Adds the globalization services with singleton lifetime.
		/// </summary>
		/// <typeparam name="TCurrencyFactory">
		///		The currency factory type.
		/// </typeparam>
		/// <typeparam name="TLocaleFactory">
		///		The locale factory type.
		/// </typeparam>
		/// <typeparam name="TMessageFactory">
		///		The message factory type.
		/// </typeparam>
		/// <param name="serviceCollection">
		///		The service collection.
		/// </param>
		/// <param name="serviceLifetime">
		///		The service lifetime.
		/// </param>
		/// <returns>
		///		The service collection.
		/// </returns>
		public static IServiceCollection AddGlobalization<TCurrencyFactory, TLocaleFactory, TMessageFactory>(this IServiceCollection serviceCollection)
			where TCurrencyFactory : class, ICurrencyFactory
			where TLocaleFactory : class, ILocaleFactory
			where TMessageFactory : class, IMessageFactory =>

			AddGlobalization<TCurrencyFactory, TLocaleFactory, TMessageFactory>(serviceCollection, ServiceLifetime.Singleton);

		/// <summary>
		///		Adds the globalization services.
		/// </summary>
		/// <typeparam name="TCurrencyFactory">
		///		The currency factory type.
		/// </typeparam>
		/// <typeparam name="TLocaleFactory">
		///		The locale factory type.
		/// </typeparam>
		/// <typeparam name="TMessageFactory">
		///		The message factory type.
		/// </typeparam>
		/// <param name="serviceCollection">
		///		The service collection.
		/// </param>
		/// <param name="serviceLifetime">
		///		The service lifetime.
		/// </param>
		/// <returns>
		///		The service collection.
		/// </returns>
		public static IServiceCollection AddGlobalization<TCurrencyFactory, TLocaleFactory, TMessageFactory>(this IServiceCollection serviceCollection, ServiceLifetime serviceLifetime)
			where TCurrencyFactory : class, ICurrencyFactory
			where TLocaleFactory : class, ILocaleFactory
			where TMessageFactory : class, IMessageFactory
		{
			// Factories
			serviceCollection.Add
			(
				new ServiceDescriptor
				(
					typeof(ICurrencyFactory),
					typeof(TCurrencyFactory),
					serviceLifetime
				)
			);

			serviceCollection.Add
			(
				new ServiceDescriptor
				(
					typeof(ILocaleFactory),
					typeof(TLocaleFactory),
					serviceLifetime
				)
			);

			serviceCollection.Add
			(
				new ServiceDescriptor
				(
					typeof(IMessageFactory),
					typeof(TMessageFactory),
					serviceLifetime
				)
			);

			// Repositories
			serviceCollection.Add
			(
				new ServiceDescriptor
				(
					typeof(ICurrencyRepository),
					typeof(CurrencyRepository),
					serviceLifetime
				)
			);

			serviceCollection.Add
			(
				new ServiceDescriptor
				(
					typeof(ILocaleRepository),
					typeof(LocaleRepository),
					serviceLifetime
				)
			);

			serviceCollection.Add
			(
				new ServiceDescriptor
				(
					typeof(IMessageRepository),
					typeof(MessageRepository),
					serviceLifetime
				)
			);

			// Unit of work
			serviceCollection.Add
			(
				new ServiceDescriptor
				(
					typeof(IGlobalizationUnitOfWork),
					typeof(GlobalizationUnitOfWork),
					serviceLifetime
				)
			);

			return serviceCollection;
		}
	}
}
