using DevAnimals.Desktop.Database_Control;
using DevAnimals.Desktop.Models;
using DevAnimals.Desktop.Settings;
using DevAnimals.Desktop.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace DevAnimals.Device_Desktop
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// https://azure.microsoft.com/en-us/documentation/articles/app-service-authentication-overview/
    /// </summary>
    public sealed partial class RegisterAccount_Desktop : Page
    {
        RegisterAccount_VM NewUser;
        
        public RegisterAccount_Desktop()
        {
            this.InitializeComponent();

            NewUser = new RegisterAccount_VM(new RegisterClass());
            DataContext = NewUser;
            comboBox1.ItemsSource = GetCountries();
        }

        private async void Register_btn_Click(object sender, RoutedEventArgs e)
        {
            UsersRepository.SaveUser(NewUser.Registereduser);
            Frame MyFrame = (Frame)DesktopAppSettings.GetItem("myFrameKeyforRegisterNavigationtoLoginPage");

            var dialog = new MessageDialog("Register Complete!");
            await dialog.ShowAsync();
            MyFrame.Navigate(typeof(LoginPage_Desktop));
        }



        public class LocalesRetrievalException : Exception
        {
            public LocalesRetrievalException(string message)
                : base(message)
            {
            }
        }

        #region Windows API

        private delegate bool EnumLocalesProcExDelegate(
           [MarshalAs(UnmanagedType.LPWStr)]String lpLocaleString,
           LocaleType dwFlags, int lParam);

        [DllImport(@"kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern bool EnumSystemLocalesEx(EnumLocalesProcExDelegate pEnumProcEx,
           LocaleType dwFlags, int lParam, IntPtr lpReserved);

        private enum LocaleType : uint
        {
            LocaleAll = 0x00000000,             // Enumerate all named based locales
            LocaleWindows = 0x00000001,         // Shipped locales and/or replacements for them
            LocaleSupplemental = 0x00000002,    // Supplemental locales only
            LocaleAlternateSorts = 0x00000004,  // Alternate sort locales
            LocaleNeutralData = 0x00000010,     // Locales that are "neutral" (language only, region data is default)
            LocaleSpecificData = 0x00000020,    // Locales that contain language and region data
        }

        #endregion

        public enum CultureTypes : uint
        {
            SpecificCultures = LocaleType.LocaleSpecificData,
            NeutralCultures = LocaleType.LocaleNeutralData,
            AllCultures = LocaleType.LocaleWindows
        }

        public static List<CultureInfo> GetCultures(CultureTypes cultureTypes)
        {
            List<CultureInfo> cultures = new List<CultureInfo>();
            EnumLocalesProcExDelegate enumCallback = (locale, flags, lParam) =>
            {
                try
                {
                    cultures.Add(new CultureInfo(locale));
                }
                catch (CultureNotFoundException)
                {
                    // This culture is not supported by .NET (not happened so far)
                    // Must be ignored.
                }
                return true;
            };

            if (EnumSystemLocalesEx(enumCallback, (LocaleType)cultureTypes, 0, (IntPtr)0) == false)
            {
                int errorCode = Marshal.GetLastWin32Error();
                throw new LocalesRetrievalException("Win32 error " + errorCode + " while trying to get the Windows locales");
            }

            // Add the two neutral cultures that Windows misses 
            // (CultureInfo.GetCultures adds them also):
            if (cultureTypes == CultureTypes.NeutralCultures || cultureTypes == CultureTypes.AllCultures)
            {
                cultures.Add(new CultureInfo("zh-CHS"));
                cultures.Add(new CultureInfo("zh-CHT"));
            }

            return cultures;
        }

        public static List<string> GetCountries()
        {
            List<CultureInfo> cultures = GetCultures(CultureTypes.SpecificCultures);
            List<string> countries = new List<string>();

            foreach (CultureInfo culture in cultures)
            {
                RegionInfo region = new RegionInfo(culture.Name);

                if (!(countries.Contains(region.EnglishName)))
                {
                    countries.Add(region.EnglishName);
                }
            }

            return countries;
        }
    }
}
