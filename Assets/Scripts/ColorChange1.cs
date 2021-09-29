using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange1 : MonoBehaviour
{
     // Start is called before the first frame update
    public SpriteRenderer sr;
    public Material m;
    public Color[] Colors;
    int rand;
    void Start()
    {
        sr=gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other) {
        // if(other.gameObject.CompareTag("wall")){
        //     rand = Random.Range(0, Colors.Length);
        //     m.color =Colors[rand];
        // }
        if(other.gameObject.CompareTag("Particle")){
            rand = Random.Range(0, Colors.Length);
            sr.color = Colors[rand];
        }
    }
}
