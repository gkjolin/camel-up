﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaces : MonoBehaviour {
	public static BoardSpace[] spaces = new BoardSpace[16];

	public static void addCamel(string toAdd, int pos) {
		GameObject g = GameObject.Find (toAdd);
		Camel c = (Camel)g.GetComponent (typeof(Camel));
		int toRem = c.getPos ();
	
		if ((spaces[toRem].getCamelOnSpaces()).Contains (toAdd)) {
			spaces [toRem].removeCamel(toAdd);
		}
		spaces [pos].addCamel (toAdd);
		c.updatePos (pos);
	}
	public static void setUpBoard() {
		int count = 0;
		//set up count
		for (int i = 4; i <= 12; i += 4) {
			spaces [count] = new BoardSpace((new Vector3 (i, 0.5f, 3)));
			count++;
		}
		for (int i = -1; i >= -13; i += -4) {
			spaces [count] = new BoardSpace((new Vector3 (12, 0.5f, i)));
			count++;
		}
		for (int i = 8; i >= -4; i -= 4) {
			spaces [count] = new BoardSpace((new Vector3 (i, 0.5f, -13)));
			count++;
		}
		for (int i = -9; i <= 3; i += 4) {
			spaces [count] = new BoardSpace(new Vector3 (-4, 0.5f, i));
			count++;
		}
		spaces [15] = new BoardSpace(new Vector3 (0, 0.5f, 3));

		List<string> camels = new List<string>{ "green_camel", "yellow_camel", "orange_camel", "white_camel", "blue_camel" };
		for (int i = 0; i < 5; i++) {
			int index = Random.Range (0, camels.Count);
			addCamel(camels [index], Random.Range(0,3));

			camels.Remove (camels [index]);
		}



		Camel.stackCamels ();
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}