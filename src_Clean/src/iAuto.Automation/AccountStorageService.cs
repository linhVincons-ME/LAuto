using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using iAuto.Core.Enums;
using iAuto.Core.Models;

namespace iAuto.Automation
{
    /// <summary>
    /// Dịch vụ lưu trữ và đọc danh sách tài khoản từ file cấu hình XML (thư mục iAuto.Login/).
    /// Chuẩn hóa từ TabLogin.cs
    /// </summary>
    public class AccountStorageService
    {
        /// <summary>
        /// Đọc danh sách tài khoản và cấu hình nhóm từ file XML.
        /// </summary>
        public List<GameAccount> LoadAccounts(string filePath, out AccountGroupSettings settings)
        {
            settings = new AccountGroupSettings();
            List<GameAccount> accounts = new List<GameAccount>();

            if (!File.Exists(filePath))
            {
                return accounts;
            }

            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);

            // 1. Đọc Settings
            XmlNode settingsNode = doc.SelectSingleNode("Accounts/Settings");
            if (settingsNode != null && settingsNode.Attributes != null)
            {
                XmlAttribute limitAttr = settingsNode.Attributes["Limit"];
                if (limitAttr != null)
                {
                    int limit;
                    if (int.TryParse(limitAttr.Value, out limit))
                    {
                        settings.ClientLimit = limit;
                    }
                }

                XmlAttribute relogAttr = settingsNode.Attributes["ReLog"];
                if (relogAttr != null)
                {
                    bool relog;
                    if (bool.TryParse(relogAttr.Value, out relog))
                    {
                        settings.AutoRelogOnDisconnect = relog;
                    }
                }

                XmlAttribute resetAttr = settingsNode.Attributes["Reset"];
                if (resetAttr != null)
                {
                    bool reset;
                    if (bool.TryParse(resetAttr.Value, out reset))
                    {
                        settings.ResetDungeonsDaily = reset;
                    }
                }

                XmlAttribute reset0hAttr = settingsNode.Attributes["Reset0h"];
                if (reset0hAttr != null)
                {
                    bool reset0h;
                    if (bool.TryParse(reset0hAttr.Value, out reset0h))
                    {
                        settings.ResetAtMidnight = reset0h;
                    }
                }

                XmlAttribute stopAttr = settingsNode.Attributes["IsStop"];
                if (stopAttr != null)
                {
                    bool isStop;
                    if (bool.TryParse(stopAttr.Value, out isStop))
                    {
                        settings.IsPaused = isStop;
                    }
                }

                XmlAttribute fakeNameAttr = settingsNode.Attributes["FakeName"];
                if (fakeNameAttr != null)
                {
                    settings.FakeNamePrefix = fakeNameAttr.Value;
                }
            }

            // 2. Đọc danh sách Account
            XmlNodeList accountNodes = doc.SelectNodes("Accounts/Account");
            if (accountNodes != null)
            {
                foreach (XmlNode node in accountNodes)
                {
                    if (node.Attributes == null) continue;

                    GameAccount acc = new GameAccount();
                    XmlAttribute userAttr = node.Attributes["User"];
                    if (userAttr != null) acc.Username = userAttr.Value;

                    XmlAttribute passAttr = node.Attributes["Pass"];
                    if (passAttr != null) acc.Password = passAttr.Value;

                    XmlAttribute nameAttr = node.Attributes["Name"];
                    if (nameAttr != null) acc.CharacterName = nameAttr.Value;

                    XmlAttribute serverAttr = node.Attributes["Server"];
                    if (serverAttr != null) acc.ServerName = serverAttr.Value;

                    XmlAttribute indexAttr = node.Attributes["Index"];
                    if (indexAttr != null)
                    {
                        int index;
                        if (int.TryParse(indexAttr.Value, out index)) acc.CharacterSlotIndex = index;
                    }

                    XmlAttribute lvlAttr = node.Attributes["Lvl"];
                    if (lvlAttr != null)
                    {
                        int lvl;
                        if (int.TryParse(lvlAttr.Value, out lvl)) acc.Level = lvl;
                    }

                    XmlAttribute tagAttr = node.Attributes["Tag"];
                    if (tagAttr != null) acc.CategoryTag = tagAttr.Value;

                    accounts.Add(acc);
                }
            }

            return accounts;
        }

        /// <summary>
        /// Lưu danh sách tài khoản và cấu hình nhóm vào file XML.
        /// </summary>
        public void SaveAccounts(string filePath, List<GameAccount> accounts, AccountGroupSettings settings)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentNullException("filePath");
            }
            if (accounts == null)
            {
                accounts = new List<GameAccount>();
            }
            if (settings == null)
            {
                settings = new AccountGroupSettings();
            }

            string dir = Path.GetDirectoryName(filePath);
            if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("Accounts");
            doc.AppendChild(root);

            // Thẻ Settings
            XmlElement settingsElem = doc.CreateElement("Settings");
            settingsElem.SetAttribute("Limit", settings.ClientLimit.ToString());
            settingsElem.SetAttribute("ReLog", settings.AutoRelogOnDisconnect.ToString().ToLower());
            settingsElem.SetAttribute("Reset", settings.ResetDungeonsDaily.ToString().ToLower());
            settingsElem.SetAttribute("Reset0h", settings.ResetAtMidnight.ToString().ToLower());
            settingsElem.SetAttribute("IsStop", settings.IsPaused.ToString().ToLower());
            settingsElem.SetAttribute("FakeName", settings.FakeNamePrefix ?? string.Empty);
            root.AppendChild(settingsElem);

            // Thẻ Account
            for (int i = 0; i < accounts.Count; i++)
            {
                GameAccount acc = accounts[i];
                XmlElement accElem = doc.CreateElement("Account");
                accElem.SetAttribute("User", acc.Username ?? string.Empty);
                accElem.SetAttribute("Pass", acc.Password ?? string.Empty);
                accElem.SetAttribute("Name", acc.CharacterName ?? string.Empty);
                accElem.SetAttribute("Server", acc.ServerName ?? string.Empty);
                accElem.SetAttribute("Index", acc.CharacterSlotIndex.ToString());
                accElem.SetAttribute("Lvl", acc.Level.ToString());
                accElem.SetAttribute("Tag", acc.CategoryTag ?? string.Empty);
                root.AppendChild(accElem);
            }

            doc.Save(filePath);
        }
    }
}
