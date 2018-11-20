using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    private Vector2 Target;
    public float speed;

    private void Start()
    {
        Target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Target, speed * Time.deltaTime);

        if(Vector2.Distance(transform.position, Target) < 0.2f)
        {
            Destroy(gameObject);
        }
    }

}
