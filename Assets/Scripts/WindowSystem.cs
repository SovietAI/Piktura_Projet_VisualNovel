 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;
using UnityEngine.Serialization;

public class WindowSystem : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    private Vector3 _initialPosition; // Position initiale de la boite    
    void Start()
    {
        //Guh
    }

    public void OnDrag(PointerEventData eventData) // Fonction de Drag
    {
        transform.localPosition = new Vector3(transform.localPosition.x + eventData.delta.x, transform.localPosition.y + + eventData.delta.y);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        _initialPosition = transform.localPosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //Snapback si bounds le l'objet en dehors des bounds de l'ecran
    }
}
