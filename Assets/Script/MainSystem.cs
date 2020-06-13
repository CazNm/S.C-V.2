using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSystem : MonoBehaviour
{
    UnitInfo selectedobj; //calling script
    TileInfo settile; // calling script

    public GameObject CanMove;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Select();
    }

    bool Select()
    {
        Vector2 mouse_pos = Camera.main.ScreenToWorldPoint(Input.mousePosition); //get mousepointer's position
        RaycastHit2D hit = Physics2D.Raycast(mouse_pos, Vector2.zero, 0f); //shooting ray for find object with collide

        if (Input.GetMouseButtonDown(0)) //left click event
        {
            if (hit.collider != null) //do when ray hit object with collide
            {
                if(hit.collider.gameObject.tag == "Unit") //check select object's tag
                {
                    Move(hit.collider.gameObject.name); // entering movement mode
                }
                // hit.transform.GetComponent<SpriteRenderer>().color = Color.red; // turn object's collor red for checking
                return true;
            }
            else //do when ray didn't hit object with collide
            {
                return false;
            }
        }
        else return false;
    }

    void Move(string unit) //unit movement
    {
        selectedobj = GameObject.Find(unit).GetComponent<UnitInfo>(); // get address of selected object

        int sox = selectedobj.x; // current x position of selected object
        int soy = selectedobj.y; // current y position of selected object

        for (int i = 0; i < selectedobj.posx.Length; i++)
        {
            for (int j = 0; j < selectedobj.posy.Length; j++)
            {
                int spx = selectedobj.posx[i]; // get x distance of selected object
                int spy = selectedobj.posy[j]; // get y distance of selected object

                if (spx+sox>=0 && spx+sox<=4 && spy+soy>=0 && spy + soy <= 4)
                {
                    string tile = selectedobj.Findtile(spx + sox, spy + soy);

                    settile = GameObject.Find(tile).GetComponent<TileInfo>(); // get address of tile

                    //GameObject Pointer = Instantiate(CanMove, new Vector2(settile.pos.x, settile.pos.y), Quaternion.identity);
                }
            }
        }
    }
}
