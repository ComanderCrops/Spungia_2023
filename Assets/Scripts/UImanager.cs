using UnityEngine;
using TMPro;

public class UImanager : MonoBehaviour
{
    [Header("Text displays")]
    public TextMeshProUGUI roomNameText;
    public TextMeshProUGUI tooltipText;

    Transform tooltipParent;

    void Awake()
    {
        tooltipParent = tooltipText.transform.parent;
        tooltipParent.gameObject.SetActive(false);
    }

    public void UpdateRoomUI(Room currentRoom)
    {
        roomNameText.text = currentRoom.displayName;
    }

    public void UpdateTooltip(string tooltip, Vector3 position)
    {
        tooltipText.text = tooltip;
        //tooltipParent.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition); //this breaks tooltips :(
        tooltipParent.transform.position = new Vector3(position.x, position.y + 2, 0);
        tooltipParent.gameObject.SetActive(true);
    }

    public void HideTooltip()
    {
        if (tooltipParent != null)
        {
            tooltipParent.gameObject.SetActive(false);
        }
    }
}
