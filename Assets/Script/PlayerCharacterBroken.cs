using UnityEngine;

namespace TP1_Encapsulation
{
    public class PlayerCharacterBroken : MonoBehaviour
    {
        // Toutes les données sont publiques et peuvent être modifiées n'importe où
        public string playerName;
        public int health;
        public int maxHealth;
        public float moveSpeed;
        public int gold;
        public bool isInvincible;
        
        void Update()
        {
            // Le personnage peut avoir une santé négative car rien ne l'empêche
            if (health <= 0)
            {
                Debug.Log("Player is dead");
            }
            
            // La vitesse peut être modifiée à n'importe quelle valeur
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        
        public void GainGold(int amount)
        {
            gold += amount;
        }

        // Méthode nécessaire pour les autres TPs, mais mal implémentée
        public void TakeDamage(int amount)
        {
            health -= amount;
        }
    }
}