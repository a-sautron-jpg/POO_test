public class Player : ITaker_item
{
    public string name;
    public int health;
    public int maxHealth;
    
    // L'inventaire est directement intégré dans la classe Player
    public Inventory inventory = new Inventory();
    
    // Des références directes aux objets équipés
    public Item equippedWeapon;
    public Armor_Helmet equippedHelmet;
    public Armor_Chest equippedChest;
    public Armor_Boots equippedBoots;
    
    public void Attack(int damage)
    {
        // Logique d'attaque avec l'arme équipée
        System.Console.WriteLine($"{name} attaque pour {damage} points de dégâts!");
    }

    public void EquipHelmet(Armor_Helmet item)
    {
        equippedHelmet = item;
    }
    public void EquipChest(Armor_Chest item)
    {
        equippedChest = item;
    }

    public void EquipBoots(Armor_Boots item)
    {
        equippedBoots = item;
    }

    public void RestoreHealth(int amount)
    {
        health = System.Math.Min(health + amount, maxHealth);
        System.Console.WriteLine($"{name} restaure {amount} points de vie!");
    }
}