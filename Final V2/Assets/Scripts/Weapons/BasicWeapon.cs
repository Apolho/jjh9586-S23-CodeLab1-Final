using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicWeapon : MonoBehaviour
{
    public float weaponDamage;
    public float weaponSpeed;
    public static float damage;

    private Rigidbody2D rb;

    private Vector3 direction;

    public virtual void Stats() //allows Stats to change when given a subclass
    {
        weaponDamage = 15;
        weaponSpeed = Heroes.speed * 25;
        damage = Heroes.strength + weaponDamage;
    }

    public virtual void Start()
    {
        Stats();
        rb = GetComponent<Rigidbody2D>();
        Vector3 dir = MousePosition() - GameObject.Find(Heroes.hero + ("(Clone)")).transform.position;
        
        rb.AddForce(dir.normalized * weaponSpeed);
    }
    public Vector3 MousePosition()
    {
        Vector3 direction = Input.mousePosition;//creates a Vector3 based on the mouse position, but in pixel coordinates. Gets mouse position in pixels


        direction.z = Camera.main.WorldToScreenPoint(transform.position).z;//gets the depth of the position from the world to the screen.


        return Camera.main.ScreenToWorldPoint(direction);//returns the value to the variable so it is that 3D world coordinate
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == ("Enemy")) //if enemy game object and knife collide
        {
            col.gameObject.GetComponent<Enemy>().enemyHealth -= damage; //and lower enemy health by the damage dealt
            Heroes.reload = false; //set player reload to false to be able to shoot again
            Destroy(gameObject); //destroy knife
            
         
        }
        else if (col.gameObject.tag == "Environment") //if knife hits environment
        {
            Heroes.reload = false;
            Destroy(gameObject);
        }

    }
}
