using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ASCIILevelLoader : MonoBehaviour
{
    public GameObject
        player,
        wall,
        door,
        enemy,
        chest,
        currentPlayer,
        level;

    public static int currentLevel = 0;

    private bool gameStarted = false;

    private Vector3 reset = new Vector3(0, 0, -10);

   public int CurrentLevel
    {
        get {return currentLevel;}
        set
        {
            currentLevel = value;
            LoadLevel();
        }  
    }

    
    private const string FILE_NAME = "LevelNum.txt";
    private const string FILE_DIR = "/Levels/";
    private string FILE_PATH;

    public float xOffset;
    public float yOffset;
    public Vector2 playerStartPos;
        
    // Start is called before the first frame update
    void Start()
    {
        currentLevel = 0;
        FILE_PATH = Application.dataPath + FILE_DIR + FILE_NAME;
        LoadLevel();
    }

    bool LoadLevel()
    {
        Destroy(level);
        level = new GameObject("Level");
        
        string newPath = FILE_PATH.Replace("Num", currentLevel.ToString());
        
        string[] fileLines = File.ReadAllLines(newPath);

        for (int yPos = 0; yPos < fileLines.Length; yPos++)
        {
            string lineText = fileLines[yPos];

            char[] lineChars = lineText.ToCharArray();

            for (int xPos = 0; xPos < lineChars.Length; xPos++)
            {
                char c = lineChars[xPos];

                GameObject newObj = null;

                switch (c)
                {
                    case 'p':
                        playerStartPos = new Vector2(xPos + xOffset,yOffset - yPos);
                        newObj = Instantiate<GameObject>(player);
                        currentPlayer = newObj;
                        Camera.main.transform.parent = currentPlayer.transform;
                        Camera.main.transform.position = currentPlayer.transform.position + reset;
                        break;
                    case 'w':
                        newObj = Instantiate<GameObject>(wall);
                        break;
                    case 'd':
                        newObj = Instantiate<GameObject>(door);
                        break;
                    case 'e':
                        newObj = Instantiate <GameObject>(enemy);
                        break;
                    case 'c':
                        newObj = Instantiate<GameObject>(chest);
                        break;
                    default:
                        newObj = null;
                        break;
                    
                }

                if (newObj != null)
                {
                    newObj.transform.position =
                        new Vector2(xOffset + xPos,
                                            yOffset - yPos);

                    newObj.transform.parent = level.transform;
                }
            }
        }
        
        return false;
    } 

    public void LevelChange()
    {
        CurrentLevel++;
    }
    
    
}
