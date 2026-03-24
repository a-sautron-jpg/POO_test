using System.Collections.Generic;

public class Inventory
{
    public int itemCount = 0;
    public List<Item> items;
    
    public void AddItem(Item item)
    {
        items.Add(item);
    }
    
    public void RemoveItem(int index)
    {
        items.RemoveAt(index);
    }
    
    public float GetTotalWeight()
    {
        float totalWeight = 0;
        for (int i = 0; i < itemCount; i++)
        {
            totalWeight += items[i].weight;
        }
        return totalWeight;
    }
}