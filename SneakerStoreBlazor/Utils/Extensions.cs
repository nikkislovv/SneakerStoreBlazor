using System.Web;

namespace SneakerStoreBlazor.Utils
{
    public static class Extensions
    {
        public static string GetQueryString(this object obj)
        {
            var properties = from p in obj.GetType().GetProperties()
                             where p.GetValue(obj, null) != null
                             select p.Name + "=" + HttpUtility.UrlEncode(p.GetValue(obj, null).ToString());

            return String.Join("&", properties.ToArray());
        }

        public static T ParseQueryString<T>(string queryString) where T : new()
        {
            var obj = new T();
            var pairs = queryString.Split('&');
            foreach (var pair in pairs)
            {
                var parts = pair.Split('=');
                if (parts.Length == 2)
                {
                    var name = HttpUtility.UrlDecode(parts[0]);
                    var value = HttpUtility.UrlDecode(parts[1]);
                    var prop = typeof(T).GetProperty(name);
                    if (prop != null && prop.CanWrite)
                    {
                        var propType = prop.PropertyType;
                        if (propType.Name == "Guid")
                        {
                            var convertedGuidValue = Guid.Parse(value);
                            prop.SetValue(obj, convertedGuidValue);
                            continue;
                        }
                        var convertedValue = Convert.ChangeType(value, propType);
                        prop.SetValue(obj, convertedValue);
                    }
                }
            }
            return obj;
        }
    }
}
