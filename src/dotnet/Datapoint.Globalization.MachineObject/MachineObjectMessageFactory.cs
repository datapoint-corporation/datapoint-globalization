using Datapoint.MachineObject;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Datapoint.Globalization.MachineObject
{
	/// <summary>
	///		A machine object message factory implementation.
	///		
	///		Creates the messages by reading and combining messages from multiple
	///		machine object file streams matching the full culture name and the
	///		two letter language name for a given locale and domain.
	/// </summary>
	public sealed class MachineObjectMessageFactory : IMessageFactory
	{
		/// <summary>
		///		Gets the machine object encoding.
		/// </summary>
		public Encoding Encoding { get; } = Encoding.UTF8;

		/// <inheritdoc />
		public IEnumerable<KeyValuePair<string, string>> CreateMessages(ILocale locale, string domain)
		{
			var filePaths = CreateMachineObjectFilePaths(locale, domain);
			var messages = new HashSet<string>();
			var hasFilePathMatch = false;

			foreach (var filePath in filePaths)
			{
				if (!File.Exists(filePath))
					continue;

				hasFilePathMatch = true;

				using (var fs = new FileStream(filePath, FileMode.Open))
				{
					using (var mor = new MachineObjectReader(fs, Encoding))
					{
						var mo = mor.ReadMachineObject();

						foreach (var message in mo.Messages)
						{
							if (string.IsNullOrEmpty(message.Key))
								continue;

							if (string.IsNullOrEmpty(message.Value))
								continue;

							if (messages.Add(message.Key))
							{
								yield return Encoding.Equals(mo.Encoding) ?

								message :

								new KeyValuePair<string, string>
								(
									Encoding.Unicode.GetString
									(
										Encoding.Convert
										(
											mo.Encoding,
											Encoding.Unicode,
											mo.Encoding.GetBytes(message.Key)
										)
									),

									Encoding.Unicode.GetString
									(
										Encoding.Convert
										(
											mo.Encoding,
											Encoding.Unicode,
											mo.Encoding.GetBytes(message.Value)
										)
									)
								);
							}
						}
					}
				}
			}

			if (!hasFilePathMatch)
				throw new FileNotFoundException("Can not find machine object file.", filePaths[0]);
		}

		/// <summary>
		///		Creates the machine object file paths.
		/// </summary>
		/// <param name="locale">
		///		The locale to create the machine object file paths from.
		/// </param>
		/// <param name="domain">
		///		The domain to create the machine object file paths from.
		/// </param>
		/// <returns>
		///		The machine object file paths.
		/// </returns>
		private string[] CreateMachineObjectFilePaths(ILocale locale, string domain)
		{
			var filePaths = new List<string>(2);

			if (!locale.Culture.IsNeutralCulture)
			{
				filePaths.Add
				(
					Path.Combine
					(
						Directory.GetCurrentDirectory(),
						"messages",
						locale.Culture.Name,
						$"{domain}.mo"
					)
				);
			}

			filePaths.Add
			(
				Path.Combine
				(
					Directory.GetCurrentDirectory(),
					"messages",
					locale.Culture.TwoLetterISOLanguageName,
					$"{domain}.mo"
				)
			);

			return filePaths.ToArray();
		}
	}
}
