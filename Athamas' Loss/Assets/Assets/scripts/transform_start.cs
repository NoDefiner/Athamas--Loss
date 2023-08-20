using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class transform_start : MonoBehaviour, IPointerClickHandler
{
    public string transferMapName;


    public void OnPointerClick(PointerEventData eventData)
    {
        SceneManager.LoadScene(transferMapName);
    }
}
