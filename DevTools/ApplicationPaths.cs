using MediaBrowser.Common.Configuration;

namespace DevTools;

public class ApplicationPaths : IApplicationPaths
{
    public ReadOnlySpan<char> GetImageCachePath()
    {
        throw new NotImplementedException();
    }

    public ReadOnlySpan<char> GetCachePath()
    {
        throw new NotImplementedException();
    }

    public string ProgramDataPath { get; }
    public string ProgramSystemPath { get; }

    public string DataPath => "./";

    public string VirtualDataPath { get; }
    public string PluginsPath { get; }
    public string PluginConfigurationsPath => "./";
    public string TempUpdatePath { get; }
    public string LogDirectoryPath { get; }
    public string ConfigurationDirectoryPath { get; }
    public string SystemConfigurationFilePath { get; }
    public string CachePath { get; }
    public string TempDirectory { get; }
}