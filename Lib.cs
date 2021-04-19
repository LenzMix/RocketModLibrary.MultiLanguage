using Rocket.API.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger = Rocket.Core.Logging.Logger;
using Rocket.Unturned.Player;
using UnityEngine;
using Rocket.Core.Plugins;
using Rocket.Unturned.Chat;
using Rocket.Core;
using Rocket.API;

namespace SDMultiLangLib
{
    public class Lib
    {
        public IRocketPlugin LangPlug;

        public Lib(IRocketPlugin plugin)
        {
            this.LangPlug = plugin;
        }

        public bool CheckTranslateSystem(string id, TranslationList list)
        {
            try
            {
                Logger.Log($"[MultiLang] [{id}] Sync plugin translate...", System.ConsoleColor.Blue);
                if (!R.Plugins.GetPlugins().Exists(x => x.Name == "SDLangSystem"))
                {
                    Logger.Log($"[MultiLang] [{id}] Failed to sync translate - plugin not found, you can buy SDLangSystem on ImperialPlugins", System.ConsoleColor.Blue); 
                    return false;
                }
                if (R.Plugins.GetPlugins().Find(x => x.Name == "SDLangSystem").State != Rocket.API.PluginState.Loaded)
                {
                    Logger.Log($"[MultiLang] [{id}] Failed to sync translate - plugin not found, you can buy SDLangSystem on ImperialPlugins", System.ConsoleColor.Blue);
                    return false;
                }
                return checker1(id, list);
            }
            catch
            {
                Logger.Log($"[MultiLang] [{id}] Failed to sync translate - plugin not found, you can buy SDLangSystem on ImperialPlugins", System.ConsoleColor.Blue);
                return false;
            }
        }

        private bool checker1(string id, TranslationList list)
        {
            bool ready = SDLangSystem.Plugin.SyncTranslate(id, list);
            if (ready)
            {
                Logger.Log($"[MultiLang] [{id}] Successful sync!", System.ConsoleColor.Blue);
            }
            return ready;
        }

        public string MultiTranslate(UnturnedPlayer player, string pluginid, string key, params object[] parameters)
        {
            try
            {
                if (!R.Plugins.GetPlugins().Exists(x => x.Name == "SDLangSystem"))
                {
                    LangPlug.DefaultTranslations.Translate(key, parameters);
                    return null;
                }
                if (R.Plugins.GetPlugins().Find(x => x.Name == "SDLangSystem").State != Rocket.API.PluginState.Loaded)
                {
                    LangPlug.DefaultTranslations.Translate(key, parameters);
                    return null;
                }
                return func1(player, pluginid, key, parameters);
            }
            catch
            {
                LangPlug.DefaultTranslations.Translate(key, parameters);
                return null;
            }
        }

        private string func1(UnturnedPlayer player, string pluginid, string key, params object[] parameters)
        {
            return SDLangSystem.Plugin.GetTranslate(player, pluginid, key, parameters);
        }

        public bool MultiSay(UnturnedPlayer player, string pluginid, string key, Color color, params object[] parameters)
        {
            try
            {
                if (!R.Plugins.GetPlugins().Exists(x => x.Name == "SDLangSystem"))
                {
                    UnturnedChat.Say(player, LangPlug.DefaultTranslations.Translate(key, parameters), color);
                    return false;
                }
                if (R.Plugins.GetPlugins().Find(x => x.Name == "SDLangSystem").State != Rocket.API.PluginState.Loaded)
                {
                    UnturnedChat.Say(player, LangPlug.DefaultTranslations.Translate(key, parameters), color);
                    return false;
                }
                return func2(player, pluginid, key, color, parameters);
            }
            catch
            {
                UnturnedChat.Say(player, LangPlug.DefaultTranslations.Translate(key, parameters), color);
                return false;
            }
        }

        private bool func2(UnturnedPlayer player, string pluginid, string key, Color color, params object[] parameters)
        {
            return SDLangSystem.Plugin.SendChat(player, pluginid, key, color, parameters);
        }

        public bool MultiSay(UnturnedPlayer player, string pluginid, string key, params object[] parameters)
        {
            try
            {
                if (!R.Plugins.GetPlugins().Exists(x => x.Name == "SDLangSystem"))
                {
                    UnturnedChat.Say(player, LangPlug.DefaultTranslations.Translate(key, parameters));
                    return false;
                }
                if (R.Plugins.GetPlugins().Find(x => x.Name == "SDLangSystem").State != Rocket.API.PluginState.Loaded)
                {
                    UnturnedChat.Say(player, LangPlug.DefaultTranslations.Translate(key, parameters));
                    return false;
                }
                return func3(player, pluginid, key, Color.green, parameters);
            }
            catch
            {
                UnturnedChat.Say(player, LangPlug.DefaultTranslations.Translate(key, parameters));
                return false;
            }
        }

