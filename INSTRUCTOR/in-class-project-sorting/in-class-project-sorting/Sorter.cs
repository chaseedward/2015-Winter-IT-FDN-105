using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace in_class_project_sorting
{
    public class Sorter
    {
        private int[] values;
        private int count;

        public Sorter(int size)
        {
            values = new int[size];
            count = 0;
        }

        public int Count
        {
            get { return count; }
            
        }

        public void AddElement(int value)
        {
            values[count] = value;
            count++;
        }

        public void Sort()
        {
            // values[0] = 20
            // values[1] = 10
            // count = 2
            var swap = true;
            var bottom = count - 1;

            while (swap)
            {
                swap = false;
                for (var i = 0; i < bottom; i++)
                {
                    if (values[i] > values[i + 1])
                    {
                        swap = true;
                        var temp = values[i + 1];
                        values[i + 1] = values[i];
                        values[i] = temp;
                    }
                }

                bottom--;
            }
        }

        public int[] GetArray()
        {
            return values;
        }
    }
}
