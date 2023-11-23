using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Diagnostics;
using System.IO;
using static System.Collections.Specialized.BitVector32;

namespace WindowsFormsApp1
{
    internal class IniFile
    {
        // имя файла
        string FileName;

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string value, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string defaultValue, 
            StringBuilder returnData, int size, string filePath);

        // Запись путь до файла и его имя
        public IniFile(string FileName = null)
        { 
            this.FileName = new FileInfo(FileName).FullName.ToString();
        }

        // Записываем в ini файл. Запись происходит в выбранную секцию в выбранный ключ
        public void WriteValue(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, FileName);
        }

        // Читаем  ini-файл и возвращаем значение указаного ключа из заданной секции
        public string ReadValue(string section, string key)
        {
            var buffer = new StringBuilder(255);
            GetPrivateProfileString(section, key, "", buffer, 255, FileName);
            return buffer.ToString();
        }

        // Проверяем есть ли такой ключ, в этой секции
        public bool KeyExists(string Key, string Section = null)
        {
            return ReadValue(Section, Key).Length > 0;
        }

        // Удаляем ключ из выбранной секции 
        public void DeleteKey(string key, string section = null)
        {
            WriteValue(section, key, null);
        }

        // Удаляем выбранную секцию 
        public void DeleteSection(string section = null)
        {
            WriteValue(section, null, null);
        }
    }
}
