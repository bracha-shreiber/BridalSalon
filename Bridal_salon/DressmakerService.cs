namespace Bridal_salon
{
    public class DressmakerService
    {
        List<dressmaker> dressmakers = new List<dressmaker>()
        {
            new dressmaker() {Id="327861258",FullName="brachi_shreiber", Phone="0583270458",
                Email="b0583270458@gmail.com", Working_days_a_week=days.Monday|days.Tuesday,Hourly_wage=100,Experience=3 }
        };
       
        public List<dressmaker> GetDressmakers()
        {
            return dressmakers;
        }

        public dressmaker GetDressmakerById(string id)
        {
            var item = dressmakers.Find(item => item.Id == id);
            return item;
        }

        public bool PostDressmaker(dressmaker d)
        {
            dressmakers.Add(d);
            return true;
        }

        public bool PutDressmaker(string id, dressmaker d)
        {
            var item = dressmakers.Find(item => item.Id == id);
            if (item != null)
            {
                item.FullName = d.FullName;
                item.Phone = d.Phone;
                item.Email = d.Email;
                item.Experience= d.Experience;
                item.Working_days_a_week=d.Working_days_a_week;
                item.Hourly_wage= d.Hourly_wage;
                return true;
            }
            return false;
        }
        public bool DeleteDressmaker(string id)
        {
            var item = dressmakers.Find(item => item.Id == id);
            if (item != null)
            { 
                dressmakers.Remove(item);
                return true;
            }
           return false;
        }
        public dressmaker MaxExperience()
        {
            double max = 0;
            dressmaker res=null;
            foreach (var item in dressmakers)
            {
                if (item.Experience > max)
                {
                    max = item.Experience;
                    res = item;
                }
            }
            return res;
        }

        public dressmaker MinPrice()
        {
            double min = int.MaxValue;
            dressmaker res = null;
            foreach (var item in dressmakers)
            {
                if (item.Hourly_wage <min)
                {
                    min = item.Hourly_wage;
                    res = item;
                }
            }
            return res;
        }


    }
}
