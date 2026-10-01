using System;
using System.Collections;

namespace Bai02
{
    public class ArrayPoint
    {
        private ArrayList ds;

        public ArrayPoint()
        {
            ds = new ArrayList();
        }

        public int Count
        {
            get
            {
                return ds.Count;
            }
        }

        public void Add(Point p)
        {
            ds.Add(p);
        }

        public Point this[int index]
        {
            get
            {
                if (index < 0 || index >= ds.Count)
                {
                    throw new IndexOutOfRangeException(
                        "Chi so nam ngoai pham vi."
                    );
                }

                if (ds[index] is Point point)
                {
                    return point;
                }

                throw new InvalidOperationException(
                    "Phan tu tai vi tri nay khong phai la Point."
                );
            }

            set
            {
                if (index < 0 || index >= ds.Count)
                {
                    throw new IndexOutOfRangeException(
                        "Chi so nam ngoai pham vi."
                    );
                }

                ds[index] = value;
            }
        }
    }
}