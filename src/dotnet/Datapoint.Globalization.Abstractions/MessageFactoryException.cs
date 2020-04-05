using System;

namespace Datapoint.Globalization
{
	/// <summary>
	///		Thrown when an unexpected error is encountered while interacting
	///		with a message factory.
	/// </summary>
	public sealed class MessageFactoryException : Exception
	{
		public MessageFactoryException(IMessageFactory messageFactory)
		{
			MessageFactory = messageFactory ?? throw new ArgumentNullException(nameof(messageFactory));
		}

		public MessageFactoryException(IMessageFactory messageFactory, string? message) : base(message)
		{
			MessageFactory = messageFactory ?? throw new ArgumentNullException(nameof(messageFactory));
		}

		public MessageFactoryException(IMessageFactory messageFactory, string? message, Exception? innerException) : base(message, innerException)
		{
			MessageFactory = messageFactory ?? throw new ArgumentNullException(nameof(messageFactory));
		}

		public IMessageFactory MessageFactory { get; }
	}
}
