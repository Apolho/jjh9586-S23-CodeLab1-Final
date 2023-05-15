using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject[] heroes;

    private Vector3 direction;
    
    public int gameEnd = 0;
    

    // Start is called before the first frame update

    private void Awake()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        if (Heroes.hero == "Square")
        {
            gameObject.GetComponent<ASCIILevelLoader>().player = heroes[0];
        }
        else if (Heroes.hero == "Triangle")
        {
            gameObject.GetComponent<ASCIILevelLoader>().player = heroes[1];
        }
        else if(Heroes.hero == "Circle")
        {
            gameObject.GetComponent<ASCIILevelLoader>().player = heroes[2];
        }

    }

    public Dictionary<string, GameObject> weaponsAvailableDictionary = new Dictionary<string,GameObject>();
    public GameObject[] weaponsAvailable;

    public Canvas weaponSelection;
    public GameObject currentChest;


}
