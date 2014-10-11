using System;

namespace ArsTechnicaApp.DomainObjects
{
	public class AppError : BaseDO
	{
		#region constructors
		public AppError ()
		{
		}

		public AppError(int code, string name, string description, string detail)
		{
			try {
				this.Code = code;
				this.Name = name;
				this.Description = description;
				this.Detail = detail;
			} catch (Exception e) {
				throw new Exception ("Failed to instantiate an AppError");
			}
		}
		#endregion

		public int Code { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Detail { get; set; }
	}
}

