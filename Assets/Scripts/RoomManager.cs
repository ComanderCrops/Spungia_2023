using UnityEngine;

public class RoomManager : MonoBehaviour
{
    public Room[] rooms;

    public Room currentRoom;

    UImanager uiManager;

    void Start()
    {
        uiManager = GetComponent<UImanager>();

        SwitchRoom("room_1");
    }

    public void SwitchRoom(string roomName)
    {
        foreach (Room room in rooms)
        {
            if (room.name == roomName)
            {
                currentRoom = room;
                currentRoom.gameObject.SetActive(true);
                uiManager.UpdateRoomUI(currentRoom);
            }
            else
            {
                room.gameObject.SetActive(false);
            }
        }
    }
}
