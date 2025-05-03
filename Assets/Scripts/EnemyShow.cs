using UnityEngine;

public class EnemyShow : MonoBehaviour
{
    private GameObject player;
    private GameObject box;
    private SpriteRenderer[] enemyRenderers;
     // آرایه برای تمام رندررهای دشمنان

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        box = GameObject.FindGameObjectWithTag("Box");
        
        // پیدا کردن تمام اشیاء با تگ Enemy و گرفتن رندررهای آنها
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        enemyRenderers = new SpriteRenderer[enemies.Length];
        
        for(int i = 0; i < enemies.Length; i++)
        {
            enemyRenderers[i] = enemies[i].GetComponent<SpriteRenderer>();
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            box.SetActive(false);
            foreach(SpriteRenderer renderer in enemyRenderers)
            {
                if(renderer != null)
                {
                    renderer.color = new Color(
                        renderer.color.r,
                        renderer.color.g,
                        renderer.color.b,
                        1f // آلفا = 1 (کاملاً مات)
                    );
                }
            }
        }
    }
}