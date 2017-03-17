using System;
using System.Linq;
using System.Collections.Generic;
	
namespace week1HW.Models
{   
	public  class 客戶資料Repository : EFRepository<客戶資料>, I客戶資料Repository
	{
        public 客戶資料 Find(int id)
        {
            return this.All().FirstOrDefault(客戶資料 => 客戶資料.Id == id);
        }

        public override IQueryable<客戶資料> All()
        {
            return base.Where(客戶資料 => 客戶資料.deleted == false);
        }

        public override void Delete(客戶資料 entity)
        {
            entity.deleted = true;
        }
    }

	public  interface I客戶資料Repository : IRepository<客戶資料>
	{

	}
}