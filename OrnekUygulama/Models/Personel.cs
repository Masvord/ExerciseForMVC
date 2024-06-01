namespace OrnekUygulama.Models
{
	public class Personel
	{
		public Guid Id { get; set; }

		public Personel()
		{
			Id = Guid.NewGuid();
		}

		public string Name { get; set; }
		public string Surname { get; set; }

	}

}
