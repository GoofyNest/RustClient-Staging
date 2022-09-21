public class SoundModifier : MonoBehaviour // TypeDefIndex: 10737
{
	[HideInInspector] 
	public Sound sound; 


	public virtual void Init(Sound targetSound) { }

	public virtual void ApplyModification() { }

	public virtual void OnSoundPlay() { }

	public void .ctor() { }

}

