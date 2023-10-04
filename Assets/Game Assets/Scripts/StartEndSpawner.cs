using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class StartEndSpawner : MonoBehaviour
{
    public GameObject LiquidParticles = null;
    public GameObject CompleteTrigger = null;
    public float Buffer=0;
    private float MinX,MaxX,MinY,MaxY;
    // y=-4to 4
    // x=2to -2 
    void Start()
    {
        SetMinMax();
        SpawnObj();
        // CompleteTrigger.gameObject.SetActive(true);
        // LiquidParticles.gameObject.SetActive(true);
    }

    private void SetMinMax(){
        Vector2 Bounds =Camera.main.ScreenToWorldPoint(new Vector2(Screen.width,Screen.height));
        MinX= -Bounds.x+Buffer;
        MaxX =Bounds.x-Buffer;
        MinY=-Bounds.y+Buffer;
        MaxY=Bounds.y-Buffer;

    }
    private void SpawnObj(){
        // int NumberOfObj = Random
        Vector2 Pos = new Vector2(Random.Range(MinX,MaxX),Random.Range(MinY,MaxY));
        GameObject obj =Instantiate(LiquidParticles,Pos,Quaternion.identity);
        obj.gameObject.SetActive(true);
         Pos = new Vector2(Random.Range(MinX,MaxX),Random.Range(MinY,MaxY));
        GameObject obj2 =Instantiate(CompleteTrigger,Pos,Quaternion.identity);
        obj2.gameObject.SetActive(true);

    }
}
