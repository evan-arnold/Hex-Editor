using System;
using System.Collections.Generic;
using System.Text;

namespace SHex
{
    public interface IByteCharConverter
    {
        char ToChar(byte b);
        byte ToByte(char c);
    }

    public class DefaultByteCharConverter : IByteCharConverter
    {
        public virtual char ToChar(byte b)
        {
            return b > 0x1F && !(b > 0x7E && b < 0xA0) ? (char)b : '.';
        }

        public virtual byte ToByte(char c)
        {
            return (byte)c;
        }

        public override string ToString()
        {
            return "ANSI (Default)";
        }
    }

    public class EbcdicByteCharProvider : IByteCharConverter
    {
        private Encoding _ebcdicEncoding = Encoding.GetEncoding(500);

        public virtual char ToChar(byte b)
        {
            string encoded = _ebcdicEncoding.GetString(new byte[] { b });
            return encoded.Length > 0 ? encoded[0] : '.';
        }

        public virtual byte ToByte(char c)
        {
            byte[] decoded = _ebcdicEncoding.GetBytes(new char[] { c });
            return decoded.Length > 0 ? decoded[0] : (byte)0;
        }

        public override string ToString()
        {
            return "EBCDIC (Code Page 500)";
        }
    }
}
