public class MusicClip : ScriptableObject // TypeDefIndex: 9001
{	// Fields
	public AudioClip audioClip; // 0x18
	public int lengthInBars; // 0x20
	public int lengthInBarsWithTail; // 0x24
	public List<float> fadeInPoints; // 0x28

	// Methods

	// RVA: 0x7BDF60 Offset: 0x7BC560 VA: 0x1807BDF60
	public float GetNextFadeInPoint(float currentClipTimeBars) { }

	// RVA: 0x7BE0B0 Offset: 0x7BC6B0 VA: 0x1807BE0B0
	public void .ctor() { }

}

