public class MusicClip : ScriptableObject // TypeDefIndex: 10717
{
	public AudioClip audioClip; 
	public int lengthInBars; 
	public int lengthInBarsWithTail; 
	public List<float> fadeInPoints; 


	public float GetNextFadeInPoint(float currentClipTimeBars) { }

	public void .ctor() { }

}

