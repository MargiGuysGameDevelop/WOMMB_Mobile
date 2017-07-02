using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptableObjectFactory : IObjectFactory
{
	private static ScriptableObjectFactory instance;
	public static ScriptableObjectFactory Instance{
		get{ if (instance == null)
			instance = new ScriptableObjectFactory ();
			return instance;
		}
	}

    public AttactionData GetAttackDataByName(string _name) {
        return LoadObject(_name) as AttactionData;
    }

    public override GameObject Instantiate(string _name, Vector3 _position, Quaternion _rotation)
    {
        throw new NotImplementedException();
    }
}
