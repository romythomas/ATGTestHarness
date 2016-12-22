using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
/****************************** Module Header ******************************\
Module Name     :   SingelOrArrayConverter.cs
Project         :   Air To Galaxy Test Harness
Author          :   Romy Thomas

Module inherited from JsonConverter. Used to convert single object as an
array of objects. Service returns few nodes as array or as single object
based on output.So this class is required to parse those nodes.
\***************************************************************************/
namespace GalaxyToAir_TestHarness.Util
{
    class SingleOrArrayConverter<T> : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(T[]));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JToken token = JToken.Load(reader);
            if (token.Type == JTokenType.Array)
            {
                return token.ToObject<T[]>();
            }
            return new T[] { token.ToObject<T>() };
        }

        public override bool CanWrite
        {
            get { return false; }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
