using myATM.Debugging;

namespace myATM
{
    public class myATMConsts
    {
        public const string LocalizationSourceName = "myATM";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "90d2986695fb4528bef66fedabaee645";
    }
}
