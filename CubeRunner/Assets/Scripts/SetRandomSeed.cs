﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRandomSeed : MonoBehaviour
{
    public string stringSeed = "seed String";
    public bool useStringSeed;
    public int seed;
    public bool randomizeSeed;
    void Awake()
    {
        if(useStringSeed)
        {
            seed = stringSeed.GetHashCode();
        }
        if(randomizeSeed)
        {
            seed = Random.Range(0, 9999);
        }
        Random.InitState(seed);
    }

    
}
