using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public static playerHealth instance;
    private void Awake()
    {
        instance = this;
    }
    public int currentHealth;
    public int maxHealth;
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 100;
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentHealth<=0)
        {
            die();
        }
    }
    void die()
    {
        Destroy(gameObject);
        //show score and buttons
        //save score and what we need to save
    }
}
