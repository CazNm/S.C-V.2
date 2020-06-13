using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileInfo : MonoBehaviour
{
    public Vector2 pos;
    public float tilex;
    public float tiley;
    public bool uniton;

    // Start is called before the first frame update
    void Awake()
    {
        pos = this.gameObject.transform.position; // find tile's position
        tilex = pos.x;
        tiley = pos.y;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
