using UnityEngine;

public class Environment : MonoBehaviour
{
    private GameObject player;
    private GameObject box;

   
    private SpriteRenderer[] environmentRenderers; 

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        box = GameObject.FindGameObjectWithTag("Box2");
        
       
        
        GameObject[] envi = GameObject.FindGameObjectsWithTag("Environment");
        environmentRenderers = new SpriteRenderer[envi.Length];
        
        for(int i = 0; i < envi.Length; i++)
        {
            environmentRenderers[i] = envi[i].GetComponent<SpriteRenderer>();
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            box.SetActive(false);
            
            foreach(SpriteRenderer renderer in environmentRenderers)
            {
                
                    renderer.color = new Color(
                       1f,
                       1f,
                       1f,
                        1f
                    );
                
            }
        }
    }
}