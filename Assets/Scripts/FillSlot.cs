using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class FillSlot : MonoBehaviour
{
    [SerializeField] 
    private GameObject icon;

    // disable icon in the beginning
    void Start()
    {
        icon.SetActive(false);
    }

    // function on trigger event
    private void OnTriggerEnter2D(Collider2D player)
    {
        icon.SetActive(true);
    }
}
