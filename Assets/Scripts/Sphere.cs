using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape {
    
    protected override void OnStart() {
        _name = "Sphere";
        _colorName = "Green";
        _material = transform.GetComponent<MeshRenderer>().material;
        _materialName = _material.name;
    }

    public override void DisplayText() {
        UIManager.Instance.DisplayText("This is the " + _name + " shape with the color " + _colorName + ". The material name is " + _materialName);
    }
}
