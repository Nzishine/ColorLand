using UnityEngine;

public class GreenEnvironmet : MonoBehaviour
{
 

    public GameObject player;
    public GameObject Circle;
    public SpriteRenderer[] environmentRenderers; 

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        Circle = GameObject.FindGameObjectWithTag("Green");
        

       
        
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
            Destroy(Circle);
                foreach(SpriteRenderer renderer in environmentRenderers)
                {

                        renderer.color = new Color(1f,1f,1f,1f); 

                }
        }
        
}
}
