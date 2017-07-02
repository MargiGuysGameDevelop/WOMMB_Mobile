using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EffectLocation
{
    MeatBallSuit,
    Stage,
    Moster
}

public class EffectFactory : IInstantiateFactory
{
	private static EffectFactory instance;
	public static EffectFactory Instance{
		get{ if (instance == null)
				instance = new EffectFactory ();
			return instance;
		}
	}

    EffectLocation location = EffectLocation.MeatBallSuit;

    public GameObject CreateConnectionObject(string _name,EffectLocation _location,
        Vector3 _position,Quaternion _rotation) {

        _name = ResrouceFactory.EffectLocation + "/"+  _location.ToString() +"/"+ _name;

        return CreateConnectionObjectToScene(_name,_position,_rotation);
    }
    
}
