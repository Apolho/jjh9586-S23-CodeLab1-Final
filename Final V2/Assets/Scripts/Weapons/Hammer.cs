using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : BasicWeapon
{
    public override void Stats() //chnages the stats method but uses the methods of its base
    {
        weaponDamage = 18;
        weaponSpeed = Heroes.strength * 25;
        damage = weaponDamage * Heroes.strength;
    }
}
