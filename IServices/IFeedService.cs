using System;

namespace ArsTechnicaApp
{
	/// <summary>
	/// Handles all of the RSS Feed actions.
	/// </summary>
	public interface IFeedService<T, U>
	{
		void GetFeed(T type);
		U ParseFeed(T type);
	}
}
