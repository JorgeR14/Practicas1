using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth;
    private int currentHealth;
    private Vector3 initialposition;
    public Text healthText;

    private void Start()
    {
        initialposition = transform.position;
        currentHealth = maxHealth;
        healthText.text = currentHealth.ToString();
    }

    public void TakeDamage(int damageTaken)
    {
        currentHealth -= damageTaken;
        healthText.text = currentHealth.ToString();
        if (currentHealth <= 0)
        {
            Debug.Log("MUERTO");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            SceneManager.LoadScene(4);
            Cursor.lockState = CursorLockMode.None;
            transform.position = initialposition;
            currentHealth = maxHealth;
            healthText.text = currentHealth.ToString();
        }
        else
        {
            Debug.Log("Ayy, mi vida actual es de" + currentHealth);
        }
    }
}