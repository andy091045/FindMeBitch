using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCManager : MonoBehaviour
{
    public int amountToPool;
    //put in randomly generated boundaries
    public Transform Up;
    public Transform Left;
    public Transform Down;
    public Transform Right;
    //l is in order to prevent the generated object from hitting the wall, it needs to be generated inside the wall
    float l = 1.0f;
    Vector3 StartPosition;
 
    // Start is called before the first frame update
    void Start()
    {      
        for (int i = 0; i < amountToPool; i++)
        {
            StartPosition = new Vector3(Random.Range(Left.position.x + l , Right.position.x - l), Random.Range(Down.position.y+l, Up.position.y-l), 0);
            GameObject NPC = ObjectPool.Instance.GetPooledObject();            
            NPC.transform.position  = StartPosition;            
            NPC.SetActive(true);
        }
    }
}
