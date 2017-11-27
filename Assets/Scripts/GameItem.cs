using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameItem 
{
	private string itemName;

	public GameItem (string itemName)
		{
			this.itemName = itemName;
		}

	public string GameItemName() {
			return this.itemName;

		}
	}