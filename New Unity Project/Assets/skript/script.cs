using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class script : MonoBehaviour {
	enum States 
	{
        kidnap,
		death,
		totrture,
		badEnd,
		goodEnd
	}
	States state = States.kidnap;
	public Text mainText;
	// Update is called once per frame
	void Update () {
		if (state == States.kidnap) 
		{
			Kidnap ();
		}
		if (state == States.death) 
		{
			Death();
		}
	}


	void Kidnap()
	{
		mainText.text = "Тебя схватили и закинули в багажник\n" + "(П)Попытаться збежать\n (Н)Ничего не делать";
		if (Input.GetKeyDown(KeyCode.G))
		{
			state = States.death;
		}
	
		if (Input.GetKeyDown (KeyCode.Y))
		{
			state = States.totrture;
		}

	}

	void Death()
	{
		mainText.text = "вы попытались збежать и вас убили.КОНЕЦ.\n(З)Заново.";
		if (Input.GetKeyDown(KeyCode.P))
		{
			state = States.kidnap;
		}

	}

}