using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JudgeSolution : MonoBehaviour
{
    public static int itemCounter;                        // current counter of correctly mapped items
    [SerializeField]
    private int totalItems;                               // total items
    [SerializeField]
    private Canvas cDialog;                               // correct answer dialog canvas
    [SerializeField]  
    private Canvas wDialog;                               // wrong answer dialog canvas
    [SerializeField] 
    private ScoreSO score;                                // score SO

    void Start()
    {
        itemCounter = 0;
    }

    // Checks if the solution is correct or not
    public void Check()
    {
        bool isSolutionCorrect = (itemCounter == totalItems);   // check if all the items are correctly mapped or not
        
        // enable and disable the respective dialog canvas based on isSolutionCorrect
        if(isSolutionCorrect)
        {
            wDialog.enabled = false;
            cDialog.enabled = true;
            score.curScore += 10000;
        }
        else
        {
            cDialog.enabled = false;
            wDialog.enabled = true;
        }
    }
}
