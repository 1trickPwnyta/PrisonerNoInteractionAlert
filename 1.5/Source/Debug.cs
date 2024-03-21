namespace PrisonerNoInteractionAlert
{
    public static class Debug
    {
        public static void Log(string message)
        {
#if DEBUG
            Verse.Log.Message($"[{PrisonerNoInteractionAlertMod.PACKAGE_NAME}] {message}");
#endif
        }
    }
}
