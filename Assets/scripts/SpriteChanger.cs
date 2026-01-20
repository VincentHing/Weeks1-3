using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color mycolour;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       PickRandomColour();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Keyboard.current.anyKey.wasPressedThisFrame == true)
        //{
        //    PickRandomColour();
        //}

        //get the mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //is it over the thing
        if (spriteRenderer.bounds.Contains(mousePos))
        {
            //y: set the colour of the variable
            spriteRenderer.color = mycolour;

        }
        else 
        {
            //n: set the colour to white.
            spriteRenderer.color = Color.white;
        }
        
        

    }
    void PickRandomColour() 
    {
        spriteRenderer.color = Random.ColorHSV();
        spriteRenderer.color = mycolour;

    }


}
