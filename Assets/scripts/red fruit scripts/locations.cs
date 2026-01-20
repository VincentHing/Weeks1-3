using UnityEngine;
using UnityEngine.InputSystem;

public class locations : MonoBehaviour
{
    public Vector2 startPos;
    //ended up not using transform.position here because there isn't a predetermined start and ending time of the animations, it could work i think, but this works.
    public Vector2 endPos;
    //pretty sure somewhere in this there's a shortcut to get a vector 0,0 but i don't know that.
    //public Vector2 origin = Vector2.zero;
    //moments after writing that comment i saw the auto fill comment for this , leaving here for posterity
    public float distance;
     

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //grabbing the mouse value
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        distance = Vector2.Distance(Vector2.zero, mousePos);

        //setting the max range of the animation to prevent weird stuff
        if (distance > 7)
        {
            distance = 7;
        }
        
        transform.position = Vector2.Lerp(endPos, startPos, distance/7);
    }
}
