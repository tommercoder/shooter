using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tempController : MonoBehaviour
{
    #region singleton
    public static tempController instance;
    private void Awake()
    {
        instance = this;
    }
    #endregion
    public Animator anim;
    public bool firstWave;
    public bool secondWave;
    public bool thirdWave;
    void Start()
    {
        firstWave = true;
        secondWave = false;
        thirdWave = false;
        anim = GetComponent<Animator>();
    }

  
    void Update()
    {
        if(Input.GetKeyDown("1"))
        {
            
            secondWave = false;
            thirdWave = false;
            firstWave = true;
            anim.SetBool("shotgunAnim", false);
            anim.SetBool("rifleAnim", false);
        }
        if(Input.GetKeyDown("2"))
        {
            firstWave = false;
            secondWave = true;
            anim.SetBool("shotgunAnim", true);
            anim.SetBool("rifleAnim", false);
        }
        if (Input.GetKeyDown("3"))
        {
            firstWave = false;
            secondWave = false;
            thirdWave = true;
            anim.SetBool("rifleAnim", true);
             
        }
    }
}
