using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponClass : MonoBehaviour
{
    [SerializeField] private string weaponName;
    [SerializeField] private int damage; 
    [SerializeField] private float attackSpeed;
    [SerializeField] private float cooldownAttack;  


    // Start is called before the first frame update
    void Start()
    {
        if(weaponName != null)
        {
            Debug.Log("Equipped weapon: " + weaponName);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
