﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GNBCWeb.Domain {
	public class Product {
		public int Id { get; set; }
				public string Title { get; set; }
		public string Description { get; set; }
		public double Price { get; set; }
		public string Image { get; set; }
	}
}