using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Save_and_Load {
    public interface ISaveable {
        void Save(StreamWriter fs);
        void Load(StreamReader fs);
    }
}
