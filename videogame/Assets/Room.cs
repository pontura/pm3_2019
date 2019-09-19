using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    public DoorsManager doorsManager;

    public void Init(RoomData roomData)
    {
        doorsManager.Init(
            roomData.door1,
            roomData.door2,
            roomData.door3,
            roomData.door4
            );
    }
}
