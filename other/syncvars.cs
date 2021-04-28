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
            // Show the new imposter who all of the other imposters are
            foreach (Player imposter in api.imposters.values)
            {
                SendFakeSyncVar(ply, imposter.ReferenceHub.networkIdentity, typeof(CharacterClassManager), nameof(CharacterClassManager.NetworkCurClass), (sbyte)RoleType.ChaosInsurgency);
                SendFakeSyncVar(imposter, ply.ReferenceHub.networkIdentity, typeof(CharacterClassManager), nameof(CharacterClassManager.NetworkCurClass), (sbyte)RoleType.ChaosInsurgency);            
            }
    }
}
