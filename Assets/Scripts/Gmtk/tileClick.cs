using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class tileClick : MonoBehaviour, IPointerEnterHandler
{
    Image tileImage;

    private void Start()
    {
        tileImage = GetComponent<Image>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        tileImage.color = Color.blue;
    }


}
