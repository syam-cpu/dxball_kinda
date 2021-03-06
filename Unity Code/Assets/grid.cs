using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grid : MonoBehaviour
{
    // float timer;
    Vector3 endPos;

    int i = 0;
    bool[] boolarr = new bool[16];

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
           

    void Start(){
        Debug.Log("VFT has started");
        endPos = new Vector3(0,0,0);
        transform.position = endPos;
        StartCoroutine("follow");
    }

    void Update() {
        if ((Input.GetKeyDown(KeyCode.S)) ){ 
            boolarr[i] = true; 
            Debug.Log("click simulated on i = " + i);
        }
    }
    IEnumerator follow(){
        foreach(Vector3 pos in positionArray){
            yield return StartCoroutine(move(pos));
            i++;
        }
        yield return StartCoroutine("endtest");
    }

    IEnumerator move(Vector3 dest){
        transform.position = dest;
        yield return new WaitForSeconds(2);
    }

    IEnumerator endtest() {
        Debug.Log("VFT has ended");
        foreach(bool x in boolarr){
            Debug.Log(x);
        }
        yield return new WaitForSeconds(0.01f);
    }
}
