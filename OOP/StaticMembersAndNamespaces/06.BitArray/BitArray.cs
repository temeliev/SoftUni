using System;
using System.Text;

namespace _06.BitArray
{
    public class BitArray
    {
        public BitArray(uint size)
        {
            this.Size = size;
        }

        private uint size;

        public uint Size
        {
            get { return size; }
            private set
            {
                if (value > 0 && value < 100001)
                {
                    this.size = value;
                    this.bytes = new int[size];
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Size has to be in range[1...100]");
                }
            }
        }

        private int[] bytes;

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= bytes.Length)
                {
                    throw new ArgumentOutOfRangeException("Index is out of range");
                }

                return bytes[index];
            }
            set
            {
                if (index < 0 || index >= bytes.Length)
                {
                    throw new ArgumentOutOfRangeException("Index is out of range");
                }

                if (value != 0 && value != 1)
                {
                    throw new ArgumentException("The value has to be 0 or 1");
                }

                bytes[index] = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = bytes.Length - 1; i >= 0; i--)
            {
                sb.Append(bytes[i]);
            }

            return Convert.ToUInt32(sb.ToString(), 2).ToString();
        }
    }
}
