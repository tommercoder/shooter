﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class aidKit : MonoBehaviour
{
    public int hp;


    private void Start()
    {
        StartCoroutine(wait());
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(6f);
        Destroy(gameObject);
    }
    private void OnApplicationQuit()
    {
        List<aidKit> temp = new List<aidKit>();
        temp = GameObject.FindObjectsOfType<aidKit>().ToList();

        foreach (aidKit d in temp)
        {
            Destroy(d);
        }
    }
}
