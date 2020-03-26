using System.ComponentModel.DataAnnotations;

namespace Projekt_PSBD
{
    public class Uzytkownik
    {
        [Key]
        public int UzytkownikID { get; set; }
        public string NazwaUzytkownia { get; set; }
        public string HashHaslaUzytkownika { get; private set; }
        public int PoziomDostepuUzytkownika { get; set; }

        //ustawia hasło użytkownika jako hash
        public void ustawHasloUzytkownika(string haslo)
        {
            this.HashHaslaUzytkownika = passwordSHA512(haslo);
        }

        //porównuje hasło wporawdzone z hasłem użytkownika
        public bool sprawdzHasloUzytkownika(string haslo)
        {
            if (HashHaslaUzytkownika == passwordSHA512(haslo))
            {
                return true;
            }

            return false;
        }

        //szyfrowanie hasła przy pomocy SHA512
        private string passwordSHA512(string haslo)
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(haslo);
            using (var hash = System.Security.Cryptography.SHA512.Create())
            {
                var hashedInputBytes = hash.ComputeHash(bytes);

                var hashedInputStringBuilder = new System.Text.StringBuilder(128);
                foreach (var b in hashedInputBytes)
                {
                    hashedInputStringBuilder.Append(b.ToString("X2"));
                }

                return hashedInputStringBuilder.ToString();
            }
        }
    }
}