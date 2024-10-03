using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemies : MonoBehaviour {
    public GameObject theEnemy;
    public int xPos;
    public int zPos;
    public int enemyCount;
    private float delay = 0.1f;  // Initial delay time

    void Start() {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop() {
        while (true) {  // Infinite generation
            xPos = Random.Range(0, 13);
            zPos = Random.Range(0, 13);
            Instantiate(theEnemy, new Vector3(xPos, 5, zPos), Quaternion.identity);
            
            yield return new WaitForSeconds(delay);
            enemyCount += 1;

            delay += 0.1f;  // Increase delay after each enemy
        }
    }
}
