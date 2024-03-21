using RimWorld;
using System.Collections.Generic;
using Verse;

namespace PrisonerNoInteractionAlert
{
    public class Alert_PrisonerNoInteraction : Alert
    {
        private List<Pawn> GetCulprits()
        {
            List<Pawn> culprits = new List<Pawn>();
            PawnsFinder.AllMaps_PrisonersOfColonySpawned.ForEach(pawn => {
                if (pawn.GetExtraHostFaction() == null && pawn.guest.IsInteractionEnabled(PrisonerInteractionModeDefOf.MaintainOnly) && pawn.guest.IsInteractionDisabled(PrisonerInteractionModeDefOf.HemogenFarm)) culprits.Add(pawn);
                // pawn.guest.interactionMode
            });
            return culprits;
        }

        public Alert_PrisonerNoInteraction()
        {
            this.defaultLabel = "PrisonerNoInteraction".Translate();
            this.defaultExplanation = "PrisonerNoInteractionDesc".Translate();
            this.defaultPriority = AlertPriority.High;
        }

        public override AlertReport GetReport()
        {
            return AlertReport.CulpritsAre(GetCulprits());
        }
    }
}
