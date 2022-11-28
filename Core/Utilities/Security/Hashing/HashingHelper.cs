using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        //Verilen şifrenin hashini oluşturacak (salt dahil)
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        /*  DBdeki hashle kullanıcının gönderdiği hash karşılaştırılacak
            Password değeri login ekranından alınan değer
            kullanıcının verdiği şifre ile tekrar hashleme yapılsa aynı hash mi cikar?
        */
        public static bool VerifyPasswordHash(string password, byte[] passwordHash,  byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt)) //verify yapılacağından key (salt) lazım
            {
                //computedHash yukarıda salt ile hesaplanarak bulundu
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i]) //passwordHash dbden geliyor
                    {
                        return false;
                    }
                }
                return true;
            }
            
        }
    }
}
