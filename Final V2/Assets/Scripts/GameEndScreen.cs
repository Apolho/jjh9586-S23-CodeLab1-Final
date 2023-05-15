using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameEndScreen : MonoBehaviour
{
    public TextMeshProUGUI displayText;

    // Start is called before the first frame update
    void Start()
    {
        if (Heroes.health > 0) //if the player has more than 0 health
        {
            displayText.text = "You Escaped!"; //it will change the text
        }

    }
}
