using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleController : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Singleton.Instance.InscreanScore(10);   
    }
    //  import instance instance sceor funtion     how? is there notting to import class?

    // Update is called once per frame
    void Update()
    {
        
    }
}
