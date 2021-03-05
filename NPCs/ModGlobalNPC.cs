using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ReduceGuardianHealth.NPCs
{
    class ModGlobalNPC : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (npc.type == NPCID.DungeonGuardian)
            {
                npc.lifeMax = 999;
            }
        }
    }
}
