public class MusicClip : ScriptableObject // TypeDefIndex: 10706
{
	public AudioClip audioClip; 
	public int lengthInBars; 
	public int lengthInBarsWithTail; 
	public List<float> fadeInPoints; 


	public float GetNextFadeInPoint(float currentClipTimeBars) { }

	public void .ctor() { }

}

