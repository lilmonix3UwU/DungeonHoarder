using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    [SerializeField] int roomCount;
    int currentRoomCount;
    [SerializeField] GameObject[] rooms;
    [SerializeField] Door startDoor;
    List<Door> blankDoors;


    private void Start()
    {
        blankDoors.Add(startDoor);
    }



    public void GenerateMap()
    {
        while (currentRoomCount < roomCount)
        {
            foreach (Door door in blankDoors)
            {











            }
        }
    }
}
