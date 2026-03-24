using UnityEngine;

public class Item_Weapon : Item
{
    // Propriétés spécifiques aux armes
    public int damage;
    public float range;

    public void UseItem(Player player)
    {
        // Logique d'utilisation d'une arme
        player.Attack(damage);
    }
}
