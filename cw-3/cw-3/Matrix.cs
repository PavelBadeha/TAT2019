using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_3
{ 
    class Matrix <Nullable> 
    {
        private Nullable[] values;
        public delegate void changedDelegate();
        public event changedDelegate OnChanged;
        public int Size { get; }
        public Matrix(int size,Nullable[] values)
        {
            Size = size;
            this.values = new Nullable[2*size];
            this.values = values;
        }
        public Nullable this[int row,int column]
        {
            get
            {
                return values[Size*row+column]; 
            }
            set
            {
                values[Size*row+column] = value;
                OnChanged?.Invoke();
            }
        }
        public bool IsDiagonal()
        {
            for(int i=0;i<Size;i++)
            {
               for(int j=;j<Size;j++)
                {
                    if(i!=j && this[i,j]!=null)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
