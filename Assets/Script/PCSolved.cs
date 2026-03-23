using UnityEngine;

namespace TP1_Encapsulation
{
    public class PlayerCharacter : MonoBehaviour
    {
        // Toutes les données sont publiques et peuvent être modifiées n'importe où

        [SerializeField]
        protected string playerName = "J1";

        [SerializeField]
        protected int health = 100;
        [SerializeField]
        protected int maxHealth = 200;

        [SerializeField]
        protected float moveSpeed = 3;

        float maxSpeed = 15;

        [SerializeField]
        protected bool isInvincible = false;

        [SerializeField]
        protected int gold = 0;


        void Update()
        {
            // Le personnage peut avoir une santé négative car rien ne l'empêche
            Mathf.Clamp(health, 0, maxHealth);
            // Le Clamp limite le minimum à 0 et maximum à 100
            if (health == 0)
            {
                Debug.Log("Player is dead");
            }

            // La vitesse peut être modifiée à n'importe quelle valeur
            Mathf.Clamp(moveSpeed, 0, maxSpeed);
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);


            Mathf.Clamp(gold, 0, -1);
        }
        
        public int getGold()
        {
            return gold;
        }

        public int setGold(int donations)
        {
            return gold + donations;
        }

        // Méthode nécessaire pour les autres TPs, mais mal implémentée

        public int getHealth()
        {
            return health;
        }

        public int setHealth(int variations)
        {
            return health + variations;
        }
    }
}