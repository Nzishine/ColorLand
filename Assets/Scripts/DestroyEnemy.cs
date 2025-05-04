using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    public GameObject Box;

    void Start(){

        Box = GameObject.FindGameObjectWithTag("box3");


    }

    void OnCollisionEnter2D(Collision2D other)
    {
        
        if (other.gameObject.CompareTag("box3"))
        {
            Destroy(Box);
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy-M");
            
            
            foreach(GameObject enemy in enemies)
            {
                Destroy(enemy);
                
            }
        }
    }
}

