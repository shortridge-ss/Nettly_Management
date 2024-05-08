using System;
using System.Security.Cryptography;
using System.Text;

namespace NettlyManagement
{
    internal class Utils
    {
        internal static bool FormIsOpen(string v)
        {
            throw new NotImplementedException();
        }
    }
}
//public static string DefaultPassword (string password)
//SHA256 sha = SHA256.Create();

//convert input string to byte array and comute hash.
//byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

//create string builder to collect byte and create string
//StringBuilder sb = new StringBuilder();


//loop through each byte of hashed data and format each
//one as a hexadecimal string.
/*for (int i = 0; i < data.Length; i++)
{
    sb.Append(data[i].ToString("x2"));
}
var hashedPassword = sb.ToString();


//compare textbox with db
var user = _dbEntities.Users.FirstOrDefault(u => u.Username == username && u.Password == hashedPassword);*/
