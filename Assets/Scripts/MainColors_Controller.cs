using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class MainColors_Controller : MonoBehaviour
{
    [SerializeField] private Color lightColor;
    [SerializeField] private Color shadowColor;
    [SerializeField] private Material[] materials;
    [SerializeField] private Renderer[] meshRenderers;

    void Start()
    {
        meshRenderers = GetComponentInChildren<Renderer[]>();
        foreach (Renderer renderer in meshRenderers)
        {
            materials = renderer.sharedMaterials;
        }
    }

    void Update()
    {
        SetLightColor();
    }

    private void SetLightColor()
    {
        foreach (Material mat in materials)
        {
            mat.SetColor("_Light_Color", lightColor);
            mat.SetColor("_Shadows_Color", shadowColor);
        }
    }
}
