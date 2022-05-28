using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HD.Singleton;

public class ObjectPool : TSingletonMonoBehavior<ObjectPool>
{
    public List<GameObject> pooledObjects;
    public GameObject objectToPool;
    //the number you need to generate
    public int amountToPool;

    public GameObject GetPooledObject(){
        for ( int i = 0; i < amountToPool; i++ ) {
            //Use it if you are not using it
            if(!pooledObjects[i].activeInHierarchy){
                return pooledObjects[i];
            }
        }
        return null;
    }

    void Awake()
    {
        pooledObjects = new List<GameObject>();
        GameObject tmp;
        //create Objects and add into  pooledObjects
        for(int i = 0; i < amountToPool; i++)
        {
            tmp = Instantiate(objectToPool);
            tmp.SetActive(false);
            pooledObjects.Add(tmp);     
        }              
    }
}
