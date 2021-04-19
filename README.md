# RocketModLibrary.MultiLanguage
Library for work with SDLangSystem

How to connect Library
===========
> 1. Add constant like 
> ```
>       public const string pluginid = "SDLangSystem";
>       public static SDMultiLangLib.Lib SDLL;
> ```
>
> 2. Add in 'Load' 
> ```
>       SDLL = new SDMultiLangLib.Lib(this);
> ```
>
> 3. Add in 'OnLoaded' event for checking or creating translation for all language, that serverowner made in CFG of SDLangSystem 
> ```
>       SDLL.CheckTranslateSystem(pluginid, DefaultTranslations);
> ```


Methods, that you need to replace
===========
> * MultiTranslate(UnturnedPlayer player, string pluginid, string key, params object[] parameters)
> Replace Translate() for player's language. You can change player on langid and remove parameters, if you don't have it
> 
> * MultiSay(UnturnedPlayer player, string pluginid, string key, Color color, params object[] parameters)
> Replace UnturnedChat.Say() for players. You can remove color and parameters, if you don't have it
> 
> * BroadCast(string pluginid, string key, Color color, params object[] parameters)
> Replace UnturnedChat.Say() or what you use for it. You can remove color and parameters, if you don't have it
> 
> * GetLang(UnturnedPlayer player)
> Get language id that use player
> 
> * GetLangName(Player or ID of language)
> Get Language name from plugin


What happend, if serverowner don't have SDLangSystem?
===========
> Methods return null or false and then it automatic use standart Translate system and UnturnedChat functions. 

