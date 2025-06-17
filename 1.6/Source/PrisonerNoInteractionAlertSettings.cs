using UnityEngine;
using Verse;

namespace PrisonerNoInteractionAlert
{
    public class PrisonerNoInteractionAlertSettings : ModSettings
    {
        public static bool IgnoreUnwaveringPrisoners = true;

        public static void DoSettingsWindowContents(Rect inRect)
        {
            Listing_Standard listingStandard = new Listing_Standard();
            listingStandard.Begin(inRect);

            listingStandard.CheckboxLabeled("PrisonerNoInteractionAlert_IgnoreUnwaveringPrisoners".Translate(), ref IgnoreUnwaveringPrisoners);

            listingStandard.End();
        }

        public override void ExposeData()
        {
            Scribe_Values.Look(ref IgnoreUnwaveringPrisoners, "IgnoreUnwaveringPrisoners", true);
        }
    }
}
