using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public static class LevelManager
{
	private static string lastLevel;
	
	public static void setLastLevel(string level)
	{
		lastLevel = level;
	}
	
	public static string getLastLevel()
	{
		return lastLevel;
	}
	
	public static void changeToPreviousLvl()
	{
		Application.LoadLevel(lastLevel);
	}




}







