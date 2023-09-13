using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericSingleton<T>: MonoBehaviour where T : Component   // where t?  <t>??
{
    private string T _instance; //_why use?
    // Start is called before the first frame update
    public static T instance
    {
        get
        {
            if (_instance == null)
            { 
               if
            }
        }
    }
    void Start()
    {
        
    }
    public virtual Awake()
    {
        if (_instance == null)
        {
            _instance = this as T;    //? what is t?
            DontDestroyOnLoad(gameObject);
        }
        else if(_instance != this )
        {
            Destroy(gameObject);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
