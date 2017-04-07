using System;
using System.Collections.Generic;
using System.Text;

namespace TeamGehem
{
    public class Localization
    {
        private static Localization instance_;
        private static Localization Instance
        {
            get
            {
                if (instance_ == null) { throw new NullReferenceException(); }
                return instance_;
            }
        }
        private string csv_file_path_;
        private CsvParser csv_parser_;

        private IList<IDictionary<string, string>> list_;
        private IDictionary<string, string> dic_;
        private int language_index_;

        public static void ChangeLanguage(int index)
        {
            Instance.ChangeLanguage_(index);
        }

        public static string GetValue(string key)
        {
            return Instance.dic_[key];
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
            list_ = csv_parser_.ParserCsv(csv_file_path_);
            language_index_ = 0;
            dic_ = list_[language_index_];

            ChangeLanguage_(language_index_);
        }

        private void ChangeLanguage_(int index)
        {
            language_index_ = index;
            if (list_.Count <= language_index_)
            {
                throw new IndexOutOfRangeException();
            }
            dic_ = list_[language_index_];
        }
    }
}
