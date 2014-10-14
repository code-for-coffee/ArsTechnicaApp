using System;
using System.Collections.Generic;

namespace ArsTechnicaApp.DomainObjects
{
	public class ArsTopicFeeds : BaseDO
	{
		ArsTopicFeeds() {
			this.Topics.Add ("Apple");
			this.Topics.Add ("Open Source");
			this.Topics.Add ("Microsoft");
			this.Topics.Add ("Google");
			this.Topics.Add ("Security");
			this.Topics.Add ("Telecom");
			this.Topics.Add ("Patent");
			this.Topics.Add ("Web");

		}

		ArsTopicFeeds(List<string> topics) {
			this.Topics = topics;
		}

		public List<string> Topics { get; set; }
	}
}

