using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
    private float         xPos;
    public float          speed = .05f;
    public float          leftWall, rightWall;
    public KeyCode        fireKey;

    public GameObject    projectile;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            if (xPos > leftWall) {
                xPos -= speed;
            }
        }

        if (Input.GetKey(KeyCode.RightArrow)) {
            if (xPos < rightWall) {
                xPos += speed;
            }
        }
        
        if (Input.GetKeyDown(fireKey)){
            Instantiate(projectile, new Vector2(transform.position.x, transform.position.y + .5f), transform.rotation);
        }

        transform.localPosition = new Vector3(xPos, transform.position.y, 0);
    }
}

