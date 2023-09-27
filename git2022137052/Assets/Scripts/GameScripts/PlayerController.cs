using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 postion;
    public float Speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        postion.x += Speed * Time.deltaTime * Input.GetAxisRaw("Horizontal");
        postion.y += Speed * Time.deltaTime * Input.GetAxisRaw("Vertical");
        transform.position = postion;
    }
}
