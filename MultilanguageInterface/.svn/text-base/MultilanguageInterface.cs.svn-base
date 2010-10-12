using System;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeAccounting.MultilanguageInterface
{
    public sealed class InterfaceBinding : BindingSource
    {
        private static readonly InterfaceBinding _instance = new InterfaceBinding();
        private InterfaceBinding() { }
        public static InterfaceBinding Instance
        {
            get
            {
                return _instance;
            }
        }
    }

    public sealed class MultilanguageInterface
    {
        #region Singleton declaration
        private static readonly MultilanguageInterface _instance = new MultilanguageInterface();
        private MultilanguageInterface() { }
        public static MultilanguageInterface Instance
        {
            get
            {
                return _instance;
            }
        }
        #endregion

        private Dictionary<string, string> _langs = new Dictionary<string, string>();
        private Dictionary<string, string> _files = new Dictionary<string, string>();
        private string _appCode = "HomeAccounting";

        private string ValueToKey(string value)
        {
            if (_langs.ContainsValue(value))
            {
                foreach (string key in _langs.Keys)
                {
                    string keyValue = string.Empty;
                    if (_langs.TryGetValue(key, out keyValue))
                    {
                        if (keyValue == value)
                        {
                            return key;
                        }
                    }
                }
            }

            return null;
        }

        public List<string> Languages
        {
            get
            {
                List<string> returnee = new List<string>();
                foreach (string value in _langs.Values)
                {
                    returnee.Add(value);
                }
                returnee.Sort();
                return returnee;
            }
        }
        public enum Messages
        {
            LanguageNotFound
        }

        public void LoadLanguage(string langTitle)
        {

            if (_langs.ContainsValue(langTitle))
            {
                try
                {
                    string languageFilePath;

                    _files.TryGetValue(ValueToKey(langTitle), out languageFilePath);


                    if (languageFilePath.Trim() != string.Empty)
                    {
                        using (XmlTextReader langReader = new XmlTextReader(languageFilePath))
                        {
                            langReader.Read();
                            while (langReader.Read())
                            {
                                langReader.MoveToElement();
                                if (langReader.LocalName == "Label1")
                                {
                                    _label1 = langReader.GetAttribute("caption");
                                }

                                if (langReader.LocalName == "Label2")
                                {
                                    _label2 = langReader.GetAttribute("caption");
                                }

                                if (langReader.LocalName == "Menu1")
                                {
                                    _menu1 = langReader.GetAttribute("caption");
                                }

                                if (langReader.LocalName == "LanguageNotFound")
                                {
                                    _languageNotFound = langReader.GetAttribute("caption");
                                }
                            }
                        }
                    }
                }

                catch
                { }
            }
            else
            {
                throw new LanguageNotFoundException();
            }
        }
        public void ScanDir(string pathToDir)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(pathToDir);

            foreach (FileInfo langFile in dirInfo.GetFiles("*.lng"))
            {
                using (XmlTextReader xmlRdr = new XmlTextReader(langFile.FullName))
                {
                    xmlRdr.Read();

                    while (xmlRdr.Read())
                    {
                        xmlRdr.MoveToElement();
                        if (xmlRdr.LocalName == "language")
                        {
                            if (_appCode == xmlRdr.GetAttribute("appcode"))
                            {
                                try
                                {
                                    _files.Add(xmlRdr.GetAttribute("code"), langFile.FullName);
                                    _langs.Add(xmlRdr.GetAttribute("code"), xmlRdr.GetAttribute("title"));
                                }
                                catch
                                {
                                }
                            }
                        }
                    }
                }
            }
        }
        public string GetMessageString(Messages messageCode)
        {
            switch (messageCode)
            {
                case Messages.LanguageNotFound:
                    if (_languageNotFound == null || _languageNotFound.Trim() == string.Empty)
                    {
                        return "Language with specified title not found!\nФайл ресурсов для указанного языка не найдн!";
                    }
                    return _languageNotFound;
            }
            return "lol";
        }

        #region private interface labels

        private string _label1;
        private string _label2;
        private string _menu1;

        private string _languageNotFound;

        #endregion
        #region public interface labels

        public string Label1
        {
            get { return _label1; }
        }
        public string Label2
        {
            get { return _label2; }
        }
        public string Menu1
        {
            get { return _menu1; }
        }

        #endregion

    }

    public class LanguageNotFoundException : Exception
    {
    }
}
