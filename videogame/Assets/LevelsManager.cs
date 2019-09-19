using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsManager : MonoBehaviour
{
    public RoomsManager roomsManager;
    
    private void Start()
    {
        LevelData levelData = new LevelData();
        levelData.roomID = 2;
        levelData.roomdata = new RoomData();
        levelData.roomdata.door1 = false;
        levelData.roomdata.door2 = false;
        levelData.roomdata.door3 = true;
        levelData.roomdata.door4 = true;
        roomsManager.AddRoom(levelData);
    }

}
