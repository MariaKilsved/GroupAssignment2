using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment2
{
	public enum PlayingCardColor
	{
		Clubs = 0, Diamonds, Hearts, Spades         // Poker suit order, Spades highest
	}
	public enum PlayingCardValue
	{
		Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten,
		Knight, Queen, King, Ace                // Poker Value order
	}
	public class PlayingCard
	{
		public PlayingCardColor Color { get; init; }
		public PlayingCardValue Value { get; init; }

		public string BlackOrRed
		{
			get
			{
				if (Color == PlayingCardColor.Clubs || Color == PlayingCardColor.Spades)
					return "Black";

				return "Red";
			}
		}
		
		/// <summary>
		/// Returns "Face" for Ace,Knight, Queen, King. Otherwise it returns "Value".
		/// 
		/// </summary>
		string FaceOrValue
		{
			get
			{
				switch((int)Value)
                {
					case > 10:
							return "Face";
					default:
						return "Value";
				}
			}
		}
		public override string ToString() => $"{Value} of {Color}, a {BlackOrRed} {FaceOrValue} card";

		/// <summary>
		/// Constructor that generates a random card
		/// </summary>
		public PlayingCard()
		{
			var generator = new Random();
			int color_id = generator.Next(0, 4);
			int value_id = generator.Next(2, 15);

			this.Color = (PlayingCardColor)color_id;
			this.Value = (PlayingCardValue)value_id;
		}

		public PlayingCard(PlayingCardColor color, PlayingCardValue value)
		{
			this.Color = color;
			this.Value = value;
		}

	}
}
