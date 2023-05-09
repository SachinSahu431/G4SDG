 using UnityEngine;
 using UnityEngine.UI;
 using System;
 using System.Collections.Generic;
 using System.Collections;
 using TMPro;
public class ScoreHandler : MonoBehaviour
{
    [SerializeField]
    private ScoreSO score;          // score SO
    public TMP_Text scoreText;      // Text for current score
    
    // Update the score with every frame update
    void Update()
    {
        scoreText.text = score.curScore.ToString();
    }
}
