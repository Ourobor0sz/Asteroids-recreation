using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementscript : MonoBehaviour
{
    private float speed = 5.0f;
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        float dt = Time.deltaTime;

        float dirx = Input.GetAxis("Horizontal");
        float diry = Input.GetAxis("Vertical");

        transform.position += new Vector3(dirx * speed, diry * speed, 0) * dt;

        // bullet code

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bulletclone = Instantiate(bullet);
            bulletclone.transform.position = new Vector3(transform.position.x, transform.position.y + 1, 0);
            bulletclone.GetComponent<Rigidbody2D>().velocity = Vector3.up * speed;
        }

    }
}
