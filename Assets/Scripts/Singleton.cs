using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Component
{
    /*
     * This is the Singleton class we can use it in another classes
     * T is the generic of our singleton.
     */
    private static T instance;
    public static T Instance
    {
        //getter returns the generic object
        get
        {
            if(instance== null)
            {
                instance = FindObjectOfType<T>();
                if (instance == null)
                {
                    GameObject obj = new GameObject();
                    instance = obj.AddComponent<T>();
                }
            }
            return instance;
        }
    }
    protected virtual void Awake()
    {
        //initialize itself as a singleton
        instance = this as T;
    }
}
