using UnityEngine;
using System.Collections;

namespace StateMachineSample
{
    public class AutoDestroyer : MonoBehaviour
    {
        public float delay = 2f;

        void Start()
        {
            Destroy(gameObject, delay);
        }
    }
}
