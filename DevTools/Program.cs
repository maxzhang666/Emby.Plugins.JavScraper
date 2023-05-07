// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using DevTools;
using DevTools.Log;
using Emby.Plugins.JavScraper;
using Emby.Plugins.JavScraper.Configuration;
using Emby.Plugins.JavScraper.Scrapers;

var logManage = new LogManage();

var plugin = new Plugin(new ApplicationPaths(), null, null, null, logManage);
Plugin.Instance.UpdateConfigurationTest(new PluginConfiguration()
{
    ProxyType = (int)ProxyTypeEnum.JsProxy,
    JsProxy = ""
});

var scrapers = new JavBus(logManage);

var res = await scrapers.Query("");

if (res.Count > 0)
{
    var item = await scrapers.Get(res.FirstOrDefault());
}


Console.WriteLine("Hello, World!");