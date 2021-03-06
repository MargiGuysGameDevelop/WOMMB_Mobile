﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FigureFactory : IInstantiateFactory{

	private static FigureFactory instance;
	public static FigureFactory Instance{
		get{ if (instance == null)
			instance = new FigureFactory ();
			return instance;
		}
	}

    public enum FigureLocation {
        Orgin,
        MeatBall,
        Building,
        Other
    }
    public FigureLocation figureLocation = FigureLocation.Orgin;

    //沒路徑的
    public override GameObject CreateLocalObjectToScene(string _name)
    {
        return CreateLocalObjectToScene(_name, Vector3.zero, Quaternion.Euler(Vector3.zero));
    }

    public override GameObject CreateLocalObjectToScene(string _name, Vector3 _position)
    {
        return CreateLocalObjectToScene(_name,_position,Quaternion.Euler(Vector3.zero));
    }

    public override GameObject CreateLocalObjectToScene(string _name, Vector3 _position, Quaternion _rotation)
    {
        if (figureLocation != FigureLocation.Orgin) _name = figureLocation.ToString() + @"/" + _name;
        _name = ResrouceFactory.FigureLocation + _name;

        Debug.Log(_name);

		var nObject = ResrouceFactory.Instance.Instantiate(_name,_position,_rotation) as GameObject;
        nObject.transform.position = _position;
        nObject.transform.rotation = _rotation;
        return nObject;
    }


    //各資料夾底下的函式
    public GameObject CreateMeatBallToScene(Vector3 _postion,Quaternion _rotation)
    {
        figureLocation = FigureLocation.MeatBall;
        var _name = "MeatBall";
        return CreateLocalObjectToScene(_name, _postion,_rotation);
    }
    public GameObject CreateMeatBallToScene(string _name ,Vector3 _postion, Quaternion _rotation)
    {
        figureLocation = FigureLocation.MeatBall;
        return CreateLocalObjectToScene(_name, _postion, _rotation);
    }
}
