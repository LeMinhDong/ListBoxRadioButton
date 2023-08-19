using ListBoxRadioButton.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListBoxRadioButton.Models;

namespace ListBoxRadioButton.Config
{
    public class DataSetting:BaseViewmodel
    {
        public string SelectedDeviceId { get; set; }

        public DeviceModel SelectedDeviceModel
        {
            get => _selectedDeviceModel;
            set
            {
                _selectedDeviceModel = value;
                //if (value != null)
                //    SelectedDeviceId = value.Name;
                OnPropertyChanged();
            }
        }
        private DeviceModel _selectedDeviceModel;



    }
}