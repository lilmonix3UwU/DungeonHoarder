using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;

public class Room : MonoBehaviour
{

    bool north = false;
    [SerializeField] Door nDoor = null;
    bool south = false;
    [SerializeField] Door sDoor = null;
    bool east = false;
    [SerializeField] Door eDoor = null;
    bool west = false;
    [SerializeField] Door wDoor = null;
    List<Door> doors = new List<Door>();

    public GameObject rooomtype;

    private void Start()
    {
        if (nDoor != null)
        {
            doors.Add(nDoor);
            north = true;
        }
        if (sDoor != null)
        {
            doors.Add(sDoor);
            south = true;
        }
        if (eDoor != null) 
        {
            doors.Add(eDoor);
            east = true;
        }
        if (wDoor != null) 
        {
            doors.Add(wDoor);
            west = true;
        }
    }

    public bool IsNorth(bool x)
    {
        return north;
    }
    public bool IsSouth(bool x)
    {
        return south;
    }
    public bool IsEast(bool x)
    {
        return east;
    }
    public bool IsWest(bool x)
    {
        return west;
    }
    public List<Door> GetDoors(List<Door> x)
    {
        return doors;
    }



}
