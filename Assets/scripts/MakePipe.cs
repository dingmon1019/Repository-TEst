using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
   public GameObject pipe;
   float timer = 0;
   public float timedeff;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       timer+= Time.deltaTime;
       if(timer >timedeff)
       {
        GameObject newpipe = Instantiate(pipe);   
        newpipe.transform.position= new Vector3(2.5f,Random.Range(-1.1f,5.5f),0);
        timer= 0;
        Destroy(newpipe,8.0f);
       }
    }

    
}
