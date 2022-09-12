using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheStaticThingy : MonoBehaviour
{

    public static TheStaticThingy instance;


    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }
}