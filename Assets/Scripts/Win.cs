using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinMessage : MonoBehaviour
{
    public GameObject Win;
    void Start()
    {
        Cursor.visible=false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    void OnCollisionEnter2D(Collision2D other){
        if (other.gameObject.CompareTag("Player")){
            Time.timeScale=0f;
            Win.SetActive(true);
            
        }
    }
}
