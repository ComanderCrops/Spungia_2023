using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    public Room[] rooms;

    public void SwitchRoom(string roomName){
        foreach(Room room in rooms){
            if(room.name != roomName){
                room.gameObject.SetActive(false);
            }else{
                room.gameObject.SetActive(true);
            }
        }
    }
}
