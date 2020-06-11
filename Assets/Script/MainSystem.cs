using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSystem : MonoBehaviour
{
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
                    Debug.Log("Unit select");
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
}
