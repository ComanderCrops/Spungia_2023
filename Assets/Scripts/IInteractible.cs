using UnityEngine;
using UnityEngine.EventSystems;

public class IInteractible : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        Debug.Log("Cursor clicked on " + gameObject.name + " GameObject");
    }

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        Debug.Log("Cursor Entering " + gameObject.name + " GameObject");
    }

    public void OnPointerExit(PointerEventData pointerEventData)
    {
        Debug.Log("Cursor Exiting " + gameObject.name + " GameObject");
    }
}