        private bool func3(UnturnedPlayer player, string pluginid, string key, Color color, params object[] parameters)
        {
            return SDLangSystem.Plugin.SendChat(player, pluginid, key, Color.green, parameters);
        }

        public bool MultiSay(UnturnedPlayer player, string pluginid, string key, Color color)
        {
            try
            {
                if (!R.Plugins.GetPlugins().Exists(x => x.Name == "SDLangSystem"))
                {
                    UnturnedChat.Say(player, LangPlug.DefaultTranslations.Translate(key), color);
                    return false;
                }
                if (R.Plugins.GetPlugins().Find(x => x.Name == "SDLangSystem").State != Rocket.API.PluginState.Loaded)
                {
                    UnturnedChat.Say(player, LangPlug.DefaultTranslations.Translate(key), color);
                    return false;
                }
                return func4(player, pluginid, key, color);
            }
            catch
            {
                UnturnedChat.Say(player, LangPlug.DefaultTranslations.Translate(key), color);
                return false;
            }
        }

        private bool func4(UnturnedPlayer player, string pluginid, string key, Color color)
        {
            return SDLangSystem.Plugin.SendChat(player, pluginid, key, color);
        }

        public bool MultiSay(UnturnedPlayer player, string pluginid, string key)
        {
            try
            {
                if (!R.Plugins.GetPlugins().Exists(x => x.Name == "SDLangSystem"))
                {
                    UnturnedChat.Say(player, LangPlug.DefaultTranslations.Translate(key));
                    return false;
                }
                if (R.Plugins.GetPlugins().Find(x => x.Name == "SDLangSystem").State != Rocket.API.PluginState.Loaded)
                {
                    UnturnedChat.Say(player, LangPlug.DefaultTranslations.Translate(key));
                    return false;
                }
                return func5(player, pluginid, key);
            }
            catch
            {
                UnturnedChat.Say(player, LangPlug.DefaultTranslations.Translate(key));
                return false;
            }
        }

        private bool func5(UnturnedPlayer player, string pluginid, string key)
        {
            return SDLangSystem.Plugin.SendChat(player, pluginid, key, Color.green);
        }

        public string MultiTranslate(string lang, string pluginid, string key, params object[] parameters)
        {
            try
            {
                if (!R.Plugins.GetPlugins().Exists(x => x.Name == "SDLangSystem"))
                {
                    LangPlug.DefaultTranslations.Translate(key, parameters);
                    return null;
                }
                if (R.Plugins.GetPlugins().Find(x => x.Name == "SDLangSystem").State != Rocket.API.PluginState.Loaded)
                {
                    LangPlug.DefaultTranslations.Translate(key, parameters);
                    return null;
                }
                return func6(lang, pluginid, key, parameters);
            }
            catch
            {
                LangPlug.DefaultTranslations.Translate(key, parameters);
                return null;
            }
        }

        private string func6(string lang, string pluginid, string key, params object[] parameters)
        {
            return SDLangSystem.Plugin.GetTranslate(lang, pluginid, key, parameters);
        }

        public string MultiTranslate(UnturnedPlayer player, string pluginid, string key)
        {
            try
            {
                if (!R.Plugins.GetPlugins().Exists(x => x.Name == "SDLangSystem"))
                {
                    LangPlug.DefaultTranslations.Translate(key);
                    return null;
                }
                if (R.Plugins.GetPlugins().Find(x => x.Name == "SDLangSystem").State != Rocket.API.PluginState.Loaded)
                {
                    LangPlug.DefaultTranslations.Translate(key);
                    return null;
                }
                return func7(player, pluginid, key);
            }
            catch
            {
                LangPlug.DefaultTranslations.Translate(key);
                return null;
            }
        }

        private string func7(UnturnedPlayer player, string pluginid, string key)
        {
            return SDLangSystem.Plugin.GetTranslate(player, pluginid, key);
        }

        public string MultiTranslate(string lang, string pluginid, string key)
        {
            try
            {
                if (!R.Plugins.GetPlugins().Exists(x => x.Name == "SDLangSystem"))
                {
                    LangPlug.DefaultTranslations.Translate(key);
                    return null;
                }
                if (R.Plugins.GetPlugins().Find(x => x.Name == "SDLangSystem").State != Rocket.API.PluginState.Loaded)
                {
                    LangPlug.DefaultTranslations.Translate(key);
                    return null;
                }
                return func8(lang, pluginid, key);
            }
            catch
            {
                LangPlug.DefaultTranslations.Translate(key);
                return null;
            }
        }

        private string func8(string lang, string pluginid, string key)
        {
            return SDLangSystem.Plugin.GetTranslate(lang, pluginid, key);
        }

