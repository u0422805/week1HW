using System;
using System.Linq;
using System.Collections.Generic;
	
namespace week1HW.Models
{   
	public  class 客戶聯絡人Repository : EFRepository<客戶聯絡人>, I客戶聯絡人Repository
	{

	}

	public  interface I客戶聯絡人Repository : IRepository<客戶聯絡人>
	{

	}
}