// <auto-generated>
// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
// </auto-generated>
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Generated;
using Newtonsoft.Json;
using System.Configuration;

namespace Facebook
{
    public partial class FacebookAppExtensionsTest
    {
[TestMethod]
[PexGeneratedBy(typeof(FacebookAppExtensionsTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void Api01ThrowsArgumentNullException783()
{
    object o;
    o =
      this.Api01((FacebookAppBase)null, (string)null, (string)null, HttpMethod.Get);
}
[TestMethod]
[PexGeneratedBy(typeof(FacebookAppExtensionsTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void Api01ThrowsArgumentNullException908()
{
    FacebookApp facebookApp;
    object o;
    FacebookSettings s0 = new FacebookSettings();
    s0.ApiKey = (string)null;
    s0.ApiSecret = (string)null;
    s0.AppId = (string)null;
    s0.CookieSupport = false;
    s0.BaseDomain = (string)null;
    s0.MaxRetries = 0;
    s0.RetryDelay = 0;
    facebookApp = new FacebookApp((IFacebookSettings)s0);
    facebookApp.MaxRetries = 0;
    facebookApp.RetryDelay = 0;
    facebookApp.Session = (FacebookSession)null;
    o = this.Api01
            ((FacebookAppBase)facebookApp, (string)null, (string)null, HttpMethod.Get);
}
[TestMethod]
[PexGeneratedBy(typeof(FacebookAppExtensionsTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void Api01ThrowsArgumentNullException437()
{
    FacebookApp facebookApp;
    object o;
    FacebookSettings s0 = new FacebookSettings();
    s0.ApiKey = (string)null;
    s0.ApiSecret = (string)null;
    s0.AppId = (string)null;
    s0.CookieSupport = true;
    s0.BaseDomain = (string)null;
    s0.MaxRetries = 0;
    s0.RetryDelay = 0;
    facebookApp = new FacebookApp((IFacebookSettings)s0);
    facebookApp.MaxRetries = 0;
    facebookApp.RetryDelay = 0;
    facebookApp.Session = (FacebookSession)null;
    o = this.Api01
            ((FacebookAppBase)facebookApp, (string)null, (string)null, HttpMethod.Get);
}
[TestMethod]
[PexGeneratedBy(typeof(FacebookAppExtensionsTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void Api01ThrowsArgumentNullException330()
{
    FacebookApp facebookApp;
    object o;
    FacebookSettings s0 = new FacebookSettings();
    s0.ApiKey = (string)null;
    s0.ApiSecret = (string)null;
    s0.AppId = (string)null;
    s0.CookieSupport = false;
    s0.BaseDomain = (string)null;
    s0.MaxRetries = 0;
    s0.RetryDelay = 0;
    facebookApp = new FacebookApp((IFacebookSettings)s0);
    facebookApp.MaxRetries = 0;
    facebookApp.RetryDelay = 0;
    facebookApp.Session = (FacebookSession)null;
    o = this.Api01((FacebookAppBase)facebookApp, "\0", (string)null, HttpMethod.Get);
}
[TestMethod]
[PexGeneratedBy(typeof(FacebookAppExtensionsTest))]
[PexRaisedException(typeof(JsonReaderException))]
public void Api01ThrowsJsonReaderException161()
{
    FacebookApp facebookApp;
    object o;
    FacebookSettings s0 = new FacebookSettings();
    s0.ApiKey = (string)null;
    s0.ApiSecret = (string)null;
    s0.AppId = (string)null;
    s0.CookieSupport = false;
    s0.BaseDomain = (string)null;
    s0.MaxRetries = 0;
    s0.RetryDelay = 0;
    facebookApp = new FacebookApp((IFacebookSettings)s0);
    facebookApp.MaxRetries = 0;
    facebookApp.RetryDelay = 0;
    facebookApp.Session = (FacebookSession)null;
    o = this.Api01((FacebookAppBase)facebookApp, "\0", "\0", HttpMethod.Get);
}
[TestMethod]
[PexGeneratedBy(typeof(FacebookAppExtensionsTest))]
[PexRaisedException(typeof(JsonReaderException))]
public void Api01ThrowsJsonReaderException964()
{
    FacebookApp facebookApp;
    object o;
    FacebookSettings s0 = new FacebookSettings();
    s0.ApiKey = (string)null;
    s0.ApiSecret = (string)null;
    s0.AppId = (string)null;
    s0.CookieSupport = false;
    s0.BaseDomain = (string)null;
    s0.MaxRetries = 0;
    s0.RetryDelay = 0;
    facebookApp = new FacebookApp((IFacebookSettings)s0);
    facebookApp.MaxRetries = 0;
    facebookApp.RetryDelay = 0;
    facebookApp.Session = (FacebookSession)null;
    o = this.Api01((FacebookAppBase)facebookApp, "\0\0", "\0", HttpMethod.Get);
}
[TestMethod]
[PexGeneratedBy(typeof(FacebookAppExtensionsTest))]
[PexRaisedException(typeof(JsonReaderException))]
public void Api01ThrowsJsonReaderException104()
{
    FacebookApp facebookApp;
    object o;
    FacebookSettings s0 = new FacebookSettings();
    s0.ApiKey = (string)null;
    s0.ApiSecret = (string)null;
    s0.AppId = (string)null;
    s0.CookieSupport = false;
    s0.BaseDomain = (string)null;
    s0.MaxRetries = 0;
    s0.RetryDelay = 0;
    facebookApp = new FacebookApp((IFacebookSettings)s0);
    facebookApp.MaxRetries = 0;
    facebookApp.RetryDelay = 0;
    facebookApp.Session = (FacebookSession)null;
    o = this.Api01((FacebookAppBase)facebookApp, "\0", "\0", HttpMethod.Post);
}
[TestMethod]
[PexGeneratedBy(typeof(FacebookAppExtensionsTest))]
[PexRaisedException(typeof(JsonReaderException))]
public void Api01ThrowsJsonReaderException908()
{
    FacebookApp facebookApp;
    object o;
    FacebookSettings s0 = new FacebookSettings();
    s0.ApiKey = (string)null;
    s0.ApiSecret = (string)null;
    s0.AppId = "\0";
    s0.CookieSupport = false;
    s0.BaseDomain = (string)null;
    s0.MaxRetries = 0;
    s0.RetryDelay = 0;
    facebookApp = new FacebookApp((IFacebookSettings)s0);
    facebookApp.MaxRetries = 0;
    facebookApp.RetryDelay = 0;
    facebookApp.Session = (FacebookSession)null;
    o = this.Api01((FacebookAppBase)facebookApp, "\0", "\0", HttpMethod.Get);
}
[TestMethod]
[PexGeneratedBy(typeof(FacebookAppExtensionsTest))]
[PexRaisedException(typeof(JsonReaderException))]
public void Api01ThrowsJsonReaderException47()
{
    FacebookApp facebookApp;
    object o;
    FacebookSettings s0 = new FacebookSettings();
    s0.ApiKey = (string)null;
    s0.ApiSecret = (string)null;
    s0.AppId = (string)null;
    s0.CookieSupport = false;
    s0.BaseDomain = (string)null;
    s0.MaxRetries = 0;
    s0.RetryDelay = 0;
    facebookApp = new FacebookApp((IFacebookSettings)s0);
    facebookApp.MaxRetries = 0;
    facebookApp.RetryDelay = 0;
    facebookApp.Session = (FacebookSession)null;
    o = this.Api01((FacebookAppBase)facebookApp, "\0", "\0", HttpMethod.Delete);
}
[TestMethod]
[PexGeneratedBy(typeof(FacebookAppExtensionsTest))]
[PexRaisedException(typeof(JsonReaderException))]
public void Api01ThrowsJsonReaderException823()
{
    FacebookApp facebookApp;
    object o;
    FacebookSettings s0 = new FacebookSettings();
    s0.ApiKey = (string)null;
    s0.ApiSecret = "\0";
    s0.AppId = "\0";
    s0.CookieSupport = false;
    s0.BaseDomain = (string)null;
    s0.MaxRetries = 0;
    s0.RetryDelay = 0;
    facebookApp = new FacebookApp((IFacebookSettings)s0);
    facebookApp.MaxRetries = 0;
    facebookApp.RetryDelay = 0;
    facebookApp.Session = (FacebookSession)null;
    o = this.Api01((FacebookAppBase)facebookApp, "\0", "\0", HttpMethod.Get);
}
[TestMethod]
[PexGeneratedBy(typeof(FacebookAppExtensionsTest))]
[PexRaisedException(typeof(JsonReaderException))]
public void Api01ThrowsJsonReaderException591()
{
    FacebookApp facebookApp;
    object o;
    FacebookSettings s0 = new FacebookSettings();
    s0.ApiKey = (string)null;
    s0.ApiSecret = (string)null;
    s0.AppId = (string)null;
    s0.CookieSupport = false;
    s0.BaseDomain = (string)null;
    s0.MaxRetries = 0;
    s0.RetryDelay = 0;
    facebookApp = new FacebookApp((IFacebookSettings)s0);
    facebookApp.MaxRetries = 0;
    facebookApp.RetryDelay = 0;
    facebookApp.Session = (FacebookSession)null;
    o = this.Api01((FacebookAppBase)facebookApp, "\0", "/", HttpMethod.Get);
}
[TestMethod]
[PexGeneratedBy(typeof(FacebookAppExtensionsTest))]
[Ignore]
[PexDescription("the test state was: path bounds exceeded")]
public void Api01554()
{
    FacebookApp facebookApp;
    object o;
    FacebookSettings s0 = new FacebookSettings();
    s0.ApiKey = (string)null;
    s0.ApiSecret = (string)null;
    s0.AppId = (string)null;
    s0.CookieSupport = false;
    s0.BaseDomain = (string)null;
    s0.MaxRetries = 0;
    s0.RetryDelay = 0;
    facebookApp = new FacebookApp((IFacebookSettings)s0);
    facebookApp.MaxRetries = 0;
    facebookApp.RetryDelay = 0;
    facebookApp.Session = (FacebookSession)null;
    o = this.Api01((FacebookAppBase)facebookApp, "/", "/", HttpMethod.Get);
}
[TestMethod]
[PexGeneratedBy(typeof(FacebookAppExtensionsTest))]
[Ignore]
[PexDescription("the test state was: path bounds exceeded")]
public void Api0155401()
{
    FacebookApp facebookApp;
    object o;
    FacebookSettings s0 = new FacebookSettings();
    s0.ApiKey = (string)null;
    s0.ApiSecret = (string)null;
    s0.AppId = (string)null;
    s0.CookieSupport = false;
    s0.BaseDomain = (string)null;
    s0.MaxRetries = 0;
    s0.RetryDelay = 0;
    facebookApp = new FacebookApp((IFacebookSettings)s0);
    facebookApp.MaxRetries = 0;
    facebookApp.RetryDelay = 0;
    facebookApp.Session = (FacebookSession)null;
    o = this.Api01((FacebookAppBase)facebookApp, "/", "/", HttpMethod.Get);
}
[TestMethod]
[PexGeneratedBy(typeof(FacebookAppExtensionsTest))]
[PexRaisedException(typeof(InvalidOperationException))]
public void Api01ThrowsInvalidOperationException759()
{
    FacebookApp facebookApp;
    object o;
    FacebookSettings s0 = new FacebookSettings();
    s0.ApiKey = (string)null;
    s0.ApiSecret = (string)null;
    s0.AppId = (string)null;
    s0.CookieSupport = false;
    s0.BaseDomain = (string)null;
    s0.MaxRetries = 0;
    s0.RetryDelay = 0;
    facebookApp = new FacebookApp((IFacebookSettings)s0);
    facebookApp.MaxRetries = 0;
    facebookApp.RetryDelay = 0;
    facebookApp.Session = (FacebookSession)null;
    o = this.Api01((FacebookAppBase)facebookApp, "\0", "\0", (HttpMethod)3);
}
[TestMethod]
[PexGeneratedBy(typeof(FacebookAppExtensionsTest))]
[PexRaisedException(typeof(JsonReaderException))]
public void Api01ThrowsJsonReaderException514()
{
    FacebookApp facebookApp;
    object o;
    FacebookSettings s0 = new FacebookSettings();
    s0.ApiKey = (string)null;
    s0.ApiSecret = (string)null;
    s0.AppId = "\0";
    s0.CookieSupport = false;
    s0.BaseDomain = (string)null;
    s0.MaxRetries = 0;
    s0.RetryDelay = 0;
    facebookApp = new FacebookApp((IFacebookSettings)s0);
    facebookApp.MaxRetries = 0;
    facebookApp.RetryDelay = 0;
    facebookApp.Session = (FacebookSession)null;
    o = this.Api01((FacebookAppBase)facebookApp, "\0", "\0", HttpMethod.Post);
}
[TestMethod]
[PexGeneratedBy(typeof(FacebookAppExtensionsTest))]
[PexRaisedException(typeof(JsonReaderException))]
public void Api01ThrowsJsonReaderException707()
{
    FacebookApp facebookApp;
    object o;
    FacebookSettings s0 = new FacebookSettings();
    s0.ApiKey = (string)null;
    s0.ApiSecret = (string)null;
    s0.AppId = (string)null;
    s0.CookieSupport = false;
    s0.BaseDomain = (string)null;
    s0.MaxRetries = 0;
    s0.RetryDelay = 0;
    facebookApp = new FacebookApp((IFacebookSettings)s0);
    facebookApp.MaxRetries = 0;
    facebookApp.RetryDelay = 0;
    facebookApp.Session = (FacebookSession)null;
    o = this.Api01((FacebookAppBase)facebookApp, "/", "\0", HttpMethod.Get);
}
[TestMethod]
[PexGeneratedBy(typeof(FacebookAppExtensionsTest))]
[PexRaisedException(typeof(ArgumentOutOfRangeException))]
public void Api01ThrowsArgumentOutOfRangeException711()
{
    FacebookApp facebookApp;
    object o;
    FacebookSettings s0 = new FacebookSettings();
    s0.ApiKey = (string)null;
    s0.ApiSecret = (string)null;
    s0.AppId = (string)null;
    s0.CookieSupport = false;
    s0.BaseDomain = (string)null;
    s0.MaxRetries = 0;
    s0.RetryDelay = 0;
    facebookApp = new FacebookApp((IFacebookSettings)s0);
    facebookApp.MaxRetries = 0;
    facebookApp.RetryDelay = 0;
    facebookApp.Session = (FacebookSession)null;
    o = this.Api01((FacebookAppBase)facebookApp, "\0", "\0", (HttpMethod)3);
}
[TestMethod]
[PexGeneratedBy(typeof(FacebookAppExtensionsTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void Api01ThrowsArgumentNullException595()
{
    FacebookConfigurationSection facebookConfigurationSection;
    FacebookApp facebookApp;
    object o;
    facebookConfigurationSection = new FacebookConfigurationSection();
    ((ConfigurationElement)facebookConfigurationSection).LockItem = false;
    facebookApp = new FacebookApp((IFacebookSettings)facebookConfigurationSection);
    facebookApp.MaxRetries = 0;
    facebookApp.RetryDelay = 0;
    facebookApp.Session = (FacebookSession)null;
    o = this.Api01
            ((FacebookAppBase)facebookApp, (string)null, (string)null, HttpMethod.Get);
}
[TestMethod]
[PexGeneratedBy(typeof(FacebookAppExtensionsTest))]
[PexRaisedException(typeof(JsonReaderException))]
public void Api01ThrowsJsonReaderException640()
{
    FacebookSession facebookSession;
    FacebookApp facebookApp;
    object o;
    facebookSession = new FacebookSession();
    FacebookSettings s0 = new FacebookSettings();
    s0.ApiKey = (string)null;
    s0.ApiSecret = (string)null;
    s0.AppId = (string)null;
    s0.CookieSupport = false;
    s0.BaseDomain = (string)null;
    s0.MaxRetries = 0;
    s0.RetryDelay = 0;
    facebookApp = new FacebookApp((IFacebookSettings)s0);
    facebookApp.MaxRetries = 0;
    facebookApp.RetryDelay = 0;
    facebookApp.Session = facebookSession;
    o = this.Api01((FacebookAppBase)facebookApp, "\0", "\0", HttpMethod.Get);
}
[TestMethod]
[PexGeneratedBy(typeof(FacebookAppExtensionsTest))]
[Ignore]
[PexDescription("the test state was: path bounds exceeded")]
public void Api01595()
{
    FacebookConfigurationSection facebookConfigurationSection;
    FacebookApp facebookApp;
    object o;
    facebookConfigurationSection = new FacebookConfigurationSection();
    ((ConfigurationElement)facebookConfigurationSection).LockItem = false;
    facebookApp = new FacebookApp((IFacebookSettings)facebookConfigurationSection);
    facebookApp.MaxRetries = 0;
    facebookApp.RetryDelay = 0;
    facebookApp.Session = (FacebookSession)null;
    o = this.Api01((FacebookAppBase)facebookApp, "/", "/", HttpMethod.Get);
}
[TestMethod]
[PexGeneratedBy(typeof(FacebookAppExtensionsTest))]
[PexRaisedException(typeof(FacebookApiException))]
public void Api01ThrowsFacebookApiException425()
{
    FacebookApp facebookApp;
    object o;
    FacebookSettings s0 = new FacebookSettings();
    s0.ApiKey = (string)null;
    s0.ApiSecret = (string)null;
    s0.AppId = (string)null;
    s0.CookieSupport = false;
    s0.BaseDomain = (string)null;
    s0.MaxRetries = 0;
    s0.RetryDelay = 0;
    facebookApp = new FacebookApp((IFacebookSettings)s0);
    facebookApp.MaxRetries = 0;
    facebookApp.RetryDelay = 0;
    facebookApp.Session = (FacebookSession)null;
    o = this.Api01((FacebookAppBase)facebookApp, "\0", "\0", HttpMethod.Get);
}
[TestMethod]
[PexGeneratedBy(typeof(FacebookAppExtensionsTest))]
[PexRaisedException(typeof(FacebookApiException))]
public void Api01ThrowsFacebookApiException974()
{
    FacebookApp facebookApp;
    object o;
    FacebookSettings s0 = new FacebookSettings();
    s0.ApiKey = (string)null;
    s0.ApiSecret = (string)null;
    s0.AppId = (string)null;
    s0.CookieSupport = false;
    s0.BaseDomain = (string)null;
    s0.MaxRetries = 0;
    s0.RetryDelay = 0;
    facebookApp = new FacebookApp((IFacebookSettings)s0);
    facebookApp.MaxRetries = 0;
    facebookApp.RetryDelay = 0;
    facebookApp.Session = (FacebookSession)null;
    o = this.Api01((FacebookAppBase)facebookApp, "\0\0", "\0", HttpMethod.Get);
}
[TestMethod]
[PexGeneratedBy(typeof(FacebookAppExtensionsTest))]
[PexRaisedException(typeof(FacebookApiException))]
public void Api01ThrowsFacebookApiException12()
{
    FacebookApp facebookApp;
    object o;
    FacebookSettings s0 = new FacebookSettings();
    s0.ApiKey = (string)null;
    s0.ApiSecret = "\0";
    s0.AppId = (string)null;
    s0.CookieSupport = false;
    s0.BaseDomain = (string)null;
    s0.MaxRetries = 0;
    s0.RetryDelay = 0;
    facebookApp = new FacebookApp((IFacebookSettings)s0);
    facebookApp.MaxRetries = 0;
    facebookApp.RetryDelay = 0;
    facebookApp.Session = (FacebookSession)null;
    o = this.Api01((FacebookAppBase)facebookApp, "\0", "\0", HttpMethod.Get);
}
[TestMethod]
[PexGeneratedBy(typeof(FacebookAppExtensionsTest))]
[PexRaisedException(typeof(FacebookApiException))]
public void Api01ThrowsFacebookApiException706()
{
    FacebookApp facebookApp;
    object o;
    FacebookSettings s0 = new FacebookSettings();
    s0.ApiKey = (string)null;
    s0.ApiSecret = (string)null;
    s0.AppId = "\0";
    s0.CookieSupport = false;
    s0.BaseDomain = (string)null;
    s0.MaxRetries = 0;
    s0.RetryDelay = 0;
    facebookApp = new FacebookApp((IFacebookSettings)s0);
    facebookApp.MaxRetries = 0;
    facebookApp.RetryDelay = 0;
    facebookApp.Session = (FacebookSession)null;
    o = this.Api01((FacebookAppBase)facebookApp, "\0", "\0", HttpMethod.Get);
}
[TestMethod]
[PexGeneratedBy(typeof(FacebookAppExtensionsTest))]
[PexRaisedException(typeof(FacebookApiException))]
public void Api01ThrowsFacebookApiException745()
{
    FacebookApp facebookApp;
    object o;
    FacebookSettings s0 = new FacebookSettings();
    s0.ApiKey = (string)null;
    s0.ApiSecret = "\0";
    s0.AppId = "\0";
    s0.CookieSupport = false;
    s0.BaseDomain = (string)null;
    s0.MaxRetries = 0;
    s0.RetryDelay = 0;
    facebookApp = new FacebookApp((IFacebookSettings)s0);
    facebookApp.MaxRetries = 0;
    facebookApp.RetryDelay = 0;
    facebookApp.Session = (FacebookSession)null;
    o = this.Api01((FacebookAppBase)facebookApp, "\0", "\0", HttpMethod.Get);
}
[TestMethod]
[PexGeneratedBy(typeof(FacebookAppExtensionsTest))]
[PexRaisedException(typeof(FacebookApiException))]
public void Api01ThrowsFacebookApiException696()
{
    FacebookApp facebookApp;
    object o;
    FacebookSettings s0 = new FacebookSettings();
    s0.ApiKey = (string)null;
    s0.ApiSecret = (string)null;
    s0.AppId = (string)null;
    s0.CookieSupport = false;
    s0.BaseDomain = (string)null;
    s0.MaxRetries = 0;
    s0.RetryDelay = 0;
    facebookApp = new FacebookApp((IFacebookSettings)s0);
    facebookApp.MaxRetries = 0;
    facebookApp.RetryDelay = 0;
    facebookApp.Session = (FacebookSession)null;
    o = this.Api01((FacebookAppBase)facebookApp, "\0", "\0", HttpMethod.Post);
}
[TestMethod]
[PexGeneratedBy(typeof(FacebookAppExtensionsTest))]
[PexRaisedException(typeof(FacebookApiException))]
public void Api01ThrowsFacebookApiException362()
{
    FacebookApp facebookApp;
    object o;
    FacebookSettings s0 = new FacebookSettings();
    s0.ApiKey = (string)null;
    s0.ApiSecret = (string)null;
    s0.AppId = (string)null;
    s0.CookieSupport = false;
    s0.BaseDomain = (string)null;
    s0.MaxRetries = 0;
    s0.RetryDelay = 0;
    facebookApp = new FacebookApp((IFacebookSettings)s0);
    facebookApp.MaxRetries = 0;
    facebookApp.RetryDelay = 0;
    facebookApp.Session = (FacebookSession)null;
    o = this.Api01((FacebookAppBase)facebookApp, "\0", "\0", HttpMethod.Delete);
}
[TestMethod]
[PexGeneratedBy(typeof(FacebookAppExtensionsTest))]
[Ignore]
[PexDescription("the test state was: path bounds exceeded")]
public void Api01284()
{
    FacebookApp facebookApp;
    object o;
    FacebookSettings s0 = new FacebookSettings();
    s0.ApiKey = (string)null;
    s0.ApiSecret = (string)null;
    s0.AppId = "/";
    s0.CookieSupport = false;
    s0.BaseDomain = (string)null;
    s0.MaxRetries = 0;
    s0.RetryDelay = 0;
    facebookApp = new FacebookApp((IFacebookSettings)s0);
    facebookApp.MaxRetries = 0;
    facebookApp.RetryDelay = 0;
    facebookApp.Session = (FacebookSession)null;
    o = this.Api01((FacebookAppBase)facebookApp, "/", "/", HttpMethod.Get);
}
[TestMethod]
[PexGeneratedBy(typeof(FacebookAppExtensionsTest))]
[PexRaisedException(typeof(FacebookApiException))]
public void Api01ThrowsFacebookApiException85()
{
    FacebookApp facebookApp;
    object o;
    FacebookSettings s0 = new FacebookSettings();
    s0.ApiKey = (string)null;
    s0.ApiSecret = (string)null;
    s0.AppId = (string)null;
    s0.CookieSupport = false;
    s0.BaseDomain = (string)null;
    s0.MaxRetries = 0;
    s0.RetryDelay = 0;
    facebookApp = new FacebookApp((IFacebookSettings)s0);
    facebookApp.MaxRetries = 0;
    facebookApp.RetryDelay = 0;
    facebookApp.Session = (FacebookSession)null;
    o = this.Api01((FacebookAppBase)facebookApp, "/", "\0", HttpMethod.Get);
}
    }
}
