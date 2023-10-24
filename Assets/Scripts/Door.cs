using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Door : MonoBehaviour, IPointerClickHandler
{
    public UnityEvent doorOpenEvent;

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        doorOpenEvent.Invoke();
    }

    /*void OnPointerEnter(PointerEventData pointerEventData)
    {
        //doorOpenEvent = null;
    }

    void OnPointerExit(PointerEventData pointerEventData)
    {
        //doorOpenEvent = null;
    }*/
}
