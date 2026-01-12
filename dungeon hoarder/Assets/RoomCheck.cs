using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomCheck : MonoBehaviour
{
    bool checkActive = false;
    bool roomCheck = false;
    private void Start()
    {
        checkActive = true;
    }
    private void OnTriggerStay(Collider other)
    {
        if (checkActive)
        { 
            roomCheck = true;
            checkActive = false;




        }
    }

    public bool isRoom()
    {
        return roomCheck;
    }

}
