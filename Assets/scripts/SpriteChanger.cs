using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color mycolour;
    public Sprite barrel0;
    public Sprite barrel1;
    public Sprite barrel2;
    public int randomNumber;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       //PickRandomColour();

    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame == true)
        {
            //PickRandomColour();
            PickARandomSprite();
        }

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
        //spriteRenderer.color = mycolour;

    }

    void PickARandomSprite()
    {
        //spriteRenderer

        //pick a random number
        randomNumber = Random.Range(0, 3);
        //use that number to choose a sprite
        //assign that sprite to a renderer
        if (randomNumber == 0)
        {
            spriteRenderer.sprite = barrel0;
        }
        else if (randomNumber == 1) 
        {
            spriteRenderer.sprite = barrel1;
        }
        else if (randomNumber == 2)
        {
            spriteRenderer.sprite = barrel2;
        }
    }


}
