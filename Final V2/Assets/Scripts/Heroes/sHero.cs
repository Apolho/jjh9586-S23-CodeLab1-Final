using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sHero : Heroes
{
    protected override void Hero()
    {
        speed = 10f;
        health = 80;
        strength = 20;
    }
}

