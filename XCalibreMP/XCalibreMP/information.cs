using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XCalibreMP
{
    public class information
    {
        private string Name_txtb;
        private string ID_txtbx;
        private string Password;

        public string StudentName
        {
            get { return Name_txtb; }
            set { Name_txtb = value; }
        }
        public string StudentID
        {
            get { return ID_txtbx; }
            set { ID_txtbx = value; }
        }
        public string StudentPassword
        {
            get { return Password; }
            set { Password = value; }
        }
    }
}
