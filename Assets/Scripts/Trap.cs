using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap: MonoBehaviour
{
    public int trapInt;
    private Collider trapCol;

    public void Deactivate()
    {
        trapCol.enabled = false;
    }

    private void Start()
    {
        trapCol = this.GetComponent<Collider>(); 
    }
}
