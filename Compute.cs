public enum Compute_DistanceTransform_EventTypes // TypeDefIndex: 6850
{	// Fields
	public int value__; // 0x0
	public const Compute_DistanceTransform_EventTypes Processing = 0;
	public const Compute_DistanceTransform_EventTypes Completed = 1;

}

public class Compute_DT_EventArgs // TypeDefIndex: 6852
{	// Fields
	public Compute_DistanceTransform_EventTypes EventType; // 0x10
	public float ProgressPercentage; // 0x14
	public Color[] Colors; // 0x18

	// Methods

	// RVA: 0xC65890 Offset: 0xC63E90 VA: 0x180C65890
	public void .ctor(Compute_DistanceTransform_EventTypes type, float progress) { }

	// RVA: 0xC65850 Offset: 0xC63E50 VA: 0x180C65850
	public void .ctor(Compute_DistanceTransform_EventTypes type, Color[] colors) { }

}

