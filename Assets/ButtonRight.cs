using UnityEngine;
using System.Collections;

public class ButtonRight : MonoBehaviour
{
	public Color defaultColour;
	public Color selectedColour;
	public bool right = false;
	private Material mat;
	
	void OnTouchDown()
	{
		mat = renderer.material;
	}
	
	void OnTouchUp()
	{
		mat.color = defaultColour;
		right = false;
	}
	
	void OnTouchStay()
	{
		mat.color = selectedColour;
		right = true;
	}
	
	void OnTouchExit()
	{
		mat.color = defaultColour;
		right = false;
	}
}
