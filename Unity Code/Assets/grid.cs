using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grid : MonoBehaviour
{
    float timer;
    Vector3 endPos;

    Vector3[] positionArray = new [] { 
        new Vector3(0.5f, 1.5f, 0), 
        new Vector3(1.5f, 3.5f, 0), 
        new Vector3(0.5f, 1.5f, 0),            
        new Vector3(-0.5f, -1.5f, 0),            
        
        new Vector3(1.5f, -0.5f, 0),
        new Vector3(3.5f, -1.5f, 0),            
        new Vector3(-1.5f, 0.5f, 0),            
        new Vector3(-3.5f, 1.5f, 0),            
        
        new Vector3(1.5f, 0.5f, 0),            
        new Vector3(3.5f, 1.5f, 0),            
        new Vector3(-1.5f, -0.5f, 0),            
        new Vector3(-3.5f, -1.5f, 0),            
        new Vector3(-0.5f, 1.5f, 0),            
        new Vector3(-1.5f, 3.5f, 0),            
        new Vector3(0.5f, -1.5f, 0),            
        new Vector3(1.5f, -3.5f, 0)
    };
           

    // int i = 0;

    void Start(){
        Debug.Log("VFT has started");
        endPos = new Vector3(0,0,0);
        transform.position = endPos;
        StartCoroutine("follow");
    }

    IEnumerator follow(){
        foreach(Vector3 pos in positionArray){
            yield return StartCoroutine(move(pos));
        }
    }

    IEnumerator move(Vector3 dest){
        transform.position = dest;
        yield return new WaitForSeconds(5);
    }


}
