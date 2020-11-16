using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {
    public GameObject     enemyProjectile;
    
    // Start is called before the first frame update
    void Start() {
        float f = Random.Range(2f, 5f);
        InvokeRepeating("Fire", f, f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Fire() {
        int i = Random.Range(0, 100);

        if (i > 80) {
            Instantiate(enemyProjectile, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
        }
    }
    
}
