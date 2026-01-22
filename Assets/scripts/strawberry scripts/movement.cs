using UnityEngine;
using UnityEngine.InputSystem;

public class movement : MonoBehaviour
{
    //both ends of the strawberry section's movement, and how far the mouse is from 0,0;
    public Vector2 startPos;
    public Vector2 endPos;
    public float distance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //grab mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //getting the distance from origin
        distance = Vector2.Distance(mousePos, Vector2.zero);

        //capping distance for the animation
        if (distance > 8)
        {
            distance = 8;
        }

        //turns distance into a value between 0 and 1 and uses it to lerp.
        transform.position = Vector2.Lerp(endPos, startPos, distance / 8);
    }
}
