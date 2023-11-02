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
        GetComponent<SpriteRenderer>().material.SetFloat("_OutlineWidth", 4);
        Debug.Log("Cursor entered " + gameObject.name);
    }

    public virtual void OnPointerExit(PointerEventData pointerEventData)
    {
        GetComponent<SpriteRenderer>().material.SetFloat("_OutlineWidth", 0);
        Debug.Log("Cursor exited " + gameObject.name);
    }
}
