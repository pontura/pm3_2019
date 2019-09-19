using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsManager : MonoBehaviour
{
    public RoomsManager roomsManager;
    
    public void Init()
    {
        LevelData levelData = new LevelData();
        levelData.roomID = 1;
        levelData.roomdata = new RoomData();
        levelData.roomdata.door1 = true;
        levelData.roomdata.door2 = false;
        levelData.roomdata.door3 = true;
        levelData.roomdata.door4 = false;
        roomsManager.AddRoom(levelData);
    }

}
