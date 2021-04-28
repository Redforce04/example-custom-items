using System;
using Exiled.API.Features;
using Exiled.API.Extensions;

namespace testinggrounds
{
    public class api
    {
        public static Dictionary<string, Player> imposters = new Dictionary<string, Player>();
        public static void SetImposter(Player ply)
        {
            ply.SetRole(RoleType.ChaosInsurgency)
            foreach (var target in Player.List.Where(x => x != player))
            {   
                if(!imposters.Keys.Contains(target.UserId))
                    SendFakeSyncVar(target, player.ReferenceHub.networkIdentity, typeof(CharacterClassManager), nameof(CharacterClassManager.NetworkCurClass), (sbyte)RoleType.ClassD);
            }
            foreach (Player imposter in api.imposters.values)
            {
                SendFakeSyncVar(ply, imposter.ReferenceHub.networkIdentity, typeof(CharacterClassManager), nameof(CharacterClassManager.NetworkCurClass), (sbyte)RoleType.ChaosInsurgency);
                //SendFakeSyncVar(imposter, ply.ReferenceHub.networkIdentity, typeof(CharacterClassManager), nameof(CharacterClassManager.NetworkCurClass), (sbyte)RoleType.ChaosInsurgency);            
            }
            imposters.TryAdd(Player.UserId, ply);
        }
    }
}
