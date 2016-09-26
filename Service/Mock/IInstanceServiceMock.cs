using Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Mock
{
    public interface IInstanceServiceMock
    {
        void PutData(IEnumerable<InstanceInfo> data);
    }
}
