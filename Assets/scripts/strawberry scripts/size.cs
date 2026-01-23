using UnityEngine;
using UnityEngine.InputSystem;

public class size : MonoBehaviour
{
    //similar to movement
    public Vector2 endScale;
    public Vector2 startScale;
    public AnimationCurve curve;
    public float distance;
    public float curvePart;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //grab mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //getting the distance from origin again
        distance = Vector2.Distance(mousePos, Vector2.zero);

        //capping distance for the animation
        if (distance > 8)
        {
            distance = 8;
        }
        //translates the distance/7 (what would be the % of the lerp) into the % of the lerp with animation curve
        curvePart = curve.Evaluate(distance / 7);

        //pretty much the same as the other thing, but with an animation curve
        transform.localScale = Vector2.Lerp(endScale, startScale, curvePart);
     

    }
}
