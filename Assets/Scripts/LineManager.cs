﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineManager : MonoBehaviour {

	public GameObject linePrefab;
	public LineBehaviour activeLine;

	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			GameObject line = Instantiate (linePrefab);
			activeLine = line.GetComponent<LineBehaviour> ();
		}

		if (activeLine != null) {
			Vector2 mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			activeLine.updateLine (mousePosition);
		}

		if (Input.GetMouseButtonUp (0)) activeLine = null;
	}

}