using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tHero : Heroes
{
    protected override void Hero()
    {
        speed = 15f;
        health = 60;
        strength = 15;
    }
}

