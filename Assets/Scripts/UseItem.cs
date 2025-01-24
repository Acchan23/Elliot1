using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItem : MonoBehaviour
{
    public Inventory playerInventory;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) // Cuando el jugador presiona "E"
        {
            if (playerInventory.items.Contains("Bottle Of Water")) // Si tiene una botella
            {
                playerInventory.items.Remove("Bottle Of Water"); // La usa y la elimina
                Debug.Log("Botella de agua usada");
            }
        }
    }
}
