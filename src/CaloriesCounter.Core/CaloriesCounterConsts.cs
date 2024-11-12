using CaloriesCounter.Debugging;

namespace CaloriesCounter
{
    public class CaloriesCounterConsts
    {
        public const string LocalizationSourceName = "CaloriesCounter";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "ffe67cf8282143b19819cb78c746723b";
    }
}
