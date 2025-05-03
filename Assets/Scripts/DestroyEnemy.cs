using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        // اگر شیء برخوردکننده جعبه بود (دارای تگ "box3")
        if (collision.gameObject.CompareTag("box3"))
        {
            // پیدا کردن تمام قارچ‌ها در صحنه
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy-M");
            
            // نابود کردن تمام قارچ‌ها
            foreach(GameObject enemy in enemies)
            {
                Destroy(enemy);
            }
            
            //Destroy(collision.gameObject);
        }
    }
}

