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

        SwitchRoom(rooms[0]);
    }

    public void SwitchRoom(Room targetRoom)
    {
        foreach (Room room in rooms)
        {
            if (room == targetRoom)
            {
                currentRoom = room;
                currentRoom.gameObject.SetActive(true);
                uiManager.UpdateRoomUI(currentRoom);

                if (currentRoom.useCustomPlayerSpawnpoint)
                {
                    player.transform.position = currentRoom.customPlayerSpawnpoint;
                }
                else
                {
                    player.transform.position = new Vector3(-player.transform.position.x, -player.transform.position.y, 0);
                }
            }
            else
            {
                room.gameObject.SetActive(false);
            }
        }
    }
}
