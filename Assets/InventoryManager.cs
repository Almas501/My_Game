using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Weapon[] slots = new Weapon[8];

    // Function to add a weapon to the inventory
    public bool AddWeapon(Weapon weapon)
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (slots[i] == null) // If slot is empty
            {
                slots[i] = weapon; // Add weapon to the slot
                return true; // Return true to indicate successful addition
            }
        }
        return false; // Return false if inventory is full
    }

    // Function to return an array of all filled slots
    public Weapon[] GetFilledSlots()
    {
        int filledCount = 0;
        foreach (Weapon weapon in slots)
        {
            if (weapon != null)
                filledCount++;
        }

        Weapon[] filledSlots = new Weapon[filledCount];
        int index = 0;
        foreach (Weapon weapon in slots)
        {
            if (weapon != null)
            {
                filledSlots[index] = weapon;
                index++;
            }
        }

        return filledSlots;
    }
}

// Example weapon class
[System.Serializable]
public class Weapon
{
    public string name;
    public int damage;

    public Weapon(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }
}
