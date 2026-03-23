using UnityEngine;
using UnityEngine.Rendering;

namespace TP2_Heritage
{
    public class Boss : Enemi
    {
        void Start()
        {
            health = 700;
            damage = 40;
            speed = 0.6f;
            detectionRange = 52f;

            base.Start();
        }


    }

}