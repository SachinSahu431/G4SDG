using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlots : MonoBehaviour
{
    [SerializeField]
    private GameObject[] InventoryItems;            // set of inventory items
    public static int count;                        // total count of inventory items
    [SerializeField]
    private InventorySO RemainingInventoryItems;    // inventory SO object

    // Start is called before the first frame update
    public void Start()
    {
        count = 0;
    }
    
    // fill the remaining inventory items in the SO
    public void SetInventory()
    {
        RemainingInventoryItems.index = 0;
        for(int i=0;i<InventoryItems.Length;i++)
        {
            if(InventoryItems[i].activeSelf)
            {
                RemainingInventoryItems.obj[RemainingInventoryItems.index] = InventoryItems[i].name;
                RemainingInventoryItems.index++;
            }
        }
    }
}
