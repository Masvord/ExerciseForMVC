using System.ComponentModel.DataAnnotations;


namespace OrnekUygulama.Models.ModelMetadataTypes
{
	public class ProductMetadata
	{
		[Required(
			ErrorMessage = "Lütfen Ürün Adını giriniz.")]
		[StringLength(100,
			ErrorMessage = "Maksimum 100 karakter içerebilir.")]
		public string ProductName { get; set; }


		[Range(1, 1000,
			ErrorMessage = "Girilen sayı 1 ile 1000 arasında olmalıdır.")]
		public int Quantity { get; set; }

	}
}
