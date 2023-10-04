using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDestroyed : MonoBehaviour
{
    // Start is called before the first frame update
    public int attackPoint = 10;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet")) // 플레이어와 충돌
        {
            collision.gameObject.GetComponent<BulletDestroyed>().PlayerDamaged(attackPoint);
            Destroy(this.gameObject);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
  
}
