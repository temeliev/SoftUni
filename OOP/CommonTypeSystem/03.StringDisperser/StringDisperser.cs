namespace _03.StringDisperser
{
    using System;
    using System.Collections;
    using System.Text;

    public class StringDisperser : ICloneable, IComparable<StringDisperser>, IEnumerable
    {
        private string[] input;

        public StringDisperser(params string[] param)
        {
            this.input = param;
        }

        public object Clone()
        {
            return new StringDisperser(this.input);
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < this.input.Length; i++)
            {
                for (int i1 = 0; i1 < this.input[i].Length; i1++)
                {
                    yield return this.input[i][i1];
                }
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is StringDisperser)
            {
                StringDisperser other = obj as StringDisperser;

                if (this.input.Length == other.input.Length)
                {
                    for (int i = 0; i < this.input.Length; i++)
                    {
                        if (this.input[i] != other.input[i])
                        {
                            return false;
                        }
                    }

                    return true;
                }
            }
            
            return false;
        }

        public override int GetHashCode()
        {
            return this.input.GetHashCode();
        }

        public override string ToString()
        {
            if (this.input.Length > 0)
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < this.input.Length; i++)
                {
                    sb.AppendLine(this.input[i]);
                }

                return sb.ToString();
            }

            return " ";

        }

        public static bool operator ==(StringDisperser a, StringDisperser b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(StringDisperser a, StringDisperser b)
        {
            return !a.Equals(b);
        }


        public int CompareTo(StringDisperser other)
        {
            StringBuilder homeObj = new StringBuilder();

            foreach (var i in this.input)
            {
                homeObj.Append(i);
            }

            StringBuilder otherObj = new StringBuilder();

            foreach (var i in other.input)
            {
                otherObj.Append(i);
            }

            if (homeObj.ToString().CompareTo(otherObj) < 0)
            {
                return -1;
            }

            return 1;
        }
    }
}
