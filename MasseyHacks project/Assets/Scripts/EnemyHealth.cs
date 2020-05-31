using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
   public float health;

   public GameObject scores;

   public float addScore;

   public GameObject explosion;

   void Update(){
       if(health <= 0)
       {
        AddScore();
        DestroyObject();
       }
   }

   public void TakeDamage(float amount)
   {
       health = health - amount;
   }
   void DestroyObject()
   {
     GetComponent<FollowPlayer>().enabled = false;
     GameObject explosionOnDeath = Instantiate(explosion,transform.position, Quaternion.identity);
     Destroy(explosionOnDeath, 1f);
     Destroy(gameObject, 1f);
   }
   void AddScore()
   {
     ScoreHolder scoreHolder = scores.GetComponent<ScoreHolder>();
     addScore++;
     if (addScore <= 20){
       scoreHolder.scores = scoreHolder.scores + 1f;
     }

   }
}
