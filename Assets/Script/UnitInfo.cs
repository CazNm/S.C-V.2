using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitInfo : MonoBehaviour
{
    TileInfo settile; // calling script

    public int x; // position
    public int y; // position
    public int[] posx; // distance can move
    public int[] posy; // distance can move
    public string tile;

    // Start is called before the first frame update
    void Start()
    {
        x = 2;
        y = 4;

        if(this.gameObject.name == "군다일지도") // set Gundar's info
        {
            posx = new int[3] { -1, 0, 1 };
            posy = new int[1] { -1 };
        }

        tile = Findtile(x, y);

        settile = GameObject.Find(tile).GetComponent<TileInfo>(); // get address of tile
        transform.position = new Vector2(settile.pos.x, settile.pos.y); // set on the tile
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string Findtile(int x, int y) // find tile for set
    {
        switch (y)
        {
            case 0:
                switch (x)
                {
                    case 0:
                        return "A1";
                    case 1:
                        return "B1";
                    case 2:
                        return "C1";
                    case 3:
                        return "D1";
                    case 4:
                        return "E1";
                }
                break;
            case 1:
                switch (x)
                {
                    case 0:
                        return "A2";
                    case 1:
                        return "B2";
                    case 2:
                        return "C2";
                    case 3:
                        return "D2";
                    case 4:
                        return "E2";
                }
                break;
            case 2:
                switch (x)
                {
                    case 0:
                        return "A3";
                    case 1:
                        return "B3";
                    case 2:
                        return "C3";
                    case 3:
                        return "D3";
                    case 4:
                        return "E3";
                }
                break;
            case 3:
                switch (x)
                {
                    case 0:
                        return "A4";
                    case 1:
                        return "B4";
                    case 2:
                        return "C4";
                    case 3:
                        return "D4";
                    case 4:
                        return "E4";
                }
                break;
            case 4:
                switch (x)
                {
                    case 0:
                        return "A5";
                    case 1:
                        return "B5";
                    case 2:
                        return "C5";
                    case 3:
                        return "D5";
                    case 4:
                        return "E5";
                }
                break;
        }
        return "";
    }
}
