using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class CurrentImage : MonoBehaviour
{
    public static string curImage;          // current image name
    [SerializeField]
    private GameObject curObject;           // current gameobject
    [SerializeField]
    private GameObject inventoryObject;     // inventory object to activate
    [SerializeField]
    private GameObject targetObject;        // target object to activate
    [SerializeField]
    private ScoreSO score;                  // Score SO
    [SerializeField]
    private bool flag;                      // flag to check if target object exists
    public void Check()
    {
        if(curObject.name == curImage)          // if the image is correctly mapped
        {
            inventoryObject.SetActive(false);
            curObject.SetActive(false);
            if(flag)
                targetObject.SetActive(true);
            score.curScore+=500;
        }
        else                                    // if the image is incorrectly mapped
        {
            if(score.curScore >= 50)
                score.curScore-=50;
            else
                score.curScore=0;
        }
    }   
}
