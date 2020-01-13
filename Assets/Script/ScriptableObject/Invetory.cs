﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Invetory : ScriptableObject
{
    public Item currentItem;
    public List<Item> items = new List<Item>();
    public int numberOfKeys;
    public int coins;

    public void AddItem(Item itemToAdd)
    {
        if (itemToAdd.isKey)
        {
            numberOfKeys++;
        }
        else
        {
            if (!items.Contains(itemToAdd))
            {
                items.Add(itemToAdd);
            }
        }
    }
}
