using ListBoxRadioButton.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListBoxRadioButton.Models
{
    public class DeviceModel:BaseViewmodel
    {
        private string Name_;
        public string Name { get { return Name_ ?? ""; } set { Name_ = value; OnPropertyChanged(); } }

    }
}
