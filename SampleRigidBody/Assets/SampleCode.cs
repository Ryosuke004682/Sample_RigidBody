using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleCode : MonoBehaviour
{
   public  Vector4 position = new(1,5,1 ,0);

    private void Start()
    {
        
    }

    private void Update()
    {
        transform.position = position;
    }

}
