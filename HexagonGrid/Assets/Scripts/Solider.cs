﻿using UnityEngine;
using System.Collections;

public class Solider : MonoBehaviour {

    public int ownerPlayer = 0;
    public int moveInTurn = 1;
    public int crystalCost = 2;
    public int healt = 2;
    public int movementLenght = 1;
    public int attack = 2;
    public int attackInTurn = 1;

    void Update()
    {
        if(healt <= 0) { ZeroHealth(); }
    }

    void ZeroHealth()
    {
        Destroy(gameObject);
    }

    public void Move(Vector3 place)
    {
        GetComponent<GridMove>().dest = place;
    }
    

}
