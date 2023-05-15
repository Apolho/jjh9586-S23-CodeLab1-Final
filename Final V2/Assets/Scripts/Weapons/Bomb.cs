using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : BasicWeapon
{
   public override void Start() //supposed to override the start, but destroy is not working
   {
      base.Start();
     
      //Invoke(Destroy(gameObject), 5f);
   }

   public override void Stats()
   {
      weaponDamage = 50;
      weaponSpeed = Heroes.strength * 15;
      damage = weaponDamage;
   }
   
}
