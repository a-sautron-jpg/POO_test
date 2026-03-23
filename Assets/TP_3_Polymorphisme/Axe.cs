using TP3_Polymorphisme;
using UnityEngine;

public class Axe : Weapon
{
    private void Start()
    {
        currentWeapon = "axe";
    }

    public void Attaquer()
    {
        // Logique d'attaque à la hache
        Debug.Log("Be a danger to society");

        // Animation, effets sonores, etc.

        // Détection des ennemis à proximité
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, 3f);
        foreach (var hitCollider in hitColliders)
        {
            Enemy enemy = hitCollider.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(5);

                PlayerCharacter player = GetComponent<PlayerCharacter>();
                if (player != null && player.SpendMana(5f))
                {
                    enemy.transform.position += 3* (enemy.transform.position - transform.position);
                }
            }
        }
    }
}
