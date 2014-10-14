using System;
using System.Xml;
using System.IO;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using ArsTechnicaApp.DomainObjects;

namespace ArsTechnicaApp.IServices
{
	/// <summary>
	/// Handles all of the RSS Feed actions.
	/// </summary>
	public interface IFeedService<T, U>
	{
		void GetFeed(T type);
		List<U> ParseFeed(T type);
	}

	/// <summary>
	/// Topic based feeds
	/// </summary>
	class TopicRssFeedService : IFeedService<ArsTopicFeeds, ArsArticle> 
	{
		void GetFeed(ArsTopicFeeds type) {
			throw new NotImplementedException ("Not yet impl");
		}
		List<ArsArticle> ParseFeed(ArsTopicFeeds type){
			var list = new List<ArsArticle> ();
			throw new NotImplementedException ("Not yet impl");
			return list;
		}
	}

	/// <summary>
	/// Section based feeds
	/// </summary>
	class SectionRssFeedService : IFeedService<ArsSection, ArsArticle>
	{
		void GetFeed(ArsSection type) {
			throw new NotImplementedException ("Not yet impl");
		}
		List<ArsArticle> ParseFeed(ArsSection type){
			var list = new List<ArsArticle> ();
			throw new NotImplementedException ("Not yet impl");
			return list;
		}
	}
}
