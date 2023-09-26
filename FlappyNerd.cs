using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyNerd : MonoBehaviour
{
    public float _jumpheight = 250 ; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(1,0) * Time.deltaTime;

        if(Input.GetKeyDown(KeyCode.Space)) {
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * _jumpheight);
        }

    }
    private void OnCollisionEnter2D (Collision2D collision) {
        GetComponent<Renderer>().enabled = false ; 
        Time.timeScale= 0 ;
        
    }
}
