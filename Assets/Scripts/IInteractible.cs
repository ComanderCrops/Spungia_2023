using UnityEngine;
using UnityEngine.EventSystems;

public class IInteractible : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    public virtual void OnPointerClick(PointerEventData pointerEventData)
    {
        Debug.Log("Cursor clicked on " + gameObject.name);
    }

    public virtual void OnPointerEnter(PointerEventData pointerEventData)
    {
        Debug.Log("Cursor entered " + gameObject.name);
    }

    public virtual void OnPointerExit(PointerEventData pointerEventData)
    {
        Debug.Log("Cursor exited " + gameObject.name);
    }
}
