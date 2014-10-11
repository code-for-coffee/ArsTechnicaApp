using System;
using System.Collections.Generic;

namespace ArsTechnicaApp.DomainObjects
{
	public class ArsSection : BaseDO
	{
		#region Constructor
		public ArsSection (
			string title, 
			string link, 
			string lastBuildDate, 
			string language, 
			string generator)
		{
		var errList = new List<AppError> ();
			try {
				this.setTitle(title);
			} catch(Exception e) {
				AddError ("Title is invlaid", e);
			}
			try {
				this.setLink(link);
			} catch (Exception e) {
				AddError ("Link is invlaid", e);
			}
			try {
				this.setLastBuildDate(lastBuildDate);
			} catch (Exception e) {
				AddError ("Build date is invlaid", e);
			}
			try {
				this.setLanguage(Language);
			} catch (Exception e) {
				AddError ("Language is invlaid", e);
			}
			try {
			this.setGenerator(generator);
			} catch (Exception e) {
				AddError ("Generator is invlaid", e);
			}

		}
		#endregion

		private string Title { get; set; }
		private string Link { get; set; }
		private DateTime LastBuildDate { get; set; }
		private string Language { get; set; }
		private string Generator { get; set; }

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

		private bool setLastBuildDate(string lastBuildDate) {
			try {
				this.LastBuildDate = Convert.ToDateTime(lastBuildDate);
				return true;
			} catch(Exception e){
				return false;
			}
		}

		private bool setLanguage(string language) {
			try {
				this.Language = language.ToString();
				return true;
			} catch(Exception e){
				return false;
			}
		}

		private bool setGenerator(string generator) {
			try {
				this.Generator = generator;
				return true;
			} catch(Exception e){
				return false;
			}
		}
	}
}

