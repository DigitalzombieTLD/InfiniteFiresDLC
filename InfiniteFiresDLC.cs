using MelonLoader;
using UnityEngine;
using Il2CppInterop;
using Il2CppInterop.Runtime.Injection; 
using System.Collections;


namespace InfiniteFiresDLC
{
	public class InfiniteFiresDLCMain : MelonMod
	{
		public static int lastMsg = 0;

		public static string[] endlessTxt =
		{
            "The only way to put out this endless fire is with an endless supply of water, or a giant marshmallow.",
			"Someone call the fire department! Oh wait, they already gave up on this one.",
			"This fire is like a never-ending party, except it's not as fun and nobody brought marshmallows.",
			"This fire will burn till the end of time.",
			"If this fire were a person, it would be the Energizer Bunny's pyromaniac cousin.",
			"I'm starting to think this fire has a secret stash of lighter fluid somewhere.",
			"This fire is so stubborn, it makes a mule look like a pushover.",
			"I heard this fire once took on a firefighter in arm-wrestling and won.",
			"This fire is like a bad habit, it just won't go away no matter how hard you try.",
			"You know it's a serious fire when even the sun gets jealous of its brightness.",
			"This fire is like a never-ending romance novel, but without the happy ending.",
			"This fire is so bright, it could probably light up a black hole.",
			"I heard this fire once went on vacation to Antarctica just to cool off, but even that didn't work.",
			"It's like this fire has a vendetta against the world and won't stop until everything is ash.",
			"This fire is so intense, it could probably melt steel, and your dreams.",
			"I bet this fire is what hell looks like, but just a preview, before things get even worse.",
			"This fire is like a monster that just keeps growing and getting stronger, feeding off the destruction it creates.",
			"I heard this fire once made a deal with the devil, and even he's scared of it now.",
        };



		public override void OnInitializeMelon()
		{
            ClassInjector.RegisterTypeInIl2Cpp<AlternativeFireAction>();
        }

    }
}