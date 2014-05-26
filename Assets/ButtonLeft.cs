using UnityEngine;
using System.Collections;

public class ButtonLeft : MonoBehaviour
{
	public Color defaultColour;
	public Color selectedColour;
	public bool left = false;
	private Material mat;

	void OnTouchDown()
	{
		mat = renderer.material;
	}

	void OnTouchUp()
	{
		mat.color = defaultColour;
		left = false;
	}

	void OnTouchStay()
	{
		mat.color = selectedColour;
		left = true;
	}

	void OnTouchExit()
	{
		mat.color = defaultColour;
		left = false;
	}
}
