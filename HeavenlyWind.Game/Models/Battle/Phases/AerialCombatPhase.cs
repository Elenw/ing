﻿using Sakuno.KanColle.Amatsukaze.Game.Models.Raw.Battle;
using System;
using System.Linq;

namespace Sakuno.KanColle.Amatsukaze.Game.Models.Battle.Phases
{
    class AerialCombatPhase : BattlePhase<RawAerialCombatPhase>
    {
        public PhaseRound Round { get; }

        internal AerialCombatPhase(BattleStage rpStage, RawAerialCombatPhase rpRawData, PhaseRound rpRound = PhaseRound.First) : base(rpStage, rpRawData)
        {
            Round = rpRound;
        }

        internal protected override void Process()
        {
            var rInfo = Stage.Owner.AerialCombat;

            ProcessStage1(rInfo);
            ProcessStage2(rInfo);
            ProcessStage3();
        }

        void ProcessStage1(AerialCombat rpInfo)
        {
            var rStage1 = RawData.Stage1;
            if (rStage1 != null)
            {
                rpInfo.Result = rStage1.Result;

                if (Round == PhaseRound.First)
                    rpInfo.Stage1 = new AerialCombat.Stage()
                    {
                        FriendPlaneCount = rStage1.FriendPlaneCount,
                        FriendPlaneRemaningCount = rStage1.FriendPlaneCount - rStage1.FriendPlaneLostCount,

                        EnemyPlaneCount = rStage1.EnemyPlaneCount,
                        EnemyPlaneRemaningCount = rStage1.EnemyPlaneCount - rStage1.EnemyPlaneLostCount,
                    };
                else
                {
                    rpInfo.Stage1.FriendPlaneRemaningCount -= rStage1.FriendPlaneLostCount;
                    rpInfo.Stage1.EnemyPlaneRemaningCount -= rStage1.EnemyPlaneLostCount;
                }
            }
        }

        void ProcessStage2(AerialCombat rpInfo)
        {
            var rStage2 = RawData.Stage2;
            if (rStage2 != null)
            {
                if (Round == PhaseRound.First)
                    rpInfo.Stage2 = new AerialCombat.Stage()
                    {
                        FriendPlaneCount = rStage2.FriendPlaneCount,
                        FriendPlaneRemaningCount = rStage2.FriendPlaneCount - rStage2.FriendPlaneLostCount,

                        EnemyPlaneCount = rStage2.EnemyPlaneCount,
                        EnemyPlaneRemaningCount = rStage2.EnemyPlaneCount - rStage2.EnemyPlaneLostCount,
                    };
                else
                {
                    rpInfo.Stage2.FriendPlaneRemaningCount -= rStage2.FriendPlaneLostCount;
                    rpInfo.Stage2.EnemyPlaneRemaningCount -= rStage2.EnemyPlaneLostCount;
                }
            }
        }

        void ProcessStage3()
        {
            var rStage3 = RawData.Stage3;
            if (rStage3 == null)
                return;

            var rParticipants = Stage.FriendAndEnemy;

            var rEnemyDamages = rStage3.EnemyDamage.Skip(1);
            var rDamages = Enumerable.Concat(rStage3.FriendDamage.Skip(1), rEnemyDamages).ToArray();
            if (RawData.Stage3CombinedFleet != null)
                rDamages = Enumerable.Concat(rDamages, RawData.Stage3CombinedFleet.FriendDamage.Skip(1)).ToArray();

            if (rDamages.All(r => r == 0))
                return;

            for (var i = 0; i < rDamages.Length; i++)
            {
                var rParticipant = rParticipants[i];
                if (rParticipant != null)
                    rParticipant.Current -= rDamages[i];
            }
        }
    }
}
