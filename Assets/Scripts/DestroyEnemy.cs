using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    private GameObject Box;

    void Start(){

        Box = GameObject.FindGameObjectWithTag("box3");


    }

    void OnCollisionEnter2D(Collision2D other)
    {
        // اگر شیء برخوردکننده جعبه بود (دارای تگ "box3")
        if (other.gameObject.CompareTag("box3"))
        {
            Destroy(Box);
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy-M");
            
            // نابود کردن تمام قارچ‌ها
            foreach(GameObject enemy in enemies)
            {
                Destroy(enemy);
                
            }
        }
    }
}

