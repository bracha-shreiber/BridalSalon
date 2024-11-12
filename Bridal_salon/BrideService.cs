namespace Bridal_salon
{
    public class BrideService
    {
        
        List<Bride> brides = new List<Bride>()
        {
            new Bride() {Id="064971708",Address="rhavad",Email="ab@gmail.com",Fullname="Brachi Shreiber", Height=165, Phone1="054134568", Phone2="0527145678"}
        };
        public List<Bride> GetBrides()
        {
            return brides;
        }

        public Bride GetBrideById(string id)
        {
            var item = brides.Find(item => item.Id == id);
            if (item == null)
                return null;
            return item;
        }

        public bool PostBride(Bride bride)
        {
            brides.Add(bride);
            return true;
        }

        public bool PutBride(string id, Bride b)
        {
            var item = brides.Find(item => item.Id == id);
            if (item != null)
            {
                item.Email = b.Email;
                item.Fullname = b.Fullname;
                item.Height = b.Height;
                item.Address = b.Address;
                item.Phone1 = b.Phone1;
                item.Phone2 = b.Phone2;
                return true;
            }
            return false;
        }

        public bool DeleteBride(string id)
        {
            var item = brides.Find(item => item.Id == id);
            if (item != null)
            {
                brides.Remove(item);
                return true;
            }
            return false;

        }

        public List<Bride> GetByHeight(int BeginHeight, int LastHeight)
        {
            List<Bride> b = new List<Bride>();
            foreach (var item in brides)
            {
                if (item.Height >= BeginHeight && item.Height <= LastHeight)
                    b.Add(item);
            }
            return b;
        }

    }
}

