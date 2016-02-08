using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {intro, cell, cell_1, box, box_throw, box_shake, toilet_0, tats_0, cell_box, cell_box_1, toilet_1, toilet_2, tats_1, fap, fap_1, freedom, lose};
	private States myState;
	//private enum Sprites {Tatt};
	//private Sprite Tatt;
	//test test

	// Use this for initialization
	void Start () {

		myState = States.intro;
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		print (myState);
		if      (myState == States.intro)       {intro ();}
		else if (myState == States.cell)        {cell ();}
		else if (myState == States.toilet_0)    {toilet_0 ();} 
		else if (myState == States.tats_0)      {tats_0 ();} 
		else if (myState == States.cell_box)    {cell_box ();} 
		else if (myState == States.cell_box_1)   {cell_box_1 ();} 
		else if (myState == States.toilet_1)    {toilet_1 ();} 
		else if (myState == States.toilet_2)    {toilet_2 ();}
		else if (myState == States.tats_1)      {tats_1 ();}
		else if (myState == States.freedom)     {freedom ();}
		else if (myState == States.cell_1)      {cell_1 ();}
		else if (myState == States.fap)         {fap ();}
		else if (myState == States.fap_1)       {fap_1 ();}
		else if (myState == States.box)         {box ();}
		else if (myState == States.box_throw)   {box_throw ();}
		else if (myState == States.box_shake)   {box_shake ();}
		else if (myState == States.lose)        {lose ();}


	
	}

	#region State handler methods

	void intro ()	{
		text.text = "What the actual Fuck. Where am I... Is this a drea.. Blur.. am I in a some sort of lab.. Vision is bluring. I cant move" +
					", but im going in and out of concieness. *Darkness* I need to wake up, but how?\n\n Find The key that wakes you up!\n\n Now!";
		if (Input.GetKeyDown(KeyCode.Tab)) {myState = States.cell;}
	}

	void cell ()
	{
		text.text = "You awake suddenly. Sweat dripping down your body. You become aware that you are in an unknown location. What do I re" +
		"member last, you think to yourself. Nothing. What is my name? Nothing. Where am I? With this realization you jump up and " +
		"look around. The room looks unfamilair to you. It seems like a jail cell with no bars.\n\n There is a metal bed, a toilet, " +
		"and what looks to be like a small box in the corner. The room is maybe 12ft by 12ft. There are no signs of any doors or windows. " +
		"Looking down at yourself, you realize that your body is covered with tatoos. Was I like this before, you think to yourself." +
		"What should I do... I definatley need to search the room in more detail. I guess my options are to: \n\n" +
		"Up arrow:    Inspect the toilet\n\n" +
		"Down arrow:  Inspect the small box\n\n" +
		"Left arrow:  Try to get a better look at these tatoos\n\n" +
		"Right arrow: Might as well FAP it";

		if 		(Input.GetKeyDown (KeyCode.UpArrow))        {myState = States.toilet_0;} 
		else if (Input.GetKeyDown (KeyCode.DownArrow)) 		{myState = States.box;}
		else if (Input.GetKeyDown (KeyCode.LeftArrow))  	{myState = States.tats_0;}
		else if (Input.GetKeyDown (KeyCode.RightArrow))     {myState = States.fap;}

	}

	void toilet_0 ()
	{
		text.text = "You approach the toilet and look in side. you see something insite the bowl that looks green and pointy. Did someone forget to flush?" +
		"\n\nUp arrow:    Inspect the toilet further?" +
		"\n\nDown arrow:  Return to roaming this cell";

		if 		(Input.GetKeyDown (KeyCode.UpArrow))        {myState = States.toilet_1;} 
		else if (Input.GetKeyDown (KeyCode.DownArrow))      {myState = States.cell_1;}
	}

	void tats_0 ()
	{
		//print (gameObject.Tatt);
		text.text = "You look down at your tatoos. Upon further inspection you realize that your whole body is covered with the same few symbols repeated." +
					" Its like someone copy and pasted the same tattoo all over my body... Is this some kind of cruel joke you think to yourself. The rep" +
			        "eating symbols are a box, an equal sign, and some symbol that ive never seen before: ☭.\n\nDown arrow:   Return to roaming cell";

		if 		(Input.GetKeyDown (KeyCode.DownArrow))     {myState = States.cell_1;}
	}

	void fap ()
	{
		text.text = "You look down at your flacid penis. It's been a while old friend you think, but you have no clue how long its actually been and you " +
					"dont really recognise it. Has it always leaned to the right? That seems wrong but I really dont have a way to verify that feeling " +
					"right now. You grab your penis and start stroking, and immediatly realize how wierd it is to be stroking a random cock you dont re" +
					"member." +
					"\n\nUp arrow:    Keep going this is kinda kinky" +
					"\n\nDown arrow:  Bail out and focus on whats improtant here";

		if 		(Input.GetKeyDown (KeyCode.UpArrow))        {myState = States.fap_1;} 
		else if (Input.GetKeyDown (KeyCode.DownArrow))      {myState = States.cell_1;}

	}

	void fap_1 ()
	{
		text.text = "You sick fuck.\n\n Press the down arrow now, so we can get back to our actual objective. Thanks! :)";

		if 		(Input.GetKeyDown (KeyCode.DownArrow))	    {myState = States.cell_1;}
	}

	void cell_1 ()
	{
		text.text = "Okay back to roaming! I feel an intense desire to get the fuck out of here.. Side thought though: Did I always swear this fucking much" +
					"? Hard to really tell with out any memories, but I'm sure this situation is a good time to start. Plus, there is no one here to" +
					" FUCKING offend.\n\n" +
					"Up arrow:    Inspect the toilet\n\n" +
					"Down arrow:  Inspect the small box\n\n" +
					"Left arrow:  Try to get a better look at these tatoos\n\n" +
					"Right arrow: Might as well FAP it";

		if 		(Input.GetKeyDown (KeyCode.UpArrow))        {myState = States.toilet_0;} 
		else if (Input.GetKeyDown (KeyCode.DownArrow)) 		{myState = States.box;}
		else if (Input.GetKeyDown (KeyCode.LeftArrow))      {myState = States.tats_0;}
		else if (Input.GetKeyDown (KeyCode.RightArrow))     {myState = States.fap;}
	}

	void cell_box ()
	{
		text.text = "YAY! I got my first item, I bet i'll level up soon at this rate! *do a little dance* *get schwifty* What do I do now?\n\n" +
					"Up arrow:    Throw the box\n\n" +
					"Down arrow:  Shake the small box\n\n" +
					"Right arrow: I still have more to explore, Ill deal with the box in a hot minute";

		if 		(Input.GetKeyDown (KeyCode.UpArrow))        {myState = States.box_throw;} 
		else if (Input.GetKeyDown (KeyCode.DownArrow))  	{myState = States.box_shake;}
		else if (Input.GetKeyDown (KeyCode.RightArrow)) 	{myState = States.cell_box_1;}
	}

	void box_throw ()
	{
		text.text = "You throw the box as hard as you can against the wall and hear a deafening shatter. Part of the cell wall that looked like " +
					"metal shattered like glass and exposed a barred door! You walk over to inspect it and to look for the box. The box looks like it" +
					" must have shattered as well and on the ground you see a key!!! This must have been what was in the box! You take the key out and" +
					" put it in the key whole. *Phew* perrfect fit I can finally get out of this hell whole.\n\n" +
					"Up arrow:   TURN THAT KEY!\n\n" +
					"Down arrow:  Do nothing (I want to rot in here)";

			if 		(Input.GetKeyDown (KeyCode.UpArrow))        {myState = States.freedom;}
			else if (Input.GetKeyDown (KeyCode.DownArrow)) 		{myState = States.lose;}
	}

	void box_shake ()
	{
		text.text = "*shake* *shake* *clink* *clank* *wank* There is definatly something in here. It sounds metal...\n\n" +
					"Up arrow:    Throw this box\n\n" +
					"Down arrow:  Do nothing (I want to rot in here)\n\n" +
					"Right arrow: I still have more to explore, Ill deal with the box in a hot minute";
		if 		(Input.GetKeyDown (KeyCode.UpArrow))        {myState = States.box_throw;} 
		else if (Input.GetKeyDown (KeyCode.DownArrow)) 		{myState = States.lose;}
		else if (Input.GetKeyDown (KeyCode.RightArrow)) 	{myState = States.cell_box_1;}
	}

	void lose ()
	{
		text.text = "Game Over Noob\n\n Press the F key to start over.\n\n Yes, the Fkey is for FAILURE.";
		if 		(Input.GetKeyDown (KeyCode.F))               {myState = States.intro;}
	}

	void cell_box_1 ()
	{
		text.text = "Ahh I guess, I'm the completionist type of person when it comes to video game... *cough* *cough* I mean real life. What else should I" +
					" explore?\n\n" +
					"Up arrow:    Toilet\n\n" +
					"Left arrow:  Tattoo\n\n" +
					"Right arrow: FAP";

		if 		(Input.GetKeyDown (KeyCode.UpArrow))         {myState = States.toilet_0;} 
		else if (Input.GetKeyDown (KeyCode.LeftArrow))  	 {myState = States.tats_0;}
		else if (Input.GetKeyDown (KeyCode.RightArrow))  	 {myState = States.fap;}

	}

	void box ()
	{
		text.text = "You approach the box cautiously and pick it up. It looks extremely well crafted. It looks like it could be made of wood but has no seams" +
					". Although, tapping the box makes a sound closer to tapping on glass or wood.\n\n Down arrow:  Collect item and return";
		if 		(Input.GetKeyDown (KeyCode.DownArrow))      {myState = States.cell_box;}
	}

	void toilet_1 ()
	{
		text.text = "Ooookay. Interesting choice I just made. Even surprised myself, but that is bound to happen since I dont know who the fuck I am. I am" +
					" actually approaching the green thing in the toilet to get a closer look.... And holy shit, it just moved. That the actual eff. It lo" +
					"oks like some sort of tail... This is weird..\n\n" +
					"Up arrow:    Grab the tail\n\n" +
					"Down arrow:  Back the fuck up";

		if 		(Input.GetKeyDown (KeyCode.DownArrow))      {myState = States.cell_1;}
		else if (Input.GetKeyDown (KeyCode.UpArrow))  		{myState = States.toilet_2;}
	}

	void toilet_2 ()
	{
		text.text = "You grab the tail in your hands and it starts to wiggle back and forth. For some unknown reason to you, you start to pull the tail! Pull" +
					"ing and pulling. How the hell long is this thing you think while your body is almost automatically continuing. Suddenly, the tail lashes" +
					" out and takes your feet out from under you. You fall to the ground with a loud *thud* Then, it starts to come out on its own. With wat" +
					"er spashing in your eyes you can't see for a second but your start crawling back wards to the oposite end of the cell. You wipe the wat" +
					"er from your eyes and for the first time get a look at this huge creature. It was about this time that you realize the creature was 8 s" +
					"tories tall and a crustation from the paleolithic era. It stands over you looking down with its big red eyes. \"WHAT DO YOU WANT FROM" +
					" ME MONSTER?\" you yell at the top of your lungs. The monster bends down and looks you straight in the eye and says \"I need about" +
					" tree fiddy.\" Shouting back at it you yell \"I AINT GIVING YOU NO TREE FIDDY YOU GOD DAMN LOCHNESS MONSTER. GET YOUR OWN GOD DAMN" +
					" MONEY!\" Without skipping a beat it shreaks and, just as quick as it came, crawled back into the toilet. What the actual eff.\n\n" +
					"Down arrow:   Return to roaming";

		if 		(Input.GetKeyDown (KeyCode.DownArrow))     {myState = States.cell_1;}

	}

	void tats_1 ()
	{
		text.text = "tats 1";
	}

	void freedom ()
	{
		text.text = "Bright light.. Where was this cell even located? When your eyes finally adjust to the light you see...baloons?\n\n" +
					"SURPRISE!! HAPPY BIRTHDAY JOHN!! There are alot of people there that you recognise! One of them approaches you. You think" +
					" his name is Jerry but your memories are only slowly coming back. He comes up to you and pats you on the back. \"How did" +
					" you like your gift, John? It was one of those hard core escape the room experiences. We kinda had to kid nap you to make" +
					" it a surprise. Here, have some cake!\n\n Classic mother fucking Jerry you think to yourself and grab that peice of cake." +
					"\n\nGood thing I didn't fap it will all these people watching you think to yourself.\n\nfin";
	}
	#endregion			
}
