using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 100;
        currentHealth = maxHealth;
        countHealthText.text = currentHealth.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
		if(collision.gameObject.CompareTag("FirstAid"))
        {

            Debug.Log(collision.gameObject.name);
            currentHealth += 20;
            Destroy(collision.gameObject);

        }
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
        
        SceneManager.LoadScene("SampleScene");
        Destroy(gameObject);
        //show score and buttons
        //save score and what we need to save
    }
}
