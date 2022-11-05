using Core.Utilities.Result.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Result.Concrete
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T Data, bool isSuccess, string message):base(isSuccess,message)
        {
            this.Data = Data;
        }
        public DataResult(T Data, bool isSuccess):base(isSuccess)
        {
            this.Data = Data;
        }
        public T Data { get; }
    }
}
