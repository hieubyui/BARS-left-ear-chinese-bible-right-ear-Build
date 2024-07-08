using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class move : MonoBehaviour { 
    public float speed = 10;
    public int Respawn;


    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        moveCube(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
    }

    private void moveCube(Vector2 direction)
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("resetgame"))
        {
            Debug.Log("Just collided fam");
            SceneManager.LoadScene(Respawn); //resets the game
        }

    }


}
