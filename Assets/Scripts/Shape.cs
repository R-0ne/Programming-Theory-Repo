using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour {
    protected string _name { get; set;  }
    protected string _colorName { get; set; }
    protected Material _material { get; set; }
    protected string _materialName { get; set; }


    protected void Start() {
        OnStart();
    }

    protected abstract void OnStart();
    
    public virtual void DisplayText() {
        UIManager.Instance.DisplayText("This is the shape class.");
    }
}

