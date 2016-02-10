using System;
using UnityEngine;

namespace UnityStandardAssets.Effects
{
    public class WaterHoseParticles : MonoBehaviour
    {
        public static float lastSoundTime;
        public float force = 1;


        private ParticleCollisionEvent[] m_CollisionEvents = new ParticleCollisionEvent[16];
        private ParticleSystem m_ParticleSystem;


        private void Start()
        {
            m_ParticleSystem = GetComponent<ParticleSystem>();
        }


        private void OnParticleCollision(GameObject other)
        {
            int safeLength = m_ParticleSystem.GetSafeCollisionEventSize();

            if (m_CollisionEvents.Length < safeLength)
            {
                m_CollisionEvents = new ParticleCollisionEvent[safeLength];
            }

            int numCollisionEvents = m_ParticleSystem.GetCollisionEvents(other, m_CollisionEvents);
            int i = 0;

            while (i < numCollisionEvents)
            {
                if (Time.time > lastSoundTime + 0.2f)
                {
                    lastSoundTime = Time.time;
                }

                var col = m_CollisionEvents[i].collider;
<<<<<<< HEAD

                if (col.attachedRigidbody != null)
                {
                    Vector3 vel = m_CollisionEvents[i].velocity;
                    col.attachedRigidbody.AddForce(vel*force, ForceMode.Impulse);
=======
                var attachedRigidbody = col.GetComponent<Rigidbody>();
                if (attachedRigidbody != null)
                {
                    Vector3 vel = m_CollisionEvents[i].velocity;
                    attachedRigidbody.AddForce(vel*force, ForceMode.Impulse);
>>>>>>> parent of cb0a668... Refreshing Project...
                }

                other.BroadcastMessage("Extinguish", SendMessageOptions.DontRequireReceiver);

                i++;
            }
        }
    }
}
