using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class PuzzleToggle : MonoBehaviour
{
    [SerializeField]
    private GameObject puzzle;      // puzzle panel

    // initially panel is disabled
    void Start()
    {
        puzzle.SetActive(false);
    }

    //function to toggle the puzzle panel
    public void Toggle()
    {
            if(puzzle.activeSelf)
                puzzle.SetActive(false);
            else
                puzzle.SetActive(true);
    }
}
