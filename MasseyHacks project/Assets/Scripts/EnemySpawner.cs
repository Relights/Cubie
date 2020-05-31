using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject scores;

    public GameObject enemies;
    public GameObject playerObject;

    public Transform spawnPosition;

    // Update is called once per frame
    void Start()
    {
        StartCoroutine(EnemySpawn());
    }
    IEnumerator EnemySpawn()
    {
        while(true){
            while(transform.childCount < 35){
            GameObject enemy = Instantiate(enemies,spawnPosition.position, Quaternion.identity);
            enemy.name = "Enemy";
            enemy.transform.parent = gameObject.transform;

            FollowPlayer followPlayer = enemy.GetComponent<FollowPlayer>();
            followPlayer.player = playerObject;
            
            EnemyHealth enemyHealth = enemy.GetComponent<EnemyHealth>();
            enemyHealth.scores = scores;

            yield return new WaitForSeconds(.75f);
                
            }
            yield return new WaitForSeconds(.2f);
        }

    }
}
