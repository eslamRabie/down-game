using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enmy : MonoBehaviour
{
 private Rigidbody2D rigidbody2D;
    private Vector2 screenBounds;
    //[SerializeField]
    //private GameObject Large;
    //[SerializeField]
    //private GameObject Medium;
    //[SerializeField]
    //private GameObject Small;
    //float RandX;
    //Vector2 whereToSpawn;
    //[SerializeField]
    //private float spawnRate;
    //float nextSpawn = 0.0f;
    //float timer;
    public float speed;
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D=this.GetComponent<Rigidbody2D>();
        rigidbody2D.velocity = new Vector2(0, speed);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {

        //if (transform.position.x < screenBounds.x*2)
        //{
        //    score++;
        //    Destroy(this.gameObject);
        //}
        //if (Time.time > nextSpawn)
        //{
        //    GenerateLarge();
         

        //}
      
    }
    //void GenerateLarge()
    //{

    //    nextSpawn = Time.time + 1f;
    //    RandX = Random.Range(-4.11f, 7.99f);
    //    whereToSpawn = new Vector2(RandX, transform.position.y);
    //    Instantiate(Large, whereToSpawn, Quaternion.identity);




    //}
    //void GenerateMedium()

    //{

    //    nextSpawn = Time.time +.2f;
    //        RandX = Random.Range(-4.11f, 7.99f);
    //        whereToSpawn = new Vector2(RandX, transform.position.y);

    //        //Vector3 v = Physics.gravity * rigidbody2D.mass;
    //        //rigidbody2D.AddForce(-v);
    //     //   rigidbody2D.velocity = (new Vector2(Random.Range(1, 5), Random.Range(1, 5))) ;
    //         Instantiate(Medium, whereToSpawn, Quaternion.identity);


    //}
    //void GenerateSmall()
    //{
    //    nextSpawn = Time.time + .3f;
    //        RandX = Random.Range(-4.11f, 7.99f);
    //        whereToSpawn = new Vector2(RandX, transform.position.y);

    //        //Vector3 v = Physics.gravity * rigidbody2D.mass;
    //        //rigidbody2D.AddForce(-v);
    // rigidbody2D.velocity = (new Vector2(Random.Range(1, 5), Random.Range(1, 5))) ;
    //rigidbody2D.velocity = (transform.forward* vertical) * speed * Time.fixedDeltaTime;

    //         Instantiate(Small, whereToSpawn, Quaternion.identity);

    //}
}
