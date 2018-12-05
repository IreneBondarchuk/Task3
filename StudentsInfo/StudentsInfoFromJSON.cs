using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsInfo
{
    public class StudentsInfoFromJSON
    {
        public List<Student> StudentsList { get; set; }

        public StudentsInfoFromJSON(string path)
        {
           StudentsList = GetData(path);
        }

        public List<Student> GetData(string path)
        {           
            if (path == null) throw new ArgumentNullException();
            //if (!File.Exists(path)) throw new FileNotFoundException("Cannot locate the file:\n   \"" + path + "\"\nPlease check the path and try again.");
            try
            {
                return JsonConvert.DeserializeObject<List<Student>>(File.ReadAllText(path));
            }
            catch (Exception ex)
            {
                throw new FileLoadException("Unable to load Data.\nThe file \"" + path + "\" does not load correctly.", ex);
            }
            //isLoaded = true;
   
        }

    }
}
