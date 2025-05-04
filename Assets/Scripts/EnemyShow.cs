using UnityEngine;

public class EnemyShow : MonoBehaviour
{
    public GameObject player;
    public GameObject box;
    public SpriteRenderer[] enemyRenderers;
   

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        box = GameObject.FindGameObjectWithTag("Box");
        
        
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
                    renderer.color = new Color(1f,1f,1f,1f);
                }
            }
        }
    }
}