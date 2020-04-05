using Datapoint.Globalization.Environment;
using Datapoint.Globalization.MachineObject;
using Xunit;

namespace Datapoint.Globalization.Tests
{
	public sealed class MessageRepositoryUnitTest
	{
		private readonly ILocaleRepository _locales;

		private readonly IMessageRepository _messages;

		private readonly ILocale _english;

		private readonly ILocale _portuguese;

		public MessageRepositoryUnitTest()
		{
			_locales = new LocaleRepository
			(
				new EnvironmentLocaleFactory()
			);

			_messages = new MessageRepository
			(
				new MachineObjectMessageFactory()
			);

			_english = _locales.GetLocale("en-US");

			_portuguese = _locales.GetLocale("pt-PT");
		}

		[Fact]
		public void DoesHaveMessage()
		{
			Assert.True(0 < _messages.GetMessages(_portuguese, "default").Count);
		}

		[Fact]
		public void DoesHaveHelloWorldTranslation()
		{
			Assert.Equal("Olá Mundo", _messages.GetMessage(_portuguese, "default", "Hello World"));
		}

		[Fact]
		public void DoesHaveGoodbyeWorldTranslation()
		{
			Assert.Equal("Adeus Mundo", _messages.GetMessage(_portuguese, "default", "Goodbye World"));
		}

		[Fact]
		public void DoesHaveSpecificTranslation()
		{
			Assert.Equal("Tradução Específica (pt-PT)", _messages.GetMessage(_portuguese, "default", "Specific Translation (locale)"));
		}

		[Fact]
		public void DoesHaveInvariantTranslation()
		{
			Assert.Equal("Tradução Invariante (pt)", _messages.GetMessage(_portuguese, "default", "Invariant Translation (locale)"));
		}

		[Fact]
		public void DoesNotHaveNonExistantTranslation()
		{
			Assert.Equal("This is a non existant translation", _messages.GetMessage(_portuguese, "default", "This is a non existant translation"));
		}

		[Fact]
		public void ThrowsMessageFactoryExceptionWithMissingDomain()
		{
			Assert.Throws<MessageFactoryException>
			(
				() => _messages.GetMessages(_portuguese, "this-domain-does-not-exist")
			);
		}

		[Fact]
		public void ThrowsMessageFactoryExceptionWithMissingLocale()
		{
			Assert.Throws<MessageFactoryException>
			(
				() => _messages.GetMessages(_english, "default")
			);
		}
	}
}
