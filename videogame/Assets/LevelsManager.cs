using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsManager : MonoBehaviour
{
    public RoomsManager roomsManager;

    private void Start()
    {
        Events.OnDoorActive += OnDoorActive;
    }
    void OnDoorActive()
    {
        roomsManager.RemoveRoom();
        LoadNewLevel(2);
    }
    public void Init()
    {
        LoadNewLevel(1);
    }
    public void LoadNewLevel( int levelID)
    {
        LevelData levelData = new LevelData();
        levelData.roomID = levelID;
        levelData.roomdata = new RoomData();
        levelData.roomdata.door1 = true;
        levelData.roomdata.door2 = false;
        levelData.roomdata.door3 = true;
        levelData.roomdata.door4 = false;
        roomsManager.AddRoom(levelData);
    }

}
