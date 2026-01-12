using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] GameObject wallReplacement;

    [SerializeField] RoomCheck nextCheck;
    
    [SerializeField] RoomCheck leftCheck;
    [SerializeField] RoomCheck straightCheck;
    [SerializeField] RoomCheck rightcheck;

    RoomCheck north;
    RoomCheck south;
    RoomCheck east;
    RoomCheck west;

    public bool isBlocked = false;

    public string requiredDoor;
    public bool northBlocked = false;
    public bool southBlocked = false;
    public bool eastBlocked = false;
    public bool westBlocked = false;

    bool spamprev = true;

    // Start is called before the first frame update
    void Start()
    {
        if (straightCheck.gameObject.transform.position.z < (transform.position.z -25))
        {
            requiredDoor = "south";
            north = straightCheck;
            east = rightcheck;
            west = leftCheck;
        }
        else if (straightCheck.gameObject.transform.position.z > (transform.position.z + 25))
        {
            requiredDoor = "north";
            south = straightCheck;
            west = rightcheck;
            east = leftCheck;
        }
        else if (straightCheck.gameObject.transform.position.x <(transform.position.x -25))
        {
            requiredDoor = "east";
            west = straightCheck;
            north = rightcheck;
            south = leftCheck;
        }
        else if (straightCheck.gameObject.transform.position.x > (transform.position.x + 25))
        {
            requiredDoor = "west";
            east = straightCheck;
            south = rightcheck;
            north = leftCheck;
        }
    }

    private void Update()
    {
        
        if (nextCheck.isRoom() && spamprev)
        {
            wallReplacement.SetActive(true);
            isBlocked = true;
            spamprev = false;
        }
    }


}
