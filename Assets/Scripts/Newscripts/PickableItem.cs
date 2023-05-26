using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableItem : MonoBehaviour
{
    public Scriptableweapon weapon;
    SpriteRenderer sRenderer;

    void Start()
    {
        sRenderer = GetComponent<SpriteRenderer>();
        sRenderer.sprite = weapon.weaponSprite;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        InventoryManager.instance.AddWeapon(weapon);

        Destroy(gameObject);
    }
}

