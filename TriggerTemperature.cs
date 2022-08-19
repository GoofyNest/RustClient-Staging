public class TriggerTemperature : TriggerBase // TypeDefIndex: 10049
{	// Fields
	public float Temperature; // 0x30
	public float triggerSize; // 0x34
	public float minSize; // 0x38
	public bool sunlightBlocker; // 0x3C
	public float sunlightBlockAmount; // 0x40
	[RangeAttribute] // RVA: 0xB07F0 Offset: 0xAFBF0 VA: 0x1800B07F0
	public float blockMinHour; // 0x44
	[RangeAttribute] // RVA: 0xB07F0 Offset: 0xAFBF0 VA: 0x1800B07F0
	public float blockMaxHour; // 0x48

	// Methods

	// RVA: 0x4D38C0 Offset: 0x4D1EC0 VA: 0x1804D38C0
	private void OnValidate() { }

	// RVA: 0x4D3A80 Offset: 0x4D2080 VA: 0x1804D3A80
	public void .ctor() { }

}

