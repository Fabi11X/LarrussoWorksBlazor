using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace LarrussoWorksBlazor.Helpers
{
    public class IsDataNull
    {
        public static T Check<T>(string data)
        {
            return data == null ? default : JsonSerializer.Deserialize<T>(data); ;
        }
        public static T CreateInstanceIfIsNull<T>(T data) where T : new()
        {
            return data == null ? new T() : data;
        }
    }
}
