using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickBlade : BasicWeapon
{
    public override void Stats()
    {
         weaponDamage = 15;
        weaponSpeed = Heroes.speed * 50;
        damage = weaponDamage * Heroes.speed;
    }
}
