using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickLayerScript : MonoBehaviour
{
    public Transform brick;
    public int numRows, numColumns;
    public float xSpacing, ySpacing;
    public float xOrigin, yOrigin;
    public Color[] brickColors;
    public int[] scorePoints = {10, 20, 30, 40, 50};

    public static BrickLayerScript S;

    void Awake()
    {
        S = this;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        LayBricks(numRows, numColumns);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LayBricks(int _numRows, int _numColumns)
    {
        for (int i = 0; i < _numRows; i++)
        {
            for(int j=0; j< _numColumns; j++)
            {
                Transform t = Instantiate(brick);
                t.transform.parent = this.transform;
                Vector2 loc = new Vector2(xOrigin + (i * xSpacing), yOrigin - (j * ySpacing));

                SpriteRenderer sr = t.GetComponent<SpriteRenderer>();
                sr.color = brickColors[j];

                GameManagerScript.S.AddToTotalBricks();
                t.transform.position = loc;
            }
        }
    }
}
