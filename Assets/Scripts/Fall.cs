using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject player;
    public GameObject box;
    public GameObject Circle;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        box = GameObject.FindGameObjectWithTag("Box4");
        Circle = GameObject.FindGameObjectWithTag("Water");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other){
         if (other.gameObject.CompareTag("Player")){
            Destroy(box);
            Destroy(Circle);
        }
       
    }
}
