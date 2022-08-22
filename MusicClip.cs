public class MusicClip : ScriptableObject // TypeDefIndex: 9001
{	// Fields
	public AudioClip audioClip; // 0x18
	public int lengthInBars; // 0x20
	public int lengthInBarsWithTail; // 0x24
	public List<float> fadeInPoints; // 0x28

	// Methods

	// RVA: 0x7BE070 Offset: 0x7BC670 VA: 0x1807BE070
	public float GetNextFadeInPoint(float currentClipTimeBars) { }

	// RVA: 0x7BE1C0 Offset: 0x7BC7C0 VA: 0x1807BE1C0
	public void .ctor() { }

}

