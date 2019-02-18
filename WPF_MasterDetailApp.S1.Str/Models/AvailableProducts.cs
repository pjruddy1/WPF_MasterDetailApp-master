using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MasterDetailApp.Models
{
    class AvailableProducts
    {

        private string _imageName;

        public string ImageFilePath
        {
            get { return @"../Images/" + _imageName; }
        }

        public string ImageName
        {
            get { return _imageName; }
            set { _imageName = value; }
        }

    }
}
