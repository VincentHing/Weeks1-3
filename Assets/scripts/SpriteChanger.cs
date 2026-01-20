using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color mycolour;
    public List <Sprite> barrels;
    
    public int randomNumber;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //PickRandomColour();
        PickARandomSprite();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame == true)
        {
            Debug.Log("try to change this sprite please");
            //PickRandomColour();
            if (barrels.Count > 0)
            {
                PickARandomSprite();
            }
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

        if(Mouse.current.leftButton.wasPressedThisFrame == true && barrels.Count>0)
        {
            barrels.RemoveAt(0);
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
        randomNumber = Random.Range(0, barrels.Count);
        //use that number to choose a sprite
        //assign that sprite to a renderer
        spriteRenderer.sprite = barrels[randomNumber];
    }


}
