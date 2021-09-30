using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity_Change : MonoBehaviour
{
    public ScreenOrientation or;
    // Start is called before the first frame update
    public string x;
    public string y;
    public bool soundActive= false;
    public AudioSource audioSource;
    void Start()
    {
        
    }

    void FixedUpdate(){
        // Vector3 movement = new Vector3 (Input.acceleration.x, 0.0f, 0.0f);
        //  rigidbody.velocity = movement * speed;
        x =Input.acceleration.x.ToString();
        y =Input.acceleration.y.ToString();
        float x_axis =Input.acceleration.x;
        float y_axis = Input.acceleration.y;
         if(Input.GetKey(KeyCode.W)){
            Physics2D.gravity =new Vector2(0,9.8f);
            playWaterSound();
        }
         if(Input.GetKey(KeyCode.S)){
            Physics2D.gravity =new Vector2(0,-9.8f);
            playWaterSound();
        }
         if(Input.GetKey(KeyCode.D)){
            Physics2D.gravity =new Vector2(9.8f,0);
            playWaterSound();
        }
         if(Input.GetKey(KeyCode.A)){
             playWaterSound();
            Physics2D.gravity =new Vector2(-9.8f,0);
            
        }

    //  if(Input.deviceOrientation ==DeviceOrientation.PortraitUpsideDown){
    //         Physics2D.gravity =new Vector2(0,9.8f);

    //     }
    //     else if(Input.deviceOrientation == DeviceOrientation.Portrait){
    //         Physics2D.gravity =new Vector2(0,-9.8f);
            
    //     }
    //     else if(Input.deviceOrientation ==DeviceOrientation.LandscapeRight){
    //         Physics2D.gravity =new Vector2(9.8f,0);
            
    //     }
    //     else if(Input.deviceOrientation ==DeviceOrientation.LandscapeLeft){
    //         Physics2D.gravity =new Vector2(-9.8f,0);
            
    //     }

    // testing water movement on phone movement
     if (!x.Equals("0") && !y.Equals("0")){
         
         if(Input.deviceOrientation ==DeviceOrientation.LandscapeRight){
            Physics2D.gravity =new Vector2(9.8f,0);
            playWaterSound();
        }else if(Input.deviceOrientation ==DeviceOrientation.LandscapeLeft){
            Physics2D.gravity =new Vector2(-9.8f,0);
            playWaterSound();
            }
         else if( (y_axis>-0.4 && x_axis <0.7f )|| (y_axis>-0.4 && x_axis>-0.7f) ){
            Physics2D.gravity =new Vector2(0,9.8f);
            playWaterSound();
        }
        else if(x_axis<0.7f && x_axis>-0.7f){
            Physics2D.gravity =new Vector2(0,-9.8f);
            playWaterSound();
        }
        else if(x_axis >0.7f){
            Physics2D.gravity =new Vector2(9.8f,0);
            playWaterSound();
        }
        else if(x_axis<-0.7f){
            Physics2D.gravity =new Vector2(-9.8f,0);
            playWaterSound();
        }
     }
    }
    // will play sound when the water moves
    void playWaterSound(){
        if(soundActive){
        float rad = Random.Range(1.0f,3.0f);
        audioSource.pitch=rad;
        audioSource.Play();
        }
    }
}
