using System;
using System.Collections.Generic;

namespace ArsTechnicaApp.DomainObjects
{
	public class ArsArticle : BaseDO
	{
		#region constructor
		public ArsArticle (
			string title, 
			string link, 
			string comments, 
			string publishDate, 
			string creator,
			List<string> categories, 
			string description,
			string content)
		{
			try {
				this.setTitle(title);
			} catch(Exception e) {
				AddError ("Title is invlaid", e);
			}
			try {
				this.setLink(link);
			} catch(Exception e) {
				AddError ("Link is invlaid", e);
			}
			try {
				this.setComments(comments);
			} catch(Exception e) {
				AddError ("Comments are invlaid", e);
			}
			try {
				this.setPublishdDate(publishDate);
			} catch(Exception e) {
				AddError ("PublishDate is invlaid", e);
			}
			try {
				this.setCreator(creator);
			} catch(Exception e) {
				AddError ("Creator is invlaid", e);
			}
			try {
				this.setCategories(Categories);
			} catch(Exception e) {
				AddError ("Categories are invlaid", e);
			}
			try {
				this.setDescription(description);
			} catch(Exception e) {
				AddError ("Description is invlaid", e);
			}
			try {
				this.setContent(content);
			} catch(Exception e) {
				AddError ("Content is invlaid", e);
			}
		}
		#endregion

		private bool setTitle(string title) {
			try {
				this.Title = title.ToString();
				return true;
			} catch(Exception e){
				return false;
			}
		}

		private bool setLink(string link) {
			try {
				this.Link = link.ToString();
				return true;
			} catch(Exception e){
				return false;
			}
		}

		private bool setComments(string comments) {
			try {
				this.Comments = comments.ToString();
				return true;
			} catch(Exception e){
				return false;
			}
		}

		private bool setPublishdDate(string publishDate) {
			try {
				this.PublishDate = Convert.ToDateTime(publishDate);
				return true;
			} catch(Exception e){
				return false;
			}
		}

		private bool setCreator(string creator) {
			try {
				this.Creator = creator.ToString();
				return true;
			} catch(Exception e){
				return false;
			}
		}

		private bool setCategories(List<string> categories) {
			try {
				foreach (var cat in categories) {
					this.Categories.Add(cat.ToString());
				}
				return true;
			} catch(Exception e){
				return false;
			}
		}

		private bool setDescription(string description) {
			try {
				this.Description = description;
				return true;
			} catch(Exception e){
				return false;
			}
		}

		private bool setContent(string content) {
			try {
				this.Content = content;
				return true;
			} catch(Exception e){
				return false;
			}
		}

		private string Title { get; set; }
		private string Link { get; set; }
		private string Comments { get; set; }
		private DateTime PublishDate { get; set; }
		private string Creator { get; set; }
		private List<string> Categories { get; set; }
		private string Description { get; set; }
		private string Content { get; set; }
	}
}

