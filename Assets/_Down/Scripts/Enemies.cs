using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public GameObject ob;
    float nextSpawn = 1.0f;
    private Vector2 screenBounds;
    float RandX;
    Vector2 whereToSpawn;
    [SerializeField]
    private float spawnRate;


    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(q());
    }
    private void GenerateEnemies()
    {

        //nextSpawn = Time.time + .8f;
        RandX = Random.Range(-6.5f, 6.5f);
        whereToSpawn = new Vector2(RandX, transform.position.y);


        ////  rigidbody2D.velocity = (new Vector2(Random.Range(1, 5), Random.Range(1, 5))) ;

        //Instantiate(Medium, whereToSpawn, Quaternion.identity);

        GameObject enemy = Instantiate(ob, whereToSpawn, Quaternion.identity) as GameObject;
       // enemy.transform.position = new Vector2(screenBounds.y*0.5f, Random.Range(-screenBounds.x, screenBounds.x));
        //
    }
    IEnumerator q()
    {
        while (true) {
            yield return new WaitForSeconds(nextSpawn);
            GenerateEnemies();
        }
   
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private int score = 0;
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "end")
        {    
            score++;
            if (gameObject.tag =="enemy")
            {
                Destroy(gameObject, .5f);
            }
        }
    }
}
