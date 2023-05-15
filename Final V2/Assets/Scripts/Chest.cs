using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.SceneManagement;
using UnityEngine.UIElements;

public class Chest : MonoBehaviour
{
    public GameObject weapon1;
    public GameObject weapon2;

    private void Start() //when chest is instantiated
    {
        for (int i = 0; i < GameManager.instance.weaponsAvailable.Length; i++) //loop through array in the game manager
        {
            GameManager.instance.weaponsAvailableDictionary.Add(GameManager.instance.weaponsAvailable[i].ToString(), GameManager.instance.weaponsAvailable[i]); 
            //and use the gameobject in the array to add to the dictionary
        }
    }

    public void ChestClicked()
    {
        foreach (KeyValuePair<string, GameObject> keyValuePair in GameManager.instance.weaponsAvailableDictionary) //goes through the dictionary
        {
            for (int i = 0; i < GameManager.instance.weaponsAvailable.Length; i++) //then loops through the array
            {
                if (GameManager.instance.weaponsAvailable[i] == keyValuePair.Value) //and if the array object is equal to the key of the dictionary
                {
                    weapon2 = GameManager.instance.weaponsAvailable[i]; //assign the game object to weapon 2
                    GameManager.instance.weaponsAvailableDictionary.Remove(GameManager.instance.weaponsAvailable[i].ToString()); //then remove the dictionary key
                }
            }
        }
        
    }

    void Update()
    {
        if (weapon1 == null) //when weapon1 is null
        {
            weapon1 = GameObject.FindWithTag("Player").GetComponent<Heroes>().weapon; //equal the object to the weapon the player has
        }
    }
}
