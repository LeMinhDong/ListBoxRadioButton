using ListBoxRadioButton.Config;
using ListBoxRadioButton.Models;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ListBoxRadioButton.ViewModels
{
    public class MainViewModel : BaseViewmodel
    {
        private DataSetting _dataSetting;

        public DataSetting DataSetting
        {
            get => _dataSetting;
            set
            {
                _dataSetting = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<DeviceModel> DeviceModels { get; set; }

        public DeviceModel SelectedDeviceModel
        {
            get => _selectedDeviceModel;
            set
            {
                _selectedDeviceModel = value;
                //if (value != null)
                    //DataSetting.SelectedDeviceId = value.Name;
                OnPropertyChanged();
            }
        }
        private DeviceModel _selectedDeviceModel;

        public MainViewModel()
        {
            DeviceModels = new ObservableCollection<DeviceModel>();
            DeviceModels.Add(new DeviceModel() { Name = "A" });
            DeviceModels.Add(new DeviceModel() { Name = "B" });
            DeviceModels.Add(new DeviceModel() { Name = "C" });
            DeviceModels.Add(new DeviceModel() { Name = "D" });
            DeviceModels.Add(new DeviceModel() { Name = "E" });
            DeviceModels.Add(new DeviceModel() { Name = "F" });
            DeviceModels.Add(new DeviceModel() { Name = "G" });

            CreateSettingFileIfNotExist();
            LoadFromSetting();

            //SelectedDeviceModel = DeviceModels.Where(dv => dv.Name.Equals(DataSetting.SelectedDeviceId)).FirstOrDefault();
        }

        public void LoadFromSetting()
        {
            string content = File.ReadAllText(xStaticConfig.SettingPath);
            JObject jObject = JObject.Parse(content);
            DataSetting = JsonConvert.DeserializeObject<DataSetting>(jObject.ToString());
        }

        public void CreateSettingFileIfNotExist()
        {
            if (File.Exists(xStaticConfig.SettingPath)) return;
            DataSetting dataSetting = new DataSetting();
            string json = JsonConvert.SerializeObject(dataSetting, Formatting.Indented);
            File.WriteAllText(xStaticConfig.SettingPath, json);
        }

        public void SaveSetting()
        {
            string json = JsonConvert.SerializeObject(DataSetting, Formatting.Indented);
            File.WriteAllText(xStaticConfig.SettingPath, json);
        }
    }
}