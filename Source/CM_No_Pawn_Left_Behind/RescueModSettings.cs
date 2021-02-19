using RimWorld;
using UnityEngine;
using Verse;

namespace CM_No_Pawn_Left_Behind
{
    public class RescueModSettings : ModSettings
    {
        public bool logPriorities = false;

        public override void ExposeData()
        {
            base.ExposeData();

            Scribe_Values.Look(ref logPriorities, "logPriorities", false);
        }

        public void DoSettingsWindowContents(Rect inRect)
        {
            Listing_Standard listing_Standard = new Listing_Standard();
            listing_Standard.ColumnWidth = (inRect.width - 34f) / 2f;

            listing_Standard.Begin(inRect);

            listing_Standard.CheckboxLabeled("CM_No_Pawn_Left_Behind_Settings_Log_Priorities_Label".Translate(), ref logPriorities);

            listing_Standard.End();
        }

        public void UpdateSettings()
        {

        }
    }
}
