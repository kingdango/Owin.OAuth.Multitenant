﻿using Microsoft.Owin;

namespace Owin.OAuth.Multitenant.Facebook
{
	public class StaticFacebookAuthenticationOptions : FacebookAuthenticationOptions, IFacebookAuthenticationOptions
	{
		public override string AppId { get; set; }
		public override string AppSecret { get; set; }
		public override PathString CallbackPath { get; set; }
		
		public StaticFacebookAuthenticationOptions()
		{
			this.CallbackPath = new PathString("signin-facebook");
		}

	}
}