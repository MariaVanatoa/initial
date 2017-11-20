﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonController : MonoBehaviour,IPointerDownHandler,IPointerUpHandler {

	public bool buttonPressed = false;

	public bool GetButtonPressed () {
		return buttonPressed;
	}

	public void OnPointerDown (PointerEventData eventData) {
		//Debug.Log (eventData);
		buttonPressed = true;

	}
	public void OnPointerUp (PointerEventData eventData) {
		buttonPressed = false;

	}
}
