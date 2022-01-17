using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarController : MonoBehaviour
{
    public Image healthBar;
    public float maxHealth = 100f;
    public float currHealth;
    // PlayerController_Script Player;  for updating current player health, not using at this point

    private void Start()
    {
        currHealth = maxHealth;
    }

    private void Update()
    {
        HealthBarFiller();
    }

    public void HealthBarFiller()
    {
        healthBar.fillAmount = currHealth / maxHealth;
    }
    public void HitDamage(float damageRate)
    {
        if(currHealth > 0)
        {
            currHealth -= damageRate;
        }
    }
    public void Healing(float healingRate)
    {
        if (currHealth > 0 && currHealth<maxHealth)
        {
            currHealth += healingRate;
        }
    }
}
