using UnityEngine;
using System.Collections;

namespace com.dankstudios
{
    [BoltGlobalBehaviour]
    public class TokenCallbacks : Bolt.GlobalEventListener
    {
        public override void BoltStartBegin()
        {
            BoltNetwork.RegisterTokenClass<TestToken>();
        }
    }
}