using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour
{
    [SerializeField] Text countHealthText;

    public static playerHealth instance;
    private void Awake()
    {
        instance = this;
    }
    public int currentHealth;
    public int maxHealth; 
    public GameObject deathMenuUI;
    public TMPro.TextMeshProUGUI score;
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 100;
        currentHealth = maxHealth;
        countHealthText.text = currentHealth.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //countHealthText.text = maxHealth.ToString();
        countHealthText.text = currentHealth.ToString();
        if(currentHealth<=0)
        {
            die();
        }
    }
    void die()
    {
<<<<<<< Updated upstream
        FindObjectOfType<GameManager>().EndGame();
        Destroy(gameObject);
=======
        List<aidKit> temp = new List<aidKit>();
        temp = GameObject.FindObjectsOfType<aidKit>().ToList();

        foreach (aidKit d in temp)
        {
            Destroy(d);
        }
        List<dropBullet> temp1 = new List<dropBullet>();
        temp1 = GameObject.FindObjectsOfType<dropBullet>().ToList();

        foreach (dropBullet d in temp1)
        {
            Destroy(d);
        }
        gameObject.SetActive(false);
        deathMenuUI.SetActive(true); 
        score.enabled = false;
        score.SetText("SCORE: " + statistics.instance.scoreInt.ToString());
        score.ForceMeshUpdate(true);
        score.enabled = true;

>>>>>>> Stashed changes
        //show score and buttons
        //save score and what we need to save
    }

}
