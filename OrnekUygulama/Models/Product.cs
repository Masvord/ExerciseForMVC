using Microsoft.AspNetCore.Mvc;
using OrnekUygulama.Models.ModelMetadataTypes;

namespace OrnekUygulama.Models
{
	[ModelMetadataType(typeof(ProductMetadata))]
	public class Product
	{
		public int Id { get; set; }

		public string ProductName { get; set; }


		public int Quantity { get; set; }

	}
}
