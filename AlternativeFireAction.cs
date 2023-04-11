using AlternativeActionUtilities;
using Il2Cpp;
using MelonLoader;
using System;

namespace InfiniteFiresDLC
{
	public class AlternativeFireAction : AlternativeAction
	{
		public AlternativeFireAction(IntPtr intPtr) : base(intPtr) { }

		public override void ExecuteTertiary()
		{
            Fire fire = this.gameObject.GetComponent<Fire>();

            if (fire) fire.m_IsPerpetual = !fire.m_IsPerpetual;
            else
            {
                fire = this.gameObject.GetComponentInChildren<Fire>();
				if (fire)
				{
					fire.m_IsPerpetual = !fire.m_IsPerpetual;

					if(fire.m_IsPerpetual)
					{
						int random = UnityEngine.Random.Range(0, InfiniteFiresDLCMain.endlessTxt.Length - 1);

						while(random  == InfiniteFiresDLCMain.lastMsg)
						{
							random = UnityEngine.Random.Range(0, InfiniteFiresDLCMain.endlessTxt.Length - 1);
                        }

						InfiniteFiresDLCMain.lastMsg = random;

						HUDMessage.AddMessage(InfiniteFiresDLCMain.endlessTxt[random], 5f, true, false);
                    }
					else
					{
                        HUDMessage.AddMessage("The fire will now consume fuel", 3f, true, false);
                    }
				}
				else
				{
					MelonLoader.MelonLogger.Error("Attached object doesn't have a fire component.");
				}
            }
            
		
        }
	}
}