        public bool BroadCast(string pluginid, string key, Color color, params object[] parameters)
        {
            try
            {
                if (!R.Plugins.GetPlugins().Exists(x => x.Name == "SDLangSystem"))
                {
                    UnturnedChat.Say(LangPlug.DefaultTranslations.Translate(key, parameters), color);
                    return false;
                }
                if (R.Plugins.GetPlugins().Find(x => x.Name == "SDLangSystem").State != Rocket.API.PluginState.Loaded)
                {
                    UnturnedChat.Say(LangPlug.DefaultTranslations.Translate(key, parameters), color);
                    return false;
                };
                return func9(pluginid, key, color, parameters);
            }
            catch
            {
                UnturnedChat.Say(LangPlug.DefaultTranslations.Translate(key, parameters), color);
                return false;
            }
        }

        private bool func9(string pluginid, string key, Color color, params object[] parameters)
        {
            return SDLangSystem.Plugin.BroadCast(pluginid, key, color, parameters);
        }

        public bool BroadCast(string pluginid, string key, params object[] parameters)
        {
            try
            {
                if (!R.Plugins.GetPlugins().Exists(x => x.Name == "SDLangSystem"))
                {
                    UnturnedChat.Say(LangPlug.DefaultTranslations.Translate(key, parameters));
                    return false;
                }
                if (R.Plugins.GetPlugins().Find(x => x.Name == "SDLangSystem").State != Rocket.API.PluginState.Loaded)
                {
                    UnturnedChat.Say(LangPlug.DefaultTranslations.Translate(key, parameters));
                    return false;
                }
                return func10(pluginid, key, Color.yellow, parameters);
            }
            catch
            {
                UnturnedChat.Say(LangPlug.DefaultTranslations.Translate(key, parameters));
                return false;
            }
        }

        private bool func10(string pluginid, string key, params object[] parameters)
        {
            return SDLangSystem.Plugin.BroadCast(pluginid, key, Color.yellow, parameters);
        }

        public bool BroadCast(string pluginid, string key, Color color)
        {
            try
            {
                if (!R.Plugins.GetPlugins().Exists(x => x.Name == "SDLangSystem"))
                {
                    UnturnedChat.Say(LangPlug.DefaultTranslations.Translate(key), color);
                    return false;
                }
                if (R.Plugins.GetPlugins().Find(x => x.Name == "SDLangSystem").State != Rocket.API.PluginState.Loaded)
                {
                    UnturnedChat.Say(LangPlug.DefaultTranslations.Translate(key), color);
                    return false;
                }
                return func11(pluginid, key, color);
            }
            catch
            {
                UnturnedChat.Say(LangPlug.DefaultTranslations.Translate(key), color);
                return false;
            }
        }

        private bool func11(string pluginid, string key, Color color)
        {
            return SDLangSystem.Plugin.BroadCast(pluginid, key, color);
        }

        public bool BroadCast(string pluginid, string key)
        {
            try
            {
                if (!R.Plugins.GetPlugins().Exists(x => x.Name == "SDLangSystem")) 
            {
                    UnturnedChat.Say(LangPlug.DefaultTranslations.Translate(key));
                    return false;
                }
                if (R.Plugins.GetPlugins().Find(x => x.Name == "SDLangSystem").State != Rocket.API.PluginState.Loaded)
                {
                    UnturnedChat.Say(LangPlug.DefaultTranslations.Translate(key));
                    return false;
                }
                return func12(pluginid, key);
            }
            catch
            {
                UnturnedChat.Say(LangPlug.DefaultTranslations.Translate(key));
                return false;
            }
        }

        private bool func12(string pluginid, string key)
        {
            return SDLangSystem.Plugin.BroadCast(pluginid, key, Color.yellow);
        }

        public string GetLang(UnturnedPlayer player)
        {
            try
            {
                if (!R.Plugins.GetPlugins().Exists(x => x.Name == "SDLangSystem")) return null;
                if (R.Plugins.GetPlugins().Find(x => x.Name == "SDLangSystem").State != Rocket.API.PluginState.Loaded) return null;
                return func13(player);
            }
            catch
            {
                return null;
            }
        }

        private string func13(UnturnedPlayer player)
        {
            return SDLangSystem.Plugin.GetLang(player);
        }

        public string GetLangName(UnturnedPlayer player)
        {
            try
            {
                if (!R.Plugins.GetPlugins().Exists(x => x.Name == "SDLangSystem")) return null;
                if (R.Plugins.GetPlugins().Find(x => x.Name == "SDLangSystem").State != Rocket.API.PluginState.Loaded) return null;
                return func14(player);
            }
            catch
            {
                return null;
            }
        }

        private string func14(UnturnedPlayer player)
        {
            return SDLangSystem.Plugin.GetLangName(player);
        }

        public string GetLangName(string id)
        {
            try
            {
                if (!R.Plugins.GetPlugins().Exists(x => x.Name == "SDLangSystem")) return null;
                if (R.Plugins.GetPlugins().Find(x => x.Name == "SDLangSystem").State != Rocket.API.PluginState.Loaded) return null;
                return func15(id);
            }
            catch
            {
                return null;
            }
        }

        private string func15(string id)
        {
            return SDLangSystem.Plugin.GetLangName(id);
        }

    }
}
