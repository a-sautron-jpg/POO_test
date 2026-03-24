using UnityEngine;

public class Item_Potion : Item
{
    // Propriétés spécifiques aux potions
    public int healthRestored;
    public float duration;

    public void UseItem(Player player)
    {
        // Logique d'utilisation d'une potion
        player.RestoreHealth(healthRestored);
    }
}
