using UnityEngine;
using TMPro;

public class UImanager : MonoBehaviour
{
    [Header("Text displays")]
    public TextMeshProUGUI roomNameText;

    public void UpdateRoomUI(Room currentRoom)
    {
        roomNameText.text = currentRoom.displayName;
    }
}
