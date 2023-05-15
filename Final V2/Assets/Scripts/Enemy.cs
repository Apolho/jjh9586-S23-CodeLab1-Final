using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Vector2 playerDirection;

    private GameObject player;

    public GameObject projectile;

    public static bool shot = false;

    public float enemyHealth = 80;
    

    // Update is called once per frame
    void Update()
    {
        if (shot == false) //if enemy shot is false
        {
            shot = true; //turn it to true
            EnemyShooting(); //and call shoot function
        }

        if (enemyHealth < 0) //when helath goes below 0
        {
            Destroy(gameObject); //destroy the enemy
        }
    }

    void EnemyShooting()
    {
        GameObject bullet = Instantiate(projectile); //instantiates projectile

        bullet.transform.position = gameObject.transform.position; //makes the position of the projectile the position of the enemy

    }
}
