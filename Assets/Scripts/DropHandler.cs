using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropHandler : MonoBehaviour,IDropHandler
{
    [SerializeField] 
    private GameObject[] binItems;
    [SerializeField] 
    private GameObject[] inventoryItems;
    [SerializeField]
    private ScoreSO score;

    // Handling the object on drop
    public void OnDrop(PointerEventData eventData)
    {
        if(eventData.pointerDrag != null)
        {
            // anchoring the object to placeholder position
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            GameObject obj = eventData.pointerDrag.gameObject;

            // checking if the object is corretly mapped
            if(Check(obj))
            {
                JudgeSolution.itemCounter++;
                obj.SetActive(false);
            }
        }
    }

    // function to check if the object is correctly mapped
    private bool Check(GameObject item)
    {
        for(int i=0;i<binItems.Length;i++)
        {
            Debug.Log(binItems[i].name);
            if(binItems[i].name.Equals(item.name))
            {
                inventoryItems[i].SetActive(false);
                score.curScore+=100;
                return true;
            }
        }

        // distribute score
        if(score.curScore >= 20)
        {
            score.curScore -=20;
        }
        else{
            score.curScore = 0;
        }

        return false;
    }
}
