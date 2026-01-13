using UnityEngine;

public class teleport : MonoBehaviour
{
    public float t;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = transform.position;
        
        t += Time.deltaTime;
        if (t > 3) {
            Vector2 screenPos = new Vector2(Random.Range(0,Screen.width), Random.Range(0,Screen.height));
           newPos = Camera.main.ScreenToWorldPoint(screenPos);
            t = 0;
        }
        transform.position = newPos;
       
        


        
    }
}
