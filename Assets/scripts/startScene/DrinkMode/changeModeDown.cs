using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class changeModeDown : MonoBehaviour
{

	private string[] drinkMode =
	{
		"Standard",
		"Pussy",
		"Krass"
	};

	public TextMeshPro txtDrinkMode;

	void OnMouseDown()
	{

		int mode = 0;

		switch (txtDrinkMode.text)
		{
			case "Standard":
				mode = 0;
				break;
			case "Pussy":
				mode = 1;
				break;
			case "Krass":
				mode = 2;
				break;
			default:
				mode = 0;
				break;
		}

		mode--;
		if(mode < 0)
		{
			mode = 2;
		}

		txtDrinkMode.text = drinkMode[mode]; 
	}
}
