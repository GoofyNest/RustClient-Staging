public class TriggerTemperature : TriggerBase // TypeDefIndex: 10049
{	public float Temperature; // 0x30
	public float triggerSize; // 0x34
	public float minSize; // 0x38
	public bool sunlightBlocker; // 0x3C
	public float sunlightBlockAmount; // 0x40
	[RangeAttribute] // RVA: 0xB0570 Offset: 0xAF970 VA: 0x1800B0570
	public float blockMinHour; // 0x44
	[RangeAttribute] // RVA: 0xB0570 Offset: 0xAF970 VA: 0x1800B0570
	public float blockMaxHour; // 0x48


	private void OnValidate() { }

	public void .ctor() { }

}

