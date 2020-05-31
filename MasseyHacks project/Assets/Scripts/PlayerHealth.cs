using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

    public float health = 100f;

    // Update is called once per frame
    void Update()
    {
     if (health <= 0)
     {
       Cursor.lockState = CursorLockMode.None;
       Cursor.visible = true;
       SceneManager.LoadScene("GameOverScene");
     }
    }
}
