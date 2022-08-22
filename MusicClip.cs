public class MusicClip : ScriptableObject // TypeDefIndex: 9001
{	// Fields
	public AudioClip audioClip; // 0x18
	public int lengthInBars; // 0x20
	public int lengthInBarsWithTail; // 0x24
	public List<float> fadeInPoints; // 0x28

	// Methods

	// RVA: 0x7DC460 Offset: 0x7DAA60 VA: 0x1807DC460
	public float GetNextFadeInPoint(float currentClipTimeBars) { }

	// RVA: 0x7DC5B0 Offset: 0x7DABB0 VA: 0x1807DC5B0
	public void .ctor() { }

}

