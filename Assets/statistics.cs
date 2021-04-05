using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class statistics : MonoBehaviour
{
    #region singleton
    public static statistics instance;
    private void Awake()
    {
        instance = this;
    }

    #endregion
    public Text score;
    public int scoreInt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //score.text = "score:"+  scoreInt.ToString();
    }
}
