using UnityEngine;

[CreateAssetMenu(menuName = "Combat/Weapon Data", fileName = "WeaponData_")]
public class WeaponClass : ScriptableObject
{
    [Header("Identity")]
    [SerializeField] private string weaponName = "Weapon";

    [Header("Combat")]
    [SerializeField] private int damage = 10;
    [SerializeField] private float attackSpeed = 1f;
    [SerializeField] private float attackCooldown = 0.5f;

    public string WeaponName => weaponName;
    public int Damage => damage;
    public float AttackSpeed => attackSpeed;
    public float AttackCooldown => attackCooldown;
}
