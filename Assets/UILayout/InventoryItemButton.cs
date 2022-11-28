using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItemButton : MonoBehaviour
{
    private Text buttonText;
    private string[] itemTypes = { "Armor", "Weapon", "Spell" };

    void Awake()
    {
        index = Random.range(0,3);
        buttonText = GetComponentInChildren<Text>();
        buttonText.text = itemTypes[index];
    }

}
