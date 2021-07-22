using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace MyPolyglotWeb.Extensions
{
    public static class HtmlEnumExtensions
    {
        public static IHtmlContent EnumToString<T>(this IHtmlHelper helper)
        {
            var values = Enum.GetValues(typeof(T)).Cast<int>();
            var enumDictionary = values.ToDictionary(value => Enum.GetName(typeof(T), value));

            return new HtmlString(JsonConvert.SerializeObject(enumDictionary));
        }
    }
}
