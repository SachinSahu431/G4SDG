/**
 * Creating an inventory Scriptable object 
 * Scriptable objects are preserved across scenes
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class InventorySO : ScriptableObject
{
    public int index = 0;
    public string[] obj = new string[30];
}
