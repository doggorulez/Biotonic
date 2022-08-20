using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace Biotonic.NPCs
{
    [AutoloadBossHead]
    public class Masquether : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Masquether");
            Main.npcFrameCount[npc.type] = 4;
        }
        public override void SetDefaults()
        {
            npc.scale = 3;
            npc.aiStyle = 17;
            npc.lifeMax = 5000;
            npc.damage = 40;
            npc.defense = 15;
            npc.width = 100;
            npc.height = 97;
            animationType = 5;
            npc.knockBackResist = 0f;
            npc.HitSound = SoundID.NPCHit18;
            npc.DeathSound = SoundID.NPCDeath18;
            npc.boss = true;
            npc.lavaImmune = true;
            npc.noGravity = true;
            npc.noTileCollide = true;
            bossBag = mod.ItemType("MasquetherLootBag");
        }
        public override void NPCLoot()
        {
            npc.DropBossBags();
        }
    }
}
