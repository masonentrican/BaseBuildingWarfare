using UnityEngine;
using System.Collections;

namespace com.dankstudios
{
    public static class ExtensionMethods
    {
        public static Player GetPlayer(this BoltConnection connection)
        {
            if (connection == null)
            {
                return Player.serverPlayer;
            }

            return (Player)connection.UserData;
        }
    }
}
