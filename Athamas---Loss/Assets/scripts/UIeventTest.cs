using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class UIeventTest : MonoBehaviour, IPointerClickHandler
    
{
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Click");
    }


    
}
