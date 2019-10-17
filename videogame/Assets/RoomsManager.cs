using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomsManager : MonoBehaviour
{
    public Room room1;
    public Room room2;
    private Room room;

    public void RemoveRoom()
    {
        Destroy(room.gameObject);
    }
    public void AddRoom(LevelData levelData)
    {
        switch (levelData.roomID)
        {
            case 1:
                room = Instantiate(room1);
                break;
            default:
                room = Instantiate(room2);
                break;
        }
        room.Init(levelData.roomdata);
        room.transform.SetParent(transform);
    }
}
