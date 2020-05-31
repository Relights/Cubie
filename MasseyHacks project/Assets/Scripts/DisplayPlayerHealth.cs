using UnityEngine;
using UnityEngine.UI;

public class DisplayPlayerHealth : MonoBehaviour
{

    public GameObject player;

    public float health;
    public float maxHealth = 100;
    public Slider slider;

    // Update is called once per frame
    void Update()
    {
      PlayerHealth playerHealth = player.GetComponent<PlayerHealth>();
      health = playerHealth.health;
      slider.value = health / maxHealth;
    }

}
