﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VSTDA.API.Models
{
	public class TodoItem
	{
		public int TodoItemID { get; set; }
		public string Text { get; set; }
		public int Priority { get; set; }
		
	}
}