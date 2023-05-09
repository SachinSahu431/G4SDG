 using UnityEngine;
 using UnityEngine.UI;
 using System.Collections;

public class ToggleImage : MonoBehaviour
{
    [SerializeField]
    private Image img;          // inventory icon
    [SerializeField]
    private int index;          // items index
    [SerializeField]
    private Button[] btns;      // button components
    
    // Toggle is the implementation of locking and unlocking mechanism of inventory mechanism
    public void Toggle()
    {
        // set all other button to non - interactable mode once a choice is locked
        if(img.isActiveAndEnabled)
        {
            img.enabled = false;
            btns[index].interactable = true;
            for(int i=0;i<btns.Length;i++)
            {
                if(i!=index)
                    btns[i].interactable = false;
            }
            CurrentImage.curImage = index.ToString();
        }
        else    // else free all choices
        {
            img.enabled = true;
            btns[index].interactable = true;
            for(int i=0;i<btns.Length;i++)
            {
                if(i!=index)
                    btns[i].interactable = true;
            }
        }
    } 
}
