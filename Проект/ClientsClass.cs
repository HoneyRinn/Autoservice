using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Проект
{
    public class ClientsClass
    {
        public string iName { get; set; }
        public string iModel { get; set; }
        public string iNum { get; set; }
        public string iOrder { get; set; }
        public string iMoney { get; set; }
        public string iStatus { get; set; }

    }
}
