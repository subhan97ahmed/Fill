using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gravity_Change : MonoBehaviour
{
    public ScreenOrientation or;
    // Start is called before the first frame update
    public string x;
    public string y;
    void Start()
    {

    }

    void FixedUpdate()
    {
        // Vector3 movement = new Vector3 (Input.acceleration.x, 0.0f, 0.0f);
        //  rigidbody.velocity = movement * speed;
        x = Input.acceleration.x.ToString();
        y = Input.acceleration.y.ToString();
        float x_axis = Input.acceleration.x;
        float y_axis = Input.acceleration.y;
        // for restarting 
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (Input.GetKey(KeyCode.W))
        {
            Physics2D.gravity = new Vector2(0.0f, 9.8f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Physics2D.gravity = new Vector2(0.0f, -9.8f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Physics2D.gravity = new Vector2(9.8f, 0.0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Physics2D.gravity = new Vector2(-9.8f, 0.0f);
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
        //  if (!x.Equals("0") && !y.Equals("0")){

        //      if(Input.deviceOrientation ==DeviceOrientation.LandscapeRight){
        //         Physics2D.gravity =new Vector2(9.8f,0);
        //     
        //     }else if(Input.deviceOrientation ==DeviceOrientation.LandscapeLeft){
        //         Physics2D.gravity =new Vector2(-9.8f,0);
        //     
        //         }
        //      else if( (y_axis>-0.4 && x_axis <0.7f )|| (y_axis>-0.4 && x_axis>-0.7f) ){
        //         Physics2D.gravity =new Vector2(0,9.8f);
        //     
        //     }
        //     else if(x_axis<0.7f && x_axis>-0.7f){
        //         Physics2D.gravity =new Vector2(0,-9.8f);
        //     
        //     }
        //     else if(x_axis >0.7f){
        //         Physics2D.gravity =new Vector2(9.8f,0);
        //     
        //     }
        //     else if(x_axis<-0.7f){
        //         Physics2D.gravity =new Vector2(-9.8f,0);
        //     
        //     }
        //  }
    }
    // will play sound when the water moves
}
