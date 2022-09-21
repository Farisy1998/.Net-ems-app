using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace IRemoteEMS
{
    public interface IRemote
    {
        void insert(string in_cmd);
        void delete(string del_cmd);
        void update(string up_cmd);
        DataTable select(string sel_cmd);
    }
}
