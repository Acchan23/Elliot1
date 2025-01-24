using TMPro;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public Inventory playerInventory;  // Referencia al inventario del jugador
    public TextMeshProUGUI inventoryText;  // Referencia al TextMesh Pro para mostrar los items

    void Update()
    {
        // Limpiamos el texto actual
        inventoryText.text = "Inventario:\n";

        // Agregamos cada item al texto
        foreach (var item in playerInventory.items)
        {
            inventoryText.text += item + "\n";
        }
    }
}

