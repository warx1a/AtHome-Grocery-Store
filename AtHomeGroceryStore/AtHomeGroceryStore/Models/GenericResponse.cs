using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtHomeGroceryStore.Models
{
    public class GenericResponse
    {

        public string errorMessage { get; set; }

        private Dictionary<string, object> data = new Dictionary<string, object>();

        public void addData(string key, object value)
        {
            data.Add(key, value);
        }

        public T getData<T>(string key)
        {
            object dictData = data[key];
            if(dictData == null)
            {
                return default(T);
            } else
            {
                return (T)dictData;
            }
        }

    }
}