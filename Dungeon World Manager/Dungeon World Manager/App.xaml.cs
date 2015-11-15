using Dungeon_World_Manager.Properties;
using Dungeon_World_Manager.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Dungeon_World_Manager
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static string GetDataFilePath()
        {
            var root = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var partialPath = Settings.Default.datafile;
            return partialPath.Replace("root", root);
        }

        public static string ReadFile(string filePath)
        {
            if (!File.Exists(filePath)) throw new FileNotFoundException();
            using (var reader = File.OpenText(filePath))
            {
                return reader.ReadToEnd();
            }
        }
        
        public static async Task<string> ReadFileAsync(string filePath)
        {
            if (!File.Exists(filePath)) throw new FileNotFoundException();
            using (var reader = File.OpenText(filePath))
            {
                return await reader.ReadToEndAsync();
            }
        }

        public static async Task WriteTextAsync(string filePath, string text)
        {
            byte[] encodedText = Encoding.Unicode.GetBytes(text);

            using (FileStream sourceStream = new FileStream(filePath,
                FileMode.Create, FileAccess.Write, FileShare.None,
                bufferSize: 4096, useAsync: true))
            {
                await sourceStream.WriteAsync(encodedText, 0, encodedText.Length);
            };
        }
    }
}
