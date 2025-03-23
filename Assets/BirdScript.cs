using UnityEngine;
using UnityEngine.UIElements;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic=GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y<-21)
        {
            birdIsAlive = false;
            logic.gameOver();
        }
        if(Input.GetKeyDown(KeyCode.Space)==true && birdIsAlive==true)
      { myRigidBody.linearVelocity = Vector2.up * flapStrength; }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive=false;
    }
}
