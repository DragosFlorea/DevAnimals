using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevAnimals.Desktop.Settings
{
    public static class DesktopAppSettings
    {
        private static Dictionary<string, object> _settingsCache =
                                          new Dictionary<string, object>();

        public static void AddItem(string itemKey, object itemValue)
        {
            _settingsCache.Add(itemKey, itemValue);
        }

        public static object GetItem(string itemKey)
        {
            return _settingsCache[itemKey];
        }
    }
}
