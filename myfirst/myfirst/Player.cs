using System;

namespace myfirst
{
	public class Player
	{
		//positions
		public int x = 5;
		public int y = 10;
		public int speed = 0;
			
		//crap
		public int ammo = 30;
		
		public int score = 0;
		
		
		public Player()
		{
			//player stuff
		}
		
		public void SetSpeed()
		{
			speed = 0.5;
		}
		
		public int GetXPos()
		{
			return x;
		}
		
		public int GetYPos()
		{
			return y;
		}
		
		public int GetScore()
		{
			return score;
		}
			
	}
}

