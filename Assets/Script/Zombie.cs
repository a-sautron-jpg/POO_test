using UnityEngine;

namespace TP2_Heritage
{
    public class Zombie : Enemi
    {
        public GameObject Self;
        void Start()
        {
            health = 100;
            damage = 10;
            speed = 2f;
            detectionRange = 10f;

            base.Start();
        }

        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                Instantiate(Self, new Vector3(transform.position.x, transform.position.y + 10, transform.position.z), Quaternion.identity);
            }
        }
    }
}