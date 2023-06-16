using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] private float speed = 15;
    private Pleyer_Controller pc;
    private float leftBound = -15;
    private void Start()
    {
        pc = GameObject.Find("Farmer").GetComponent<Pleyer_Controller>();
    }
    void Update()
    {
        if (!pc.gameOver) { 
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if(transform.position.x < leftBound && gameObject.CompareTag("Obstacles"))
        {
            Destroy(gameObject);
        }
    }
}
