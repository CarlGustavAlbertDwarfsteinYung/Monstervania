using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game : MonoBehaviour {
	public static bool start = false;
	public static bool defeat = false;
	public static GameObject player_o;
	public static GameObject flying_enemy_o;

	public static GameObject map;

	bool menu = true;
	//GameObject screen1_title_o;
	//GameObject screen1_description_o;
	GameObject game_title_o;
	GameObject start_b;
	GameObject quit_b;
	public static GameObject timer_label_o;
	public static GameObject endgame_label_o;

	public static GameObject dialogue_o;

	AudioSource music;

	void Start() {
		player_o = GameObject.Find("player");
		player_o.SetActive(false);

		flying_enemy_o = GameObject.Find("flying_enemy");
		flying_enemy_o.SetActive(false);
		map = GameObject.Find("map");

		game_title_o = GameObject.Find("game_title");
		start_b = GameObject.Find("start_b");
		quit_b = GameObject.Find("quit_b");
		timer_label_o = GameObject.Find("timer_label");
		timer_label_o.SetActive(false);
		//screen1_title_o = GameObject.Find("screen1_title");
		//screen1_title_o.SetActive(false);
		//screen1_description_o = GameObject.Find("screen1_description");
		//screen1_description_o.SetActive(false);
		endgame_label_o = GameObject.Find("endgame_label");
		endgame_label_o.SetActive(false);

		music = GameObject.Find("camera").GetComponent<AudioSource>();
		dialogue_o = GameObject.Find("dialogue");
		dialogue_o.SetActive(false);
	}

	public void start_game() {
		//start = true;

		player_o.SetActive(true);
		timer_label_o.SetActive(true);
		//screen1_title_o.SetActive(true);
		//screen1_description_o.SetActive(true);

		game_title_o.SetActive(false);
		start_b.SetActive(false);
		quit_b.SetActive(false);

		dialogue_o.SetActive(true);

		music.Stop();

		dialogue.full_text = "I see the village burning! Must get there. No time to waste!";
		dialogue.delay = 420;
	}

	void FixedUpdate() {
		if (dialogue_o.activeSelf && dialogue.delay == 0 && !start) {
			start = true;
		}

		if (start) {
			if(Input.GetKeyDown(KeyCode.Escape)) {
				menu = !menu;
			}
		}
	}

}
