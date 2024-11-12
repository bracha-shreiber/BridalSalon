namespace Bridal_salon
{
    public class DressService
    {
        List<Dress> dresses = new List<Dress>()
        {
            new Dress(){Id=2,ChestCircumference=23,DressLength=90,IsOld=false,Model=1234,SleeveLength=19.5,WaistCircumference=34}
        };
        public List<Dress> GetDresses()
        {
            return dresses;
        }
        public Dress GetDressById(int id)
        {
            var item=dresses.Find(x => x.Id == id);
            return item;
        }
        public bool PostDress(Dress d) 
        {
            dresses.Add(d);
            return true;
        }
        public bool PutDress(int id,Dress d)
        {
            var item=dresses.Find(item=>item.Id == id);
            if (item != null)
            {
                item.DressLength = d.DressLength;
                item.IsOld = d.IsOld;
                item.Model = d.Model;
                item.WaistCircumference = d.WaistCircumference;
                item.ChestCircumference = d.ChestCircumference;
                item.SleeveLength = d.SleeveLength;
                return true;
            }
            return false;
        }

        public bool DeleteDress(int id)
        {
            var item = dresses.Find(item => item.Id == id);
            if (item != null)
            {
                dresses.Remove(item);
                return true;
            }
            return false;

        }
        public List<Dress> GetNewDresses()
        {
            List<Dress> result = new List<Dress>();
            foreach (var item in dresses)
            {
                if(item.IsOld)
                    result.Add(item);
            }
            return result;
        }
    }
}
