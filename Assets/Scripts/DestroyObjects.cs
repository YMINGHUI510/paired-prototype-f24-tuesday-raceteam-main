using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjects : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnCollisionEnter(Collision collision){
        Destroy(this.gameObject);

    }
    
}
