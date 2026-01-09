using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomCheck : MonoBehaviour
{
    bool checkActive = false;
    private void OnTriggerStay(Collider other)
    {
        if (checkActive)
        { 






        }
    }

    public IEnumerator Pause()
    {
        yield return new WaitForSeconds(0.1f);
    }



}
