using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamGehem
{
    public class Localization
    {
        private static Localization instance_;
        private string csv_file_path_;
        private CsvParser csv_parser_;

        private IList<IReadOnlyDictionary<string, string>> list_;
        private IReadOnlyDictionary<string, string> dic_;
        private int language_index_;

        public static void ChangeLanguage(int index)
        {
            instance_.ChangeLanguage_(index);
        }

        public static string GetValue(string key)
        {
            return instance_.dic_[key];
        }

        public static Localization Create(string csv_file_path)
        {
            instance_ = new Localization(csv_file_path);
            return instance_;
        }

        private Localization(string csv_file_path)
        {
            csv_file_path_ = csv_file_path;
            csv_parser_ = new CsvParser();
            language_index_ = 0;



            ChangeLanguage_(language_index_);
        }

        private void ChangeLanguage_(int index)
        {
            language_index_ = index;
            if (list_.Count >= index)
            {
                throw new IndexOutOfRangeException();
            }
            dic_ = list_[language_index_];
        }
    }
}
