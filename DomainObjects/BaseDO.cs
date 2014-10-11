using System;
using System.Collections.Generic;

namespace ArsTechnicaApp.DomainObjects
{
	public class BaseDO
	{
		public BaseDO ()
		{
		}

		public List<AppError> ErrorList { get; set; }

		public bool AddError(string error, Exception ex){
			try {
				this.ErrorList.Add (new AppError{ 
				Detail = ex.ToString(), 
				Description = "Language is invalid.", 
				Name = "DomainObjects Err", 
				Code = 1 });
				return true;
			} catch (Exception err) {
				return false;
			}
		}
	}
}

