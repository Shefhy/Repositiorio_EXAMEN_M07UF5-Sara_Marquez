using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Items/New Weapon")]
public class Scriptableweapon : ScriptableObject
{
    public string weaponName;
    public string weaponDescription;
    public Sprite weaponSprite;
    public float weaponDamage;
    public float weaponPrice;
    public float weaponType;

}
