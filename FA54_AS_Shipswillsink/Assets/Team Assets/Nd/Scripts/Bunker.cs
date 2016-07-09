﻿using UnityEngine;
using System.Collections;

public class Bunker : MonoBehaviour {

	public string name;
	public int length;
	public int hitpoints;
	public bool horizontal;
	public int x;
	public int y;
	public bool destroyed;


	public Bunker(string newName, int newLength, bool newHorizontal, int newX, int newY, bool newDestroyed)
	{
		name = newName;
		length = newLength;
		hitpoints = length;
		horizontal = newHorizontal;
		x = newX;
		y = newY;
		destroyed = newDestroyed;
	}

}