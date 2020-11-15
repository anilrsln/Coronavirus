using System.IO;
using System.Linq;
using Coronavirus.CustomDependency;
using Coronavirus.iOS.CustomDependency;
using Newtonsoft.Json;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileStorage))]
namespace Coronavirus.iOS.CustomDependency
{
    public class FileStorage : IFileStorage
    {
        public string Read(string fileName)
        {
            string content;

            byte[] data = ReadBytes(fileName);
            if (data == null)
            {
                content = string.Empty;
            }
            else
            {
                content = System.Text.Encoding.UTF8.GetString(data);
            }

            return content;
        }

        public T Read<T>(string fileName)
        {
            string content = Read(fileName);
            T data = JsonConvert.DeserializeObject<T>(content);

            return data;
        }

        private byte[] ReadBytes(string fileName)
        {
            byte[] content = File.ReadAllBytes(fileName);
            content = CleanByteOrderMark(content);

            return content;
        }
        private byte[] CleanByteOrderMark(byte[] bytes)
        {
            byte[] bom = new byte[] { 0xEF, 0xBB, 0xBF };

            if (bytes.Take(3).SequenceEqual(bom))
            {
                return bytes.Skip(3).ToArray();
            }

            return bytes;
        }
    }
}
