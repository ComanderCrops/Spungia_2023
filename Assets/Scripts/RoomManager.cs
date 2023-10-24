using UnityEngine;

public class RoomManager : MonoBehaviour
{
    public Room[] rooms;

    public Room currentRoom;

    UImanager uiManager;

    GameObject player;

    void Start()
    {
        uiManager = GetComponent<UImanager>();
        player = GameObject.FindGameObjectWithTag("Player");

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

                player.transform.position = currentRoom.transform.GetChild(0).position;
            }
            else
            {
                room.gameObject.SetActive(false);
            }
        }
    }
}
