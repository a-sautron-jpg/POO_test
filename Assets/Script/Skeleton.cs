using UnityEngine;

namespace TP2_Heritage
{
    public class Skeleton : Enemi
    {
        void Start()
        {
            health = 80;
            damage = 15;
            speed = 3f;
            detectionRange = 12f;

            base.Start();
        }

        protected override void Update()
        {
            base.Update();

            if (Vector3.Distance(transform.position, player.position) - 7 > detectionRange)
            {
                player.position = transform.position;
                Die();
            }
        }

    }
}