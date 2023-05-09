using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillInventory : MonoBehaviour
{
    [SerializeField]
    private GameObject[] InventoryItems;            // set of inventory items
    [SerializeField]                                    
    private InventorySO RemainingInventoryItems;    // the set of items that are remaining after completion of level
                                                       
    // Awake is called when the script instance is being loaded
    void Awake()
    {
        // Setting up the left over inventory items in the RemainingInventoryItems scriptable object
        for(int i=0;i<InventoryItems.Length;i++)
        {
            InventoryItems[i].SetActive(false); // disabling all other items
            for(int j=0;j<RemainingInventoryItems.index;j++)
            {
                if(InventoryItems[i].name == RemainingInventoryItems.obj[j]) // Checking by object name
                {
                    InventoryItems[i].SetActive(true);
                }
            }
        }      
    }
}
