public class TriggerParentEnclosed : TriggerParent // TypeDefIndex: 10038
{	// Fields
	public float Padding; // 0x48
	[TooltipAttribute] // RVA: 0xB0750 Offset: 0xAFB50 VA: 0x1800B0750
	public TriggerParentEnclosed.TriggerMode intersectionMode; // 0x4C
	public bool CheckBoundsOnUnparent; // 0x50

	// Methods

	// RVA: 0xA22290 Offset: 0xA20890 VA: 0x180A22290
	public void .ctor() { }

}

public enum TriggerParentEnclosed.TriggerMode // TypeDefIndex: 10039
{	// Fields
	public int value__; // 0x0
	public const TriggerParentEnclosed.TriggerMode TriggerPoint = 0;
	public const TriggerParentEnclosed.TriggerMode PivotPoint = 1;

}

