﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    public Vector3 rotate;
        void Update()
    {
        this.transform.Rotate(rotate*1*Time.deltaTime);
    }
}
