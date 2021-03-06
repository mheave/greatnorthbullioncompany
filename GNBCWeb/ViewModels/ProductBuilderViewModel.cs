﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GNBCWeb.ViewModels {
	public class ProductBuilderViewModel {

		public string Title { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public string Image { get; set; }
		public int ProductId {get; set;}
		public string PayPalButtonId { get; set;}
	}
}