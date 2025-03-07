using NovaMAUI.Runtimes;
using System.Diagnostics;
using NovaMAUI.Runtimes.Models;
using Newtonsoft.Json;
using NovaMAUI.Runtimes.Models.Enum;

namespace NovaMAUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var app = Application.Current;
            if(app != null)
                ApplicationRuntimes.Theme = app.RequestedTheme;
            
            ApplicationRuntimes.ScreenRatioType = GetScreenType();
            ApplicationRuntimes.NavItems = JsonConvert.DeserializeObject<NavItem[]>(ReadJsonFile("navs.json"));
            Content = blazorWebView;
        }

        public static string ReadJsonFile(string file)
        {
            try
            {
                using var stream = FileSystem.OpenAppPackageFileAsync($"Data/{file}").Result;
                using var reader = new StreamReader(stream);
                var contents = reader.ReadToEnd();
                return contents;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error reading file: {ex.Message}");
                return "";
            }
        }
        public static ScreenRatio GetScreenType()
        {
            double screenWidth = DeviceDisplay.MainDisplayInfo.Width / DeviceDisplay.MainDisplayInfo.Density;
            double screenHeight = DeviceDisplay.MainDisplayInfo.Height / DeviceDisplay.MainDisplayInfo.Density;

            if (screenWidth > screenHeight)
            {
                return ScreenRatio.WideScreen;
            }
            else
            {
                return ScreenRatio.NarrowScreen;
            }
        }
    }
}
