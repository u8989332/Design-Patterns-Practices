using System;
using System.Collections.Generic;

namespace MultiStateMemento
{
    public class ModelUtilities
    {
        public static IDictionary<string, object> BackupProperties(object model)
        {
            IDictionary<string, object> result = new Dictionary<string, object>();
            try{
                var properties = model.GetType().GetProperties();
                foreach(var property in properties)
                {
                    string name = property.Name;
                    object value = property.GetValue(model);
                    result.Add(name, value);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result;
        }

        public static void RestoreProperties(object model, IDictionary<string, object> propMap)
        {
            IDictionary<string, object> result = new Dictionary<string, object>();
            try{
                var properties = model.GetType().GetProperties();
                foreach(var property in properties)
                {
                    string name = property.Name;
                    if(propMap.ContainsKey(name))
                    {
                        property.SetValue(model, propMap[name]);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}