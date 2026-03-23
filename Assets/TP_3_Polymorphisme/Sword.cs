using TP3_Polymorphisme;
using UnityEngine;

public class Sword : Weapon
{
    private void Start()
    {
        currentWeapon = "sword";
    }

    public void Attaquer()
    {
        // Logique d'attaque à l'épée
        Debug.Log("Swinging sword");
        // Animation, effets sonores, etc.

        // Détection des ennemis à proximité
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, 2f);
        foreach (var hitCollider in hitColliders)
        {
            Enemy enemy = hitCollider.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(25);
            }
        }
    }
}
