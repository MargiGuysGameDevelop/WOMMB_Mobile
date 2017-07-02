using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 應該要刪掉
/// </summary>
public class WOMMFactory{

    private static UIFactory myUIFactory = null;
    private static FigureFactory myFigureFactory = null;

    public static FigureFactory GetFigureFactory() {
        if (myFigureFactory == null)
            myFigureFactory = new FigureFactory();
        return myFigureFactory;
    }

    public static UIFactory GetUIFactory()
    {
        if (myUIFactory == null)
            myUIFactory = new UIFactory();
        return myUIFactory;
    }

	public static void ClearCache()
	{
		
	}

}
