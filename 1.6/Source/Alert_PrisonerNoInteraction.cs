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
            PawnsFinder.AllMaps_PrisonersOfColonySpawned.ForEach(pawn => 
            {
                if (pawn.guest != null && !pawn.guest.Released && pawn.GetExtraHostFaction() == null)
                {
                    if (pawn.guest.IsInteractionEnabled(PrisonerInteractionModeDefOf.MaintainOnly) && pawn.guest.IsInteractionDisabled(PrisonerInteractionModeDefOf.HemogenFarm) && pawn.guest.IsInteractionDisabled(PrisonerInteractionModeDefOf.Bloodfeed))
                    {
                        if (!PrisonerNoInteractionAlertSettings.IgnoreUnwaveringPrisoners || pawn.guest.Recruitable)
                        {
                            if (!pawn.IsWildMan() || pawn.Map.designationManager.DesignationOn(pawn, DesignationDefOf.Tame) == null)
                            {
                                culprits.Add(pawn);
                            }
                        }
                    }
                }
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
