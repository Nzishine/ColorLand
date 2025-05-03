using UnityEngine;
using UnityEngine.Tilemaps; // اضافه کردن این namespace

public class BrownEnvironment : MonoBehaviour
{
    private GameObject player;
    private GameObject circle;
    private Tilemap groundTilemap; // تغییر نوع به Tilemap

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        circle = GameObject.FindGameObjectWithTag("Brown");
        
        GameObject ground = GameObject.FindGameObjectWithTag("Ground");
       
            // دریافت کامپوننت Tilemap
        groundTilemap = ground.GetComponent<Tilemap>();
            
           
       
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // نابود کردن شیء Brown
           
                Destroy(circle);
          

            // تغییر رنگ Tilemap
          
                groundTilemap.color = new Color(1f, 1f, 1f, 1f); // سفید کامل
            
        }
    }
}