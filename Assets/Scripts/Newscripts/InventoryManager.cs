using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;
    
    public Scriptableweapon[] weapons;
    public Text[] weaponsNames;
    public Image[] weaponsSprites;

    public Scriptableweapon[] armours;
    public Text[] armoursNames;
    public Image[] armoursSprites;
   
    void Awake()
    {
        instance = this;
    }

    public void AddWeapon(Scriptableweapon weapon)
    {
        for( int i = 0; i < weapons.Length; i++)
        {

            if(weapon.weaponType == 0)
            {
                if(weapons[i] == null)
                {
                    weapons[i] = weapon;
                    weaponsNames[i].text = weapon.weaponName;
                    weaponsSprites[i].sprite = weapon.weaponSprite;

                    return;                
                }
            }
            if(weapon.weaponType == 1)
            {
                if(armours[i] == null)
                {
                    armours[i] = weapon;
                    armoursNames[i].text = weapon.weaponName;
                    armoursSprites[i].sprite = weapon.weaponSprite;

                    return;                
                }
            }   

        }
    }
   
}