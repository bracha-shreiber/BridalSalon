namespace Bridal_salon
{
    public class Checks<T>
    {
        public bool IsIsraeliIdNumber(string id)
        {
            id = id.Trim();
            if (id.Length > 9 || !int.TryParse(id, out _))
            {
                return false;
            }
            id = id.Length < 9 ? ("00000000" + id).Substring(Math.Max(0, id.Length - 9)) : id;
            int sum = id.Select((c, i) => (c - '0') * ((i % 2) + 1) > 9 ? ((c - '0') * ((i % 2) + 1)) - 9 : (c - '0') * ((i % 2) + 1)).Sum();
            return sum % 10 == 0;
        }
        public bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
    }

}
