using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
  public static GameObject weaponPicked;
  
  public GameObject weapon1 = GameManager.instance.currentChest.GetComponent<Chest>().weapon1;
  public GameObject weapon2 = GameManager.instance.currentChest.GetComponent<Chest>().weapon2;
  public GameObject playerWeapon = GameObject.FindWithTag("Player").GetComponent<Heroes>().weapon;

  public GameObject previousWeapon;
  
  public void Clicked(int weaponPickedNumber) //when button is clicked, it will send a number
  {
   
    if (weaponPickedNumber == 1) //if the number is 1
    {
      //nothing happens. Weapon stays the same
      return;
    }
    else if (weaponPickedNumber == 2) //but if the number is 2
    {
      weaponPicked = weapon2; //weapon picked will become object in weapon 2 slot
      weapon2 = playerWeapon; //weapon 2 will become the current weapon the player has
      playerWeapon = weaponPicked; //then the player's weapon will change to the weapon picked
      weapon1 = null; //and weapon 1 will become null, being updated in the next frame as the weapon the player picked
    }
    GameManager.instance.weaponSelection.gameObject.SetActive(false); //turn off canvas
  }

}
