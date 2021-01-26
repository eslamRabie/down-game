using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using Random = UnityEngine.Random;

public class Collectabels : MonoBehaviour
{
    private Rigidbody2D collectableBody;
    private bool is_creating;

    private void Awake()
    {
        is_creating = true;
        Wait();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!is_creating) Create();
    }
    async void Create()
    {
        is_creating = true;
        await Task.Delay(Random.Range(1000, 3000));
        var x = Instantiate(gameObject);
        x.GetComponent<Collectabels>().enabled = false;
        var body = x.GetComponent<Rigidbody2D>();
        body.gravityScale = 0;
        body.position = new Vector2(Random.Range(-6.5f, 6.5f), -7f);
        body.velocity = new Vector2(Random.Range(-5f, 5f), Random.Range(5f, 10f));
        is_creating = false;
    }

    async void Wait()
    {
        await Task.Delay(1000);
        is_creating = false;
    }
}



