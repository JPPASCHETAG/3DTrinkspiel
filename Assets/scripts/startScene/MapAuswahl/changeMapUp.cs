using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class changeMapUp : MonoBehaviour
{
	private string[] drinkMode =
	{
		"Strand",
		"Insel"
	};
	public TextMeshPro txtDrinkMode;

	void OnMouseDown()
	{
		int mode = 0;

		switch (txtDrinkMode.text)
		{
			case "Strand":
				mode = 0;
				break;
			case "Insel":
				mode = 1;
				break;
			default:
				mode = 0;
				break;
		}

		mode++;
		if (mode > 1)
		{
			mode = 0;
		}

		txtDrinkMode.text = drinkMode[mode];
	}
}
