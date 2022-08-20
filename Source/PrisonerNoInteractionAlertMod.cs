using Verse;

namespace PrisonerNoInteractionAlert
{
    public class PrisonerNoInteractionAlertMod : Mod
    {
        public const string PACKAGE_ID = "prisonernointeractionalert.1trickPwnyta";
        public const string PACKAGE_NAME = "Prisoner No Interaction Alert";

        public PrisonerNoInteractionAlertMod(ModContentPack content) : base(content)
        {
            Log.Message($"[{PACKAGE_NAME}] Loaded.");
        }
    }
}
