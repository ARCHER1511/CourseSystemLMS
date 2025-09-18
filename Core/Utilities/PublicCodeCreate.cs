using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Utilities
{
    public static class PublicCodeCreate
    {
        public static string GeneratePublicCode()
        {
            // Base36 (0-9,A-Z), 8 characters
            var guidBytes = Guid.NewGuid().ToByteArray();
            var bigInt = new System.Numerics.BigInteger(guidBytes);
            var code = Base36Encode(Math.Abs((long)(bigInt % long.MaxValue)));
            return code[..8].ToUpper();
        }

        private static string Base36Encode(long value)
        {
            const string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var sb = new StringBuilder();
            do
            {
                sb.Insert(0, chars[(int)(value % 36)]);
                value /= 36;
            } while (value > 0);
            return sb.ToString();
        }
    }
}
