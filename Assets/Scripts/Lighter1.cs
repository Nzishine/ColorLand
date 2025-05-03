using UnityEngine;

public class Lighter : MonoBehaviour
{
    private GameObject lighter;
    private GameObject light;
    private SpriteRenderer lightRenderer; 

    private SpriteRenderer MistRenderer;

    private GameObject Mist;

    void Start()
    {
        lighter = GameObject.FindGameObjectWithTag("Lighter1");
        
       
         light = GameObject.FindGameObjectWithTag("Light1");

         Mist = GameObject.FindGameObjectWithTag("Mist");


        MistRenderer = Mist.GetComponent<SpriteRenderer>();
        
        lightRenderer = light.GetComponent<SpriteRenderer>();
          
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
           
            Destroy(lighter);
            MistRenderer.material.color = new Color(1f, 1f, 1f, 0.75f);

            
             lightRenderer.color = Color.white;
             
        }
    }
}