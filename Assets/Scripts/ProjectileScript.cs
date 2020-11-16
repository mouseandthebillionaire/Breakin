using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    public float               speed = 2f;
    public int                 direction;
    public GameObject          explosion;
    
    private Rigidbody2D        rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine("Launch");
    }


    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "enemy") {
                return;
            }

         if (other.gameObject.tag == "player") {
                Debug.Log("we hit the player!");
         }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "enemy") {
            Instantiate(explosion, this.transform.position, Quaternion.identity);
                Destroy(other.gameObject);
                Destroy(this.gameObject);
        }
        
        if (other.gameObject.tag == "wall") {
           Debug.Log("Bounds");
           Destroy(this.gameObject);
        }
    }
    
    private IEnumerator Launch() {
        //yield return new WaitForSeconds(1);
        rb.AddForce(transform.up * speed);
        
        yield return null;
    }
}
