using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGeneration : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] objects;
    public float[] rotation;
    void Start()
    {

        int ran = Random.Range(0,objects.Length);
        int ran2 =Random.Range(0,rotation.Length);

        Instantiate(objects[ran],transform.position,Quaternion.Euler(0.0f,0.0f,rotation[ran2]));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
