using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapController : MonoBehaviour
{
    public Animator anim;               //Reference to Vita's animator component
    public SwapTexture swapTexture;
    public SwapTextureShader swapTextureShader;

    private void OnGUI()
    {
        //Draws the UI button in the Scene
        //This is a great tool for a quick debug if your script doesn't work.
        //But for a more permanent UI button, I recommend using the UI gameObject instead.

        if (GUI.Button(new Rect(10, 10, 200, 50), "Switch Pose!"))
        {
            //Triggers the Animator's parameter to change the animation.
            //You can open up the Animator window to see how it is set up.

            anim.SetTrigger("SwitchPose");
  	        swapTexture.Invoke("swapTexture", 0.3f);
        }


        //A new button to swap Texture 2
        if (GUI.Button(new Rect(10, 70, 200, 50), "Switch Texture 2!"))
        {
            //Triggers the Animator's parameter to change the animation.
            //You can open up the Animator window to see how it is set up.
            swapTextureShader.swapTexture();
        }
    }
}