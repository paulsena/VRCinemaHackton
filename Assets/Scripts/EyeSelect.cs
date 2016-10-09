﻿using UnityEngine;
using System.Collections;
using UnityStandardAssets.ImageEffects;

public class EyeSelect : ButtonFunction {


	public override void Function(){
		Debug.Log ("Eye Select Called");

		var leftCamObj = GameObject.Find("Left Eye").gameObject;
		var leftCam = leftCamObj.GetComponent<Camera>();
		var leftBlur = (BlurOptimized)leftCam.GetComponent(typeof(BlurOptimized));
		var leftContrast = (ContrastStretch)leftCam.GetComponent(typeof(ContrastStretch));

		var rightCamObj = GameObject.Find ("Right Eye").gameObject;
		var rightCam = rightCamObj.GetComponent<Camera>();
		var rightBlur = (BlurOptimized)rightCam.GetComponent(typeof(BlurOptimized));
		var rightContrast = (ContrastStretch)rightCam.GetComponent(typeof(ContrastStretch));

		if (leftBlur.enabled) {
			leftBlur.enabled = false;
			rightBlur.enabled = true;
		} else if (rightBlur.enabled) {
			rightBlur.enabled = false;
			leftBlur.enabled = true;
		} else if (leftContrast.enabled) {
			leftContrast.enabled = false;
			rightContrast.enabled = true;
		} else if (rightContrast.enabled) {
			rightContrast.enabled = false;
			leftContrast.enabled = true;
		}
	}
}
