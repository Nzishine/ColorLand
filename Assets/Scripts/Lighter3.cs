using UnityEngine;

public class Lighter3 : MonoBehaviour
{
    private GameObject player;
    private GameObject box;

    private GameObject Mist;
    private SpriteRenderer[] LightsRenderers;
   

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        box = GameObject.FindGameObjectWithTag("Box");
        Mist=GameObject.FindGameObjectWithTag("Mist");
        
        GameObject[] Lights = GameObject.FindGameObjectsWithTag("Lights");
        LightsRenderers = new SpriteRenderer[Lights.Length];
        
        for(int i = 0; i < Lights.Length; i++)
        {
            LightsRenderers[i] = Lights[i].GetComponent<SpriteRenderer>();
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(box);
            Destroy(Mist);
            foreach(SpriteRenderer renderer in LightsRenderers)
            {
                
                    renderer.color = new Color(1f,1f,1f,1f);

                    
                }
            }
        }
    }
