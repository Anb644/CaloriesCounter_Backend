using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace CaloriesCounter.Localization
{
    public static class CaloriesCounterLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(CaloriesCounterConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(CaloriesCounterLocalizationConfigurer).GetAssembly(),
                        "CaloriesCounter.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
