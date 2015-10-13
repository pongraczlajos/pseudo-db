using System;
using System.IO;
using System.Xml;
using YAXLib;

namespace PseudoDb.Engine.Common
{
    public class XmlSerializer
    {
        public static void Serialize<T>(T objectToSerialize, String xmlFilePath)
        {
            var serializer = new YAXSerializer(typeof(T));
            var writer = new XmlTextWriter(xmlFilePath, null);
            writer.Formatting = Formatting.Indented;
            serializer.Serialize(objectToSerialize, writer);
            writer.Close();
        }

        public static T Deserialize<T>(string xmlFilePath)
        {
            var deserializer = new YAXSerializer(typeof(T), YAXExceptionHandlingPolicies.ThrowErrorsOnly,
               YAXExceptionTypes.Warning);
            object deserializedObject = null;

            deserializedObject = deserializer.Deserialize(File.ReadAllText(xmlFilePath));

            if (deserializer.ParsingErrors.ContainsAnyError)
            {
                //Console.WriteLine("Succeeded to deserialize, but these problems also happened:");
                //Console.WriteLine(deserializer.ParsingErrors.ToString());
            }

            return ((T) deserializedObject);
        }
    }
}
