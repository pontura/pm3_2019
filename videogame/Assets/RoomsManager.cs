using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomsManager : MonoBehaviour
{
    public Room room1;
    public Room room2;

    //va a dibujar un room en relacion a lo que le pida levelsManager:
    public void AddRoom(LevelData levelData)
    {
        Room room;
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
    }
}
