using UnityEngine;
using UnityEngine.Tilemaps; 

public class BrownEnvironment : MonoBehaviour
{
    public GameObject player;
    public GameObject circle;
    public Tilemap groundTilemap; 

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        circle = GameObject.FindGameObjectWithTag("Brown");
        
        GameObject ground = GameObject.FindGameObjectWithTag("Ground");
       
         
        groundTilemap = ground.GetComponent<Tilemap>();
            
           
       
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            
           
                Destroy(circle);
          
          
                groundTilemap.color = new Color(1f, 1f, 1f, 1f); 
            
        }
    }
}