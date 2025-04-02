using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackieZ_301465524_Lab67Library
{
    public interface IPersistable
    {
        public void Save(string path);

        public void Load(string path);
    }
}