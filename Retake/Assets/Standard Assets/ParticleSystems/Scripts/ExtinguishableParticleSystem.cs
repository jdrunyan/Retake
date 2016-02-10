using System;
using UnityEngine;


namespace UnityStandardAssets.Effects
{
    public class ExtinguishableParticleSystem : MonoBehaviour
    {
        public float multiplier = 1;

        private ParticleSystem[] m_Systems;


        private void Start()
        {
            m_Systems = GetComponentsInChildren<ParticleSystem>();
        }


        public void Extinguish()
        {
            foreach (var system in m_Systems)
            {
<<<<<<< HEAD
                system.enableEmission = false;
=======
                var emission = system.emission;
                emission.enabled = false;
>>>>>>> parent of cb0a668... Refreshing Project...
            }
        }
    }
}
