using UnityEngine;
using System.Collections;

public class ObstacleWhiteController : ObstacleController {

	void Start ()
	{
		generator = FindObjectOfType (typeof(GenerateWhite)) as GenerateWhite;
		speed = GameManager.getScrollSpeed () / 10f;
	}

	protected override void Clean(){
		Destroy(this.gameObject);	
	}

}
