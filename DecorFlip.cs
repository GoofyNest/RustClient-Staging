public class DecorFlip : DecorComponent // TypeDefIndex: 10324
{	// Fields
	public DecorFlip.AxisType FlipAxis; // 0xA0

	// Methods

	// RVA: 0x841F50 Offset: 0x840550 VA: 0x180841F50 Slot: 8
	public override void Apply(ref Vector3 pos, ref Quaternion rot, ref Vector3 scale) { }

	// RVA: 0x842130 Offset: 0x840730 VA: 0x180842130
	public void .ctor() { }

}

public enum DecorFlip.AxisType // TypeDefIndex: 10325
{	// Fields
	public int value__; // 0x0
	public const DecorFlip.AxisType X = 0;
	public const DecorFlip.AxisType Y = 1;
	public const DecorFlip.AxisType Z = 2;

}

