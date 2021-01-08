using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Diary
{
    class Functions
    {
        private static int maxT = 25;
        private static int maxM = 40;
        private static int maxI = 10;
        public static int easteregg = 0;
        public static int imageCounter = 0;
        public static int delCounter = 0;
        private static string password;
        private static string theme;
        private static string nickName;
        private static string pass;
        public static string language;
        public static string defaultSettings = "theme light language turkish";
        public static string date = DateTime.Now.ToShortDateString();
        public static string passwordPath = Application.StartupPath + "//system.bin";
        public static string settingsPath = Application.StartupPath + "//settings.bin";
        public static string filePath = Application.StartupPath + "\\logs" + "\\";
        public static string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public static string logPath = Application.StartupPath + "\\logs";
        public static string backupPath = desktopPath + "\\backups";
        public static string[] title = new string[maxT];
        public static string[] menuName = new string[maxM];
        public static string[] myFile = new string[maxI];

        public static void isFileHere()
        {
            if (File.Exists(passwordPath))
            {

            }
            else
            {
                FileStream fs = File.Create(passwordPath);
                fs.Close();
            }
            if (File.Exists(settingsPath))
            {

            }
            else
            {
                FileStream fs = File.Create(settingsPath);
                fs.Close();
                StreamWriter swSettings = new StreamWriter(settingsPath);
                swSettings.Write(defaultSettings);
                swSettings.Close();
            }
        }
        public static void signIn(string txt1,string txt2)
        {
            if (txt1 != "" && txt2 != "")
            {
                passwordControl();
                if (passGet() == null)
                {
                    passSet(EncryptText(txt1,"chareless") + " " + EncryptText(txt2,"chareless"));
                    StreamWriter sw = new StreamWriter(passwordPath);
                    sw.Write(passGet());
                    sw.Close();
                    MessageBox.Show(title[2]);
                    passwordControl();
                }
                else
                {
                    MessageBox.Show(title[3]);
                }
            }
            else
            {
                MessageBox.Show(title[4]);
            }
        }
        public static void dateSet(string param)
        {
            date = param;
        }

        public static string dateGet()
        {
            return date;
        }
        public static string nickNameGet()
        {
            return nickName;
        }
        public static string passGet()
        {
            return pass;
        }
        public static void passSet(string param)
        {
            pass = param;
        }
        public static void passwordControl()
        {
            StreamReader srPass = new StreamReader(File.OpenRead(passwordPath));
            password = srPass.ReadToEnd();
            if (password != "")
            {
                String[] dataPass = password.Split(' ');
                srPass.Close();
                nickName= DecryptText(dataPass[0],"chareless");
                pass= DecryptText(dataPass[1],"chareless");
            }
            else
            {
                srPass.Close();
            }
        }
        public static void savePass()
        {
            StreamWriter swPass = new StreamWriter(passwordPath);
            swPass.Write(EncryptText(nickName,"chareless") + " " + EncryptText(pass,"chareless"));
            swPass.Close();
        }
        public static void changePassword(string nick, string pw)
        {
            nickName = nick;
            pass = pw;
            savePass();
        }

        public static string themeGet()
        {
            return theme;
        }
        public static void themeControl()
        {
            StreamReader srTheme = new StreamReader(File.OpenRead(settingsPath));
            theme = srTheme.ReadToEnd();
            String[] dataTheme = theme.Split(' ');
            srTheme.Close();
            if (dataTheme[1] == "dark")
            {
                theme = "dark";
            }
            else if (dataTheme[1] == "light")
            {
                theme = "light";
            }
            else if (dataTheme[1] == "blue")
            {
                theme = "blue";
            }
            else if(dataTheme[1] == "green")
            {
                theme = "green";
            }
            else if (dataTheme[1] == "red")
            {
                theme = "red";
            }
            else if (dataTheme[1] == "purple")
            {
                theme = "purple";
            }
        }
        public static void saveSettings(string thm, string lang)
        {
            theme = thm;
            language = lang;
            StreamWriter swTheme = new StreamWriter(settingsPath);
            swTheme.Write("theme" + " " + theme + " " + "language" + " " + language);
            swTheme.Close();
        }

        public static void saveImage()
        {
            Directory.CreateDirectory(filePath+date);
            SaveFileDialog saveImage = new SaveFileDialog();
            saveImage.InitialDirectory = filePath+date;
            saveImage.Filter = title[19];
            saveImage.OverwritePrompt = true;
            int length = imageCounter;
            delCounter = imageCounter;
            for (int i = 0; i < length; i++)
            {
                var path = Path.Combine(filePath+date, Path.GetFileName(myFile[i]));
                if (saveImage.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.Copy(myFile[i], path);
                        delCounter--;
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(title[10]);
                        delCounter--;
                    }
                    imageCounter--;
                }
                
            }
        }
        public static void saveFile(string text)
        {
            Directory.CreateDirectory(filePath+date);
            SaveFileDialog save = new SaveFileDialog();
            save.InitialDirectory = filePath+date;
            save.Filter = title[20];
            save.OverwritePrompt = true;
            save.CreatePrompt = true;

            if (save.ShowDialog() == DialogResult.OK)
            {
                passwordControl();
                if(text == nickName + " " + pass)
                {
                    text = "";
                }
                StreamWriter Kayit = new StreamWriter(save.FileName);
                Kayit.WriteLine(EncryptText(text,"chareless"));
                Kayit.Close();
            }
        }
        public static void saveAll(string text)
        {
            themeControl();
            passwordControl();
            saveFile(text);
            savePass();
            saveSettings(theme,language);
        }


        public static void languageTurkish()
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show(title[8], "", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                languageSet("turkish");
                Application.Restart();
            }
        }
        public static void languageEnglish()
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show(title[8], "", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                languageSet("english");
                Application.Restart();
            }
        }
        public static void languageSet(string lang)
        {
            language = lang;
            saveSettings(theme,language);
        }
        public static string languageGet()
        {
            return language;
        }
        public static void languageControl()
        {
            StreamReader srLang = new StreamReader(File.OpenRead(settingsPath));
            language = srLang.ReadToEnd();
            String[] dataLang = language.Split(' ');
            srLang.Close();
            if (dataLang[3] == "turkish")
            {
                language = "turkish";
            }
            else if (dataLang[3] == "english")
            {
                language = "english";
            }
            if (language == "turkish")
            {
                title[0] = "Giriş Başarılı.";
                title[1] = "Hatalı Giriş!";
                title[2] = "Kayıt Tamamlandı!";
                title[3] = "Zaten Kayıt Yapılmış.";
                title[4] = "Lütfen Kaydınızı Tamamlayın.";
                title[5] = "Metni Silmek İstediğinize Emin Misiniz ?";
                title[6] = "Bilgiler Güncellendi.";
                title[7] = "Hatalı Bilgiler!";
                title[8] = "Programı Yeniden Başlatıldıktan Sonra Güncellenecektir.";
                title[9] = "Text Dosyası Seçiniz..";
                title[10] = "Hatalı Dosya Seçimi!";
                title[11] = "Dijital Günlük v1.5";
                title[12] = "Dijital Günlük";
                title[13] = "Sürüm: 1.5";
                title[14] = "Kullanım Özellikleri";
                title[15] = "Dijital Günlük, kişinin kendi belirlediği kullanıcı adı ve şifreyle giriş yapabildiği bir günlük tutma programıdır. Yazdığınız\n" +
 "anılar sadece sizin bilgisayarınıza şifrelenerek kaydolur.Daha önce yazdığınız bir günü tekrar okuyabilir ve\n" +
 "düzenleyebilirsiniz. Metninizin yazı boyutunu değiştirebilirsiniz.\n" +
 "Programı çeşitli renk temalarında kullanabilirsiniz, dili Türkçe veya İngilizce olarak değiştirebilirsiniz.\n" +
 "Programa giriş için kullandığınız giriş bilgilerini değiştirebilirsiniz. Verilerinizi yedekleyebilirsiniz. Yenilikleri takip\n" +
 "edebilirsiniz ve sürüm notlarını görüntüleyebilirsiniz.Herhangi bir sorun veya öneri bildirmek için geliştiriciyle iletişime\n"+
 "geçebilirsiniz.";
                title[16] = "Tüm hakları saklıdır.";
                title[17] = "Resim Dosyası Seçiniz..";
                title[18] = "Dosya Sınırına Ulaştınız!";
                title[19] = "Resim Dosyası|*.jpg; *.jpeg; *.gif; *.bmp";
                title[20] = "Metin Dosyası|*.txt";
                title[21] = "Resimleri Silmek İstediğinize Emin Misiniz?";
                title[22] = "Dosya Bulunamadı.";
                title[23] = "Yedekleme Başarılı";
                title[24] = "Geri Yükleme Başarılı";

                menuName[0] = "Tema";
                menuName[1] = "Karanlık";
                menuName[2] = "Aydınlık";
                menuName[3] = "Türkçe";
                menuName[4] = "İngilizce";
                menuName[5] = "Dil";
                menuName[6] = "Kullanıcı Adı";
                menuName[7] = "Kullanıcı Şifre";
                menuName[8] = "KAYIT OL";
                menuName[9] = "GİRİŞ";
                menuName[10] = "Dijital Günlük";
                menuName[11] = "Dosya";
                menuName[12] = "Aç";
                menuName[13] = "Kaydet";
                menuName[14] = "Temizle";
                menuName[15] = "Araçlar";
                menuName[16] = "Giriş Bilgilerini Değiştir";
                menuName[17] = "Dil";
                menuName[18] = "Tema";
                menuName[19] = "Yazı Boyutu";
                menuName[20] = "Yardım";
                menuName[21] = "Hakkında";
                menuName[22] = "Geliştirici";
                menuName[23] = "Güncelleştirmeleri Denetle";
                menuName[24] = "Sürüm Notları";
                menuName[25] = "Bilgileri Güncelle";
                menuName[26] = "Dijital Günlük Hakkında";
                menuName[27] = "Bildir";
                menuName[28] = "Resim Ekle";
                menuName[29] = "Yedekle";
                menuName[30] = "Bulut Yedekleme";
                menuName[31] = "Yerel Yedekleme";
                menuName[32] = "Hata Bildir";
                menuName[33] = "Geri Yükle";
                menuName[34] = "Görüş Bildir ve Değerlendir";
                menuName[35] = "Diğer Renk Seçenekleri";
                menuName[36] = "Mavi";
                menuName[37] = "Yeşil";
                menuName[38] = "Kırmızı";
                menuName[39] = "Mor";
            }
            if(language == "english")
            {
                title[0] = "Login Successful.";
                title[1] = "Login Information is Wrong!";
                title[2] = "Registration Successful!";
                title[3] = "Already Registered.";
                title[4] = "Please Complete Your Registration.";
                title[5] = "Are You Sure You Want to Delete the Text?";
                title[6] = "Information Updated.";
                title[7] = "Incorrect Information!";
                title[8] = "Will be Updated After Restarting the Program";
                title[9] = "Select TXT File..";
                title[10] = "Incorrect File Selection!";
                title[11] = "Digital Diary v1.5";
                title[12] = "Digital Diary";
                title[13] = "Version: 1.5";
                title[14] = "Usage Specifications";
                title[15] = "Digital Journal is a logging program where the person can log in with his / her own username and password.\n"+
                   "The memories you write are saved only encrypted on your computer. You can read and edit a day that you wrote\n" +
                  "earlier. You can change the text size of your text.\n" +
 "You can use the program in various color themes, you can change the language to Turkish or English.\n" +
 "You can change the login information you use to login to the program. You can back up your data. You can follow the\n" +
 "innovations and view the release notes. You can contact the developer to report any problems or suggestions.";
                title[16] = "All rights reserved";
                title[17] = "Selece Image File..";
                title[18] = "You Have Reached the File Limit!";
                title[19] = "Image Files|*.jpg; *.jpeg; *.gif; *.bmp";
                title[20] = "Text Files|*.txt";
                title[21] = "Are You Sure You Want to Delete Images?";
                title[22] = "File Not Found";
                title[23] = "Backup Successful";
                title[24] = "Restore Successful";

                menuName[0] = "Theme";
                menuName[1] = "Dark";
                menuName[2] = "Light";
                menuName[3] = "Turkish";
                menuName[4] = "English";
                menuName[5] = "Language";
                menuName[6] = "Username";
                menuName[7] = "Password";
                menuName[8] = "SIGN IN";
                menuName[9] = "LOGIN";
                menuName[10] = "Digital Diary";
                menuName[11] = "File";
                menuName[12] = "Open";
                menuName[13] = "Save";
                menuName[14] = "Clear";
                menuName[15] = "Tools";
                menuName[16] = "Change Password";
                menuName[17] = "Language";
                menuName[18] = "Theme";
                menuName[19] = "Change Font Size";
                menuName[20] = "Help";
                menuName[21] = "About";
                menuName[22] = "Developer";
                menuName[23] = "Check for Updates";
                menuName[24] = "Patch Notes";
                menuName[25] = "Update Informations";
                menuName[26] = "About Digital Diary";
                menuName[27] = "Report";
                menuName[28] = "Add Image";
                menuName[29] = "Backup";
                menuName[30] = "Cloud Backup";
                menuName[31] = "Local Backup";
                menuName[32] = "Bug Report";
                menuName[33] = "Restore";
                menuName[34] = "Comment and Rate";
                menuName[35] = "Other Colors";
                menuName[36] = "Blue";
                menuName[37] = "Green";
                menuName[38] = "Red";
                menuName[39] = "Purple";
            }
            saveSettings(theme,language);
        }

        public static byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
        {
            byte[] encryptedBytes = null;

            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                        cs.Close();
                    }
                    encryptedBytes = ms.ToArray();
                }
            }

            return encryptedBytes;
        }
        public static byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
        {
            byte[] decryptedBytes = null;

            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
                        cs.Close();
                    }
                    decryptedBytes = ms.ToArray();
                }
            }

            return decryptedBytes;
        }

        public static string EncryptText(string input, string password)
        {
            byte[] bytesToBeEncrypted = Encoding.UTF8.GetBytes(input);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            byte[] bytesEncrypted = AES_Encrypt(bytesToBeEncrypted, passwordBytes);

            string result = Convert.ToBase64String(bytesEncrypted);

            return result;
        }
        public static string DecryptText(string input, string password)
        {
            byte[] bytesToBeDecrypted = Convert.FromBase64String(input);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            byte[] bytesDecrypted = AES_Decrypt(bytesToBeDecrypted, passwordBytes);

            string result = Encoding.UTF8.GetString(bytesDecrypted);

            return result;
        }
    }
}
