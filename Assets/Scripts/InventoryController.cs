using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

	public class InventoryController : MonoBehaviour {

		//private Button changeTextButton;

		private Button showInv;
		private Text lista;
		private Button item1;
		private Button item2;
		private Button item3;
		private Dictionary<Button, GameItem> buttonItemMap = new Dictionary<Button, GameItem>();
		private Player p1 = new Player ();

		//public Button bCloseInv;
		//TODO: create player object
		//private Text statusText;


		// Use this for initialization


		void Start () {

			//Hides the inventory list if inventory list is active
			this.lista = GameObject.Find ("List").GetComponent<Text> ();
			{
				if (lista.isActiveAndEnabled == true) {
					lista.gameObject.SetActive (false);
				}
			}

			this.item1 = GameObject.Find ("ButtonKey").GetComponent<Button> ();
			this.item2 = GameObject.Find ("ButtonScrewdriver").GetComponent<Button> ();
			this.item3 = GameObject.Find ("ButtonKnife").GetComponent<Button> ();
			this.showInv = GameObject.Find ("ShowInv").GetComponent<Button> ();

			buttonItemMap.Add (item1, new GameItem ("Key"));
			buttonItemMap.Add (item2, new GameItem ("Screwdriver"));
			buttonItemMap.Add (item3, new GameItem ("Knife"));

			item2.onClick.AddListener (() => ButtonCollectItemClicked (item2));
			item1.onClick.AddListener (() => ButtonCollectItemClicked (item1));
			item3.onClick.AddListener (() => ButtonCollectItemClicked (item3));

			item2.onClick.AddListener (() => ChangeList ("banaani, "));
			item1.onClick.AddListener (() => ChangeList ("omena, "));
			item3.onClick.AddListener (() => ChangeList ("kirsikka, "));

			showInv.onClick.AddListener (() => ShowFruits ());

			//bCloseInv = GameObject.Find ("ButtonClose").GetComponent<Button> ();
			//this.bCloseInv.onClick.AddListener(TaskOnClick);

			//TODO: add buttonlisteners
			//this.statusText = GameObject.Find ("TextStatus").GetComponent<Text> ();
			//Debug.Log ("textStatus");
			//changeTextButton.onClick.AddListener (() => ButtonClicked("kikkeliskokkelis"));

		}


		/*void TaskOnClick (){
		Debug.Log("You have clicked the button!");
	}*/

		/// <summary>
		/// Buttons the collect item clicked.
		/// </summary>
		/// <param name="button">Button.</param>
		void ButtonCollectItemClicked(Button button){
			p1.AddItem (buttonItemMap [button]);
			p1.GetItems ();
			if (button.isActiveAndEnabled == true)
			{
				button.gameObject.SetActive (false);
			}
			//statusText.text = word;
			//Debug.Log ("Button clicked" + word);
		}
		/// <summary>
		/// Changes the list.
		/// </summary>
		/// <param name="fruit">Fruit.</param>
		void ChangeList(string fruit) {
			this.lista.text = p1.GetItems ();

		}

		//Shows the inventory list when button Inventory is clicked
		/// <summary>
		/// Shows the fruits.
		/// </summary>
		void ShowFruits(){
			p1.ShowInv ();
			if (lista.isActiveAndEnabled == false)
			{
				lista.gameObject.SetActive (true);
			}
		}


	}

