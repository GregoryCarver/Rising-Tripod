using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Inventory
{
    public static Dictionary<string, int> inventoryStorage = new Dictionary<string, int>();

	public static void AddItem(string item)
    {
        if(inventoryStorage.ContainsKey(item))
        {
            inventoryStorage[item]++;
        }
        else
        {
            inventoryStorage.Add(item, 1);
        }
    }

    public static void RemoveItem(string item)
    {
        if(inventoryStorage[item] == 1)
        {
            inventoryStorage.Remove(item);
        }
        else
        {
            inventoryStorage[item]--;
        }
    }

    public static bool CheckIfHaveItem(string item)
    {
        int value;
        if (inventoryStorage.ContainsKey(item))
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }

    public static int CheckItemAmount(string item)
    {
        return inventoryStorage[item];
    }
}
