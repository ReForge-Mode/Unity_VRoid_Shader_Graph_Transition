using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapTexture : MonoBehaviour
{
    public int textureIndex = 1;

    public Swappable[] swappableList;       //Array is more optimized than Lists

    [System.Serializable]
    public struct Swappable
    {
        public string name;
        public Material mat;
        public Texture texture1;
        public Texture texture2;
    }

    public void swapTexture()
    {
        //State 1: Change Texture 1 to Texture 2
        if (textureIndex == 1)
        {
            foreach (var item_swap in swappableList)
            {
                item_swap.mat.SetTexture("_MainTex", item_swap.texture2);
                item_swap.mat.SetTexture("_ShadeTexture", item_swap.texture2);
            }

            textureIndex = 2;
        }

        //State 2: Change Texture 2 to Texture 1
        else if (textureIndex == 2)
        {
            foreach (var item_swap in swappableList)
            {
                item_swap.mat.SetTexture("_MainTex", item_swap.texture1);
                item_swap.mat.SetTexture("_ShadeTexture", item_swap.texture1);
            }

            textureIndex = 1;
        }
    }

    private void OnApplicationQuit()
    {
        if (textureIndex == 2)
            swapTexture();
    }
}