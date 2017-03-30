using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using VSTDA.API.Models;

namespace VSTDA.API.Data
{
	public class VSTDADataContext : DbContext
	{
		public IDbSet <TodoItem> TodoItems { get; set; }

		public VSTDADataContext() :base("VSTDA")
		{

		}
	}
}