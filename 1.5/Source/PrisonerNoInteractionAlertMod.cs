using UnityEngine;
using Verse;

namespace PrisonerNoInteractionAlert
{
    public class PrisonerNoInteractionAlertMod : Mod
    {
        public const string PACKAGE_ID = "prisonernointeractionalert.1trickPwnyta";
        public const string PACKAGE_NAME = "Prisoner No Interaction Alert";

        public static PrisonerNoInteractionAlertSettings Settings;

        public PrisonerNoInteractionAlertMod(ModContentPack content) : base(content)
        {
            Settings = GetSettings<PrisonerNoInteractionAlertSettings>();

            Log.Message($"[{PACKAGE_NAME}] Loaded.");
        }

        public override string SettingsCategory() => PACKAGE_NAME;

        public override void DoSettingsWindowContents(Rect inRect)
        {
            base.DoSettingsWindowContents(inRect);
            PrisonerNoInteractionAlertSettings.DoSettingsWindowContents(inRect);
        }
    }
}
