using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FridgeTracker.Models
{
	public class FridgeFood
	{
		public int ID { get; set; }
		//[Required]
		[MaxLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
		public string Name { get; set; }
		//[Required]
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString ="{yyyy/MM/dd}")]
		[Display(Name = "Best Before")]
		//[BestBeforeValidAttirbute(ErrorMessage = "Food is not good anymore!")]
		public DateTime BestBefore { get; set; }
		//[Required]
		public Category Category { get; set; }
		public int Unit { get; set; }
		public MeasType Measurement { get; set; }
	}

	/*public class BestBeforeValidAttirbute : ValidationAttribute
	{
		public override bool IsValid(object value)
		{
			DateTime d = Convert.ToDateTime(value);
			return d >= DateTime.Now;
		}
	}*/

	public enum Category
	{		
		[Description("tejtermék, tojás, sajt")]
		Tej,
		[Description("tejtermék, tojás")]
		Tejtermek_tojas,
		[Description("zöldség-gyümölcs")]
		Zoldseg_gyomolcs,
		[Description("Pékáru")]
		Pekaru,
		[Description("Felvágottak")]
		Hus_felvagott,
		[Description("Édesség")]
		Sweets,
		[Description("Alholos italok")]
		Alkoholos_italok,
		[Description("Üdítők")]
		Uditok,
		[Description("Főtt étel")]
		Fott_etel,
		[Description("egyéb")]
		Egyeb
	}
	public enum MeasType
	{
		kg,		
		dkg,
		g,
		l,
		dl,
		ml,
		db,
		adag
	}
}