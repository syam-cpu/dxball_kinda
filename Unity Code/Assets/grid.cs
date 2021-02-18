using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grid : MonoBehaviour
{
    float timer;
    // Vector3 startPos;
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
    // Vector3[] positionArray = new Vector3[16];
    // positionArray[0] = new Vector3(0.5f, 1.5f, 0);            
    // positionArray[1] = new Vector3(1.5f, 3.5f, 0);            
    // positionArray[2] = new Vector3(0.5f, 1.5f, 0);            
    // positionArray[3] = new Vector3(-0.5f, -1.5f, 0);            
    
    // positionArray[4] = new Vector3(1.5f, -0.5f, 0);
    // positionArray[5] = new Vector3(3.5f, -1.5f, 0);            
    // positionArray[6] = new Vector3(-1.5f, 0.5f, 0);            
    // positionArray[7] = new Vector3(-3.5f, 1.5f, 0);            
    
    // positionArray[8] = new Vector3(1.5f, 0.5f, 0);            
    // positionArray[9] = new Vector3(3.5f, 1.5f, 0);            
    // positionArray[10] = new Vector3(-1.5f, -0.5f, 0);            
    // positionArray[11] = new Vector3(-3.5f, -1.5f, 0);            
    // positionArray[12] = new Vector3(-0.5f, 1.5f, 0);            
    // positionArray[13] = new Vector3(-1.5f, 3.5f, 0);            
    // positionArray[14] = new Vector3(0.5f, -1.5f, 0);            
    // positionArray[15] = new Vector3(1.5f, -3.5f, 0);            

    int i = 0;

    void Start(){
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

    // IEnumerator follow(){
    //     foreach(Vector3 pos in positionArray){
    //         StartCoroutine(move(pos));
    //         yield return new WaitForSeconds(2);
    //     }
    // }

    // IEnumerator move(Vector3 dest){
    //     transform.position = dest;
    //     yield return null;
    // }

    // void RandomPosition()
    // {
    //     timer = Time.time;
    //     // startPos = transform.position;
    //     endPos = new Vector3(Random.Range(-10f, 10f), Random.Range(-5f, 5f), 0);
    // }

    // void Update()
    // {
    //     if (Time.time - timer > 1)
    //     {
    //         // RandomPosition();
    //         timer = Time.time;
    //         endPos = positionArray[i];
    //         i = (i+1)%2;
    //     }
    //     // transform.position = Vector3.Lerp(startPos, endPos, Time.time - timer);
    //     transform.position = endPos;
    // }

}
