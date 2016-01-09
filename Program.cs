using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace UnlockAODStages
{

    class Program
    {
        static void saveData(Object target, string file)
        {
            var fs = new FileStream(file, FileMode.Create);
            var formatter = new BinaryFormatter();
            formatter.Serialize(fs, target);
            fs.Close();
        }
        static void Main(string[] args)
        {
            List<int> enabledStages = Enumerable.Range(0, 100).ToList();
            saveData(enabledStages, "Es.aod");
            // and copy it to the "save" folder...
        }
    }
}
