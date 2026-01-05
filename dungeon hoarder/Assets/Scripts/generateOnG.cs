using RMG;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateOnG : MonoBehaviour
{
    [SerializeField] MapGenerator map;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            map.Generate();
        }
    }
}
