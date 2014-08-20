﻿using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Provider;

namespace Owin.OAuth.Multitenant.Facebook
{
	public class FacebookReturnEndpointContext : ReturnEndpointContext
	{
		/// <summary/>
		/// <param name="context">OWIN environment</param><param name="ticket">The authentication ticket</param>
		public FacebookReturnEndpointContext(IOwinContext context, AuthenticationTicket ticket)
			: base(context, ticket)
		{
		}
	}
}