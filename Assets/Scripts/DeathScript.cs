using UnityEngine;


public class DeathScript : MonoBehaviour
{
    public GameObject player;
    public Vector3 StartPoint;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        StartPoint = player.transform.position;
        
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
      

        if (other.gameObject.CompareTag("Player"))
        {
            player.transform.position = StartPoint;
           
        }
    }

  
}