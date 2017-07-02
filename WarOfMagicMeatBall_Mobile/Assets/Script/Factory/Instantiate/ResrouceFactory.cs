using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResrouceFactory  :IObjectFactory {

	private static ResrouceFactory instance;
	public static ResrouceFactory Instance{
		get{ if (instance == null)
			instance = new ResrouceFactory ();
			return instance;
		}
	}

    //Resource
    public static string UILocation = @"Prefab/UI/";
    public static string FigureLocation = @"Prefab/Figure/";
    public static string EffectLocation = @"Prefab/Effect";


    public override GameObject Instantiate(string _name, Vector3 _position, Quaternion _rotation)
    {
        return GameObject.Instantiate(Resources.Load(_name),_position,_rotation) as GameObject;
    }
}
