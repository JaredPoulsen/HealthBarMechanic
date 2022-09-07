using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    public Image healthBar;


    float health, maxHealth = 100;
    float lerpSpeed;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        HealthBarFiller();
        ColorChanger();
        if (health > maxHealth) health = maxHealth;

        lerpSpeed = 3f * Time.deltaTime;
    }

    void HealthBarFiller()
    {
        healthBar.fillAmount = Mathf.Lerp(healthBar.fillAmount, health / maxHealth, lerpSpeed);

    }

    void ColorChanger()
    {
        Color healthColor = Color.Lerp(Color.red, Color.green, (health / maxHealth));
        healthBar.color = healthColor;
    }

    public void Damage(float damagePoints)
    {
        if (health > 0)
        {
            health -= damagePoints;
        }

    }

    public void Heal(float healingPoints)
    {
        if(health < maxHealth)
        {
            health += healingPoints;
        }
    }
}
