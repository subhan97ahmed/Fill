using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer sr;
    public Material m;
    public Color c;
    public GameObject ob;
    void Start()
    {
        sr=gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other) {
        // sr.Color = #
    }
}
