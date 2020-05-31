using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public float speed = 11f;
    public float damage = 5f;
    Rigidbody rb;


    void Start()
    {
      rb = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void FixedUpdate()
    {
      Vector3 pos = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.fixedDeltaTime);
      rb.MovePosition(pos);
    }
    void OnCollisionEnter(Collision col){
      if(col.gameObject.name == "FirstPersonPlayer")
      {
        PlayerHealth playerHealth = player.GetComponent<PlayerHealth>();

        playerHealth.health = playerHealth.health - damage;
      }
    }
}
