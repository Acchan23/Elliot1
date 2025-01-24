using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<string> items = new(); // Objetos en el inventario

    public void AddItem(string item)
    {
        items.Add(item); // Añadir un objeto al inventario
        Debug.Log(item + " añadido al inventario.");
    }
}
