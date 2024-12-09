using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorGradient : MonoBehaviour
{
    public Material Render;
    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, Render);
    }
}
