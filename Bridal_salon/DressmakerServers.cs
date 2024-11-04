namespace Bridal_salon
{
    public class DressmakerServers
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

        public dressmaker PostDressmaker(dressmaker d)
        {
            dressmakers.Add(d);
            return d;
        }

        public dressmaker PutDressmaker(string id, dressmaker d)
        {
            var item = dressmakers.Find(item => item.Id == id);
            if (item == null)
                return null;
            return item;
        }
        public void DeleteDressmaker(string id)
        {
            var item = dressmakers.Find(item => item.Id == id);
            dressmakers.Remove(item);
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
