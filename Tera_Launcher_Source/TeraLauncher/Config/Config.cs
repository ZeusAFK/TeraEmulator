using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeraLauncher
{
    public static class Config
    {
        //Launcher Title
        public static String GetLauncherTitle(String defaultValue = "tera-online custom-launcher beta.a2")
        {
            String _titleLauncher = defaultValue;
            try
            {
                _titleLauncher = IniReader.ReadValue("Launcher", "launcherTitle", LoginForm.ConfigFile);
                if (_titleLauncher == "")
                {
                    _titleLauncher = defaultValue;
                    IniReader.WriteValue("Launcher", "launcherTitle", "tera-online custom-launcher beta.a2", LoginForm.ConfigFile);
                    ///new Logger.Logger(LogMsg.MSG_ERROR, "launcher Error! - launcherTitle not found! using default value!");
                }
            }
            catch (Exception /*ex*/)
            {
                //new Logger(LogMsg.MSG_ERROR, "Config: launcherTitle not found!");
            }
            return _titleLauncher;
        }
        //Launcher Background
        public static String GetLauncherBackground(String defaultValue = "launcher-bg.png")
        {
            String _backgroundLauncher = defaultValue;
            try
            {
                _backgroundLauncher = IniReader.ReadValue("Skin", "launcherBackground", LoginForm.ConfigFile);
                if (_backgroundLauncher == "")
                {
                    _backgroundLauncher = defaultValue;
                    IniReader.WriteValue("Skin", "launcherBackground", "launcher-bg.png", LoginForm.ConfigFile);
                    ///new Logger.Logger(LogMsg.MSG_ERROR, "launcher Error! - launcherBackground not found! using default value!");
                }
            }
            catch (Exception /*ex*/)
            {
                //new Logger(LogMsg.MSG_ERROR, "Config: launcherBackground not found!");
            }
            return _backgroundLauncher;
        }
        //Register Background
        public static String GetRegisterBackground(String defaultValue = "register-bg.png")
        {
            String _backgroundRegister = defaultValue;
            try
            {
                _backgroundRegister = IniReader.ReadValue("Skin", "registerBackground", LoginForm.ConfigFile);
                if (_backgroundRegister == "")
                {
                    _backgroundRegister = defaultValue;
                    IniReader.WriteValue("Skin", "registerBackground", "register-bg.png", LoginForm.ConfigFile);
                    ///new Logger.Logger(LogMsg.MSG_ERROR, "launcher Error! - registerBackground not found! using default value!");
                }
            }
            catch (Exception /*ex*/)
            {
                //new Logger(LogMsg.MSG_ERROR, "Config: registerBackground not found!");
            }
            return _backgroundRegister;
        }
        //MinimizeButton-normal
        public static String GetMinimizeButtonNormal(String defaultValue = "btn-minimize-nm.png")
        {
            String _btn_minimize_nm = defaultValue;
            try
            {
                _btn_minimize_nm = IniReader.ReadValue("Skin", "btnMinimizeNm", LoginForm.ConfigFile);
                if (_btn_minimize_nm == "")
                {
                    _btn_minimize_nm = defaultValue;
                    IniReader.WriteValue("Skin", "btnMinimizeNm", "btn-minimize-nm.png", LoginForm.ConfigFile);
                    ///new Logger.Logger(LogMsg.MSG_ERROR, "launcher Error! - btnMinimizeNm not found! using default value!");
                }
            }
            catch (Exception /*ex*/)
            {
                //new Logger(LogMsg.MSG_ERROR, "Config: btnMinimizeNm not found!");
            }
            return _btn_minimize_nm;
        }
        //MinimizeButton-hover
        public static String GetMinimizeButtonHover(String defaultValue = "btn-minimize-hv.png")
        {
            String _btn_minimize_hv = defaultValue;
            try
            {
                _btn_minimize_hv = IniReader.ReadValue("Skin", "btnMinimizeHv", LoginForm.ConfigFile);
                if (_btn_minimize_hv == "")
                {
                    _btn_minimize_hv = defaultValue;
                    IniReader.WriteValue("Skin", "btnMinimizeHv", "btn-minimize-hv.png", LoginForm.ConfigFile);
                    ///new Logger.Logger(LogMsg.MSG_ERROR, "launcher Error! - btnMinimizeHv not found! using default value!");
                }
            }
            catch (Exception /*ex*/)
            {
                //new Logger(LogMsg.MSG_ERROR, "Config: btnMinimizeHv not found!");
            }
            return _btn_minimize_hv;
        }       
        //CloseButton-normal
        public static String GetCloseButtonNormal(String defaultValue = "btn-close-nm.png")
        {
            String _btn_close_nm = defaultValue;
            try
            {
                _btn_close_nm = IniReader.ReadValue("Skin", "btnCloseNm", LoginForm.ConfigFile);
                if (_btn_close_nm == "")
                {
                    _btn_close_nm = defaultValue;
                    IniReader.WriteValue("Skin", "btnCloseNm", "btn-close-nm.png", LoginForm.ConfigFile);
                    ///new Logger.Logger(LogMsg.MSG_ERROR, "launcher Error! - btnCloseNm not found! using default value!");
                }
            }
            catch (Exception /*ex*/)
            {
                //new Logger(LogMsg.MSG_ERROR, "Config: btnCloseNm not found!");
            }
            return _btn_close_nm;
        }
        //CloseButton-hover
        public static String GetCloseButtonHover(String defaultValue = "btn-close-hv.png")
        {
            String _btn_close_hv = defaultValue;
            try
            {
                _btn_close_hv = IniReader.ReadValue("Skin", "btnCloseHv", LoginForm.ConfigFile);
                if (_btn_close_hv == "")
                {
                    _btn_close_hv = defaultValue;
                    IniReader.WriteValue("Skin", "btnCloseHv", "btn-close-hv.png", LoginForm.ConfigFile);
                    ///new Logger.Logger(LogMsg.MSG_ERROR, "launcher Error! - btnCloseHv not found! using default value!");
                }
            }
            catch (Exception /*ex*/)
            {
                //new Logger(LogMsg.MSG_ERROR, "Config: btnCloseHv not found!");
            }
            return _btn_close_hv;
        }       
        //CreateButton-normal
        public static String GetCreateButtonNormal(String defaultValue = "btn-create-nm.png")
        {
            String _btn_create_nm = defaultValue;
            try
            {
                _btn_create_nm = IniReader.ReadValue("Skin", "btnCreateNm", LoginForm.ConfigFile);
                if (_btn_create_nm == "")
                {
                    _btn_create_nm = defaultValue;
                    IniReader.WriteValue("Skin", "btnCreateNm", "btn-create-nm.png", LoginForm.ConfigFile);
                    ///new Logger.Logger(LogMsg.MSG_ERROR, "launcher Error! - btnCreateNm not found! using default value!");
                }
            }
            catch (Exception /*ex*/)
            {
                //new Logger(LogMsg.MSG_ERROR, "Config: btnCreateNm not found!");
            }
            return _btn_create_nm;
        }
        //CreateButton-hover
        public static String GetCreateButtonHover(String defaultValue = "btn-create-hv.png")
        {
            String _btn_create_hv = defaultValue;
            try
            {
                _btn_create_hv = IniReader.ReadValue("Skin", "btnCreateHv", LoginForm.ConfigFile);
                if (_btn_create_hv == "")
                {
                    _btn_create_hv = defaultValue;
                    IniReader.WriteValue("Skin", "btnCreateHv", "btn-create-hv.png", LoginForm.ConfigFile);
                    ///new Logger.Logger(LogMsg.MSG_ERROR, "launcher Error! - btnCreateHv not found! using default value!");
                }
            }
            catch (Exception /*ex*/)
            {
                //new Logger(LogMsg.MSG_ERROR, "Config: btnCreateHv not found!");
            }
            return _btn_create_hv;
        }       
        //LoginButton-normal
        public static String GetLoginButtonNormal(String defaultValue = "btn-login-nm.png")
        {
            String _btn_login_nm = defaultValue;
            try
            {
                _btn_login_nm = IniReader.ReadValue("Skin", "btnLoginNm", LoginForm.ConfigFile);
                if (_btn_login_nm == "")
                {
                    _btn_login_nm = defaultValue;
                    IniReader.WriteValue("Skin", "btnLoginNm", "btn-login-nm.png", LoginForm.ConfigFile);
                    ///new Logger.Logger(LogMsg.MSG_ERROR, "launcher Error! - btnLoginNm not found! using default value!");
                }
            }
            catch (Exception /*ex*/)
            {
                //new Logger(LogMsg.MSG_ERROR, "Config: btnLoginNm not found!");
            }
            return _btn_login_nm;
        }
        //LoginButton-hover
        public static String GetLoginButtonHover(String defaultValue = "btn-login-hv.png")
        {
            String _btn_login_hv = defaultValue;
            try
            {
                _btn_login_hv = IniReader.ReadValue("Skin", "btnLoginHv", LoginForm.ConfigFile);
                if (_btn_login_hv == "")
                {
                    _btn_login_hv = defaultValue;
                    IniReader.WriteValue("Skin", "btnLoginHv", "btn-login-hv.png", LoginForm.ConfigFile);
                    ///new Logger.Logger(LogMsg.MSG_ERROR, "launcher Error! - btnLoginHv not found! using default value!");
                }
            }
            catch (Exception /*ex*/)
            {
                //new Logger(LogMsg.MSG_ERROR, "Config: btnLoginHv not found!");
            }
            return _btn_login_hv;
        }       
        //LogoutButton-normal
        public static String GetLogoutButtonNormal(String defaultValue = "btn-logout-nm.png")
        {
            String _btn_logout_nm = defaultValue;
            try
            {
                _btn_logout_nm = IniReader.ReadValue("Skin", "btnLogoutNm", LoginForm.ConfigFile);
                if (_btn_logout_nm == "")
                {
                    _btn_logout_nm = defaultValue;
                    IniReader.WriteValue("Skin", "btnLogoutNm", "btn-logout-nm.png", LoginForm.ConfigFile);
                    ///new Logger.Logger(LogMsg.MSG_ERROR, "launcher Error! - btnLogoutNm not found! using default value!");
                }
            }
            catch (Exception /*ex*/)
            {
                //new Logger(LogMsg.MSG_ERROR, "Config: btnLogoutNm not found!");
            }
            return _btn_logout_nm;
        }
        //LoginButton-hover
        public static String GetLogoutButtonHover(String defaultValue = "btn-logout-hv.png")
        {
            String _btn_logout_hv = defaultValue;
            try
            {
                _btn_logout_hv = IniReader.ReadValue("Skin", "btnLogoutHv", LoginForm.ConfigFile);
                if (_btn_logout_hv == "")
                {
                    _btn_logout_hv = defaultValue;
                    IniReader.WriteValue("Skin", "btnLogoutHv", "btn-logout-hv.png", LoginForm.ConfigFile);
                    ///new Logger.Logger(LogMsg.MSG_ERROR, "launcher Error! - btnLogoutHv not found! using default value!");
                }
            }
            catch (Exception /*ex*/)
            {
                //new Logger(LogMsg.MSG_ERROR, "Config: btnLogoutHv not found!");
            }
            return _btn_logout_hv;
        }       
        //PlayButton-normal
        public static String GetPlayButtonNormal(String defaultValue = "btn-play-nm.png")
        {
            String _btn_play_nm = defaultValue;
            try
            {
                _btn_play_nm = IniReader.ReadValue("Skin", "btnPlayNm", LoginForm.ConfigFile);
                if (_btn_play_nm == "")
                {
                    _btn_play_nm = defaultValue;
                    IniReader.WriteValue("Skin", "btnPlayNm", "btn-play-nm.png", LoginForm.ConfigFile);
                    ///new Logger.Logger(LogMsg.MSG_ERROR, "launcher Error! - btnPlayNm not found! using default value!");
                }
            }
            catch (Exception /*ex*/)
            {
                //new Logger(LogMsg.MSG_ERROR, "Config: btnPlayNm not found!");
            }
            return _btn_play_nm;
        }
        //PlayButton-hover
        public static String GetPlayButtonHover(String defaultValue = "btn-play-hv.png")
        {
            String _btn_play_hv = defaultValue;
            try
            {
                _btn_play_hv = IniReader.ReadValue("Skin", "btnPlayHv", LoginForm.ConfigFile);
                if (_btn_play_hv == "")
                {
                    _btn_play_hv = defaultValue;
                    IniReader.WriteValue("Skin", "btnPlayHv", "btn-play-hv.png", LoginForm.ConfigFile);
                    ///new Logger.Logger(LogMsg.MSG_ERROR, "launcher Error! - btnPlayHv not found! using default value!");
                }
            }
            catch (Exception /*ex*/)
            {
                //new Logger(LogMsg.MSG_ERROR, "Config: btnPlayHv not found!");
            }
            return _btn_play_hv;
        }       
        //RegisterButton-normal
        public static String GetRegisterButtonNormal(String defaultValue = "btn-register-nm.png")
        {
            String _btn_register_nm = defaultValue;
            try
            {
                _btn_register_nm = IniReader.ReadValue("Skin", "btnRegisterNm", LoginForm.ConfigFile);
                if (_btn_register_nm == "")
                {
                    _btn_register_nm = defaultValue;
                    IniReader.WriteValue("Skin", "btnRegisterNm", "btn-register-nm.png", LoginForm.ConfigFile);
                    ///new Logger.Logger(LogMsg.MSG_ERROR, "launcher Error! - btnRegisterNm not found! using default value!");
                }
            }
            catch (Exception /*ex*/)
            {
                //new Logger(LogMsg.MSG_ERROR, "Config: btnRegisterNm not found!");
            }
            return _btn_register_nm;
        }
        //RegisterButton-hover
        public static String GetRegisterButtonHover(String defaultValue = "btn-register-hv.png")
        {
            String _btn_register_hv = defaultValue;
            try
            {
                _btn_register_hv = IniReader.ReadValue("Skin", "btnRegisterHv", LoginForm.ConfigFile);
                if (_btn_register_hv == "")
                {
                    _btn_register_hv = defaultValue;
                    IniReader.WriteValue("Skin", "btnRegisterHv", "btn-register-hv.png", LoginForm.ConfigFile);
                    ///new Logger.Logger(LogMsg.MSG_ERROR, "launcher Error! - btnRegisterHv not found! using default value!");
                }
            }
            catch (Exception /*ex*/)
            {
                //new Logger(LogMsg.MSG_ERROR, "Config: btnRegisterHv not found!");
            }
            return _btn_register_hv;
        }
        //PictureBoxNews
        public static String GetPictureBoxNews(String defaultValue = "pbox-news.png")
        {
            String _pbox_news = defaultValue;
            try
            {
                _pbox_news = IniReader.ReadValue("Skin", "pboxNews", LoginForm.ConfigFile);
                if (_pbox_news == "")
                {
                    _pbox_news = defaultValue;
                    IniReader.WriteValue("Skin", "pboxNews", "pbox-news.png", LoginForm.ConfigFile);
                    ///new Logger.Logger(LogMsg.MSG_ERROR, "launcher Error! - pboxNews not found! using default value!");
                }
            }
            catch (Exception /*ex*/)
            {
                //new Logger(LogMsg.MSG_ERROR, "Config: pboxNews not found!");
            }
            return _pbox_news;
        }

        //LanguageGame
        public static String GetLanguageGame(String defaultValue = "de")
        {
            String _language_game = defaultValue;
            try
            {
                _language_game = IniReader.ReadValue("Launcher", "languageGame", LoginForm.ConfigFile);
                if (_language_game == "")
                {
                    _language_game = defaultValue;
                    IniReader.WriteValue("Launcher", "languageGame", "de", LoginForm.ConfigFile);
                    ///new Logger.Logger(LogMsg.MSG_ERROR, "launcher Error! - pboxNews not found! using default value!");
                }
            }
            catch (Exception /*ex*/)
            {
                //new Logger(LogMsg.MSG_ERROR, "Config: pboxNews not found!");
            }
            return _language_game;
        }

        //LanguageGame
        public static int GetLanguageId(int defaultValue = 1)
        {
            int _language_id = defaultValue;
            try
            {
                if (GetLanguageGame() == "") { _language_id = defaultValue; }

                else if (GetLanguageGame() == "en") { _language_id = 1; }
                else if (GetLanguageGame() == "fr") { _language_id = 2; }
                else if (GetLanguageGame() == "de") { _language_id = 3; }

                else if (GetLanguageGame() != "en" || GetLanguageGame() != "fr" || GetLanguageGame() != "de") { _language_id = 1; }
            }
            catch (Exception /*ex*/)
            {
                //new Logger(LogMsg.MSG_ERROR, "Config: pboxNews not found!");
            }
            return _language_id;
        }   

    }
}
