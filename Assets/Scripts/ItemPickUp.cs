using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public string itemName; // El nombre del objeto

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Con que objeto choque?
        {
            other.GetComponent<Inventory>().AddItem(itemName); // Añade el objeto al inventario
            Destroy(gameObject); // Destruye el objeto del mundo
        }
    }
}
