using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    private Image healthBar;
    private int currentHealth;
    private int maxHealth = 100;
    private int playerHealth;


    // Start is called before the first frame update
    void Start()
    {
       // playerHealth = GameManager.Instance.playerHealth;
        healthBar = GetComponent<Image>();
        
    }

    // Update is called once per frame
    void Update()
    {
       //currentHealth = GameManager.Instance.playerHealth;
       healthBar.fillAmount = currentHealth / maxHealth;
    }
}
