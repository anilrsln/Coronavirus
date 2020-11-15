using System.IO;
using Android.Content;
using Coronavirus.CustomDependency;
using Coronavirus.Droid.CustomDependency;
using Newtonsoft.Json;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileStorage))]
namespace Coronavirus.Droid.CustomDependency
{
    public class FileStorage: IFileStorage
    {
        private readonly Context context;

        public FileStorage()
        {
            context = Android.App.Application.Context;
        }

        private string Read(string fileName)
        {
            string content;

            using (System.IO.Stream asset = context.Assets.Open(fileName))
            {
                using (StreamReader streamReader = new StreamReader(asset))
                {
                    content = streamReader.ReadToEnd();
                }
            }

            return content;
        }

        public T Read<T>(string fileName)
        {
            string content = Read(fileName);
            T data = JsonConvert.DeserializeObject<T>(content);

            return data;
        }
    }
}
