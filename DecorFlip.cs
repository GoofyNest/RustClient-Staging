public class DecorFlip : DecorComponent // TypeDefIndex: 10324
{	// Fields
	public DecorFlip.AxisType FlipAxis; // 0xA0

	// Methods

	// RVA: 0x841A00 Offset: 0x840000 VA: 0x180841A00 Slot: 8
	public override void Apply(ref Vector3 pos, ref Quaternion rot, ref Vector3 scale) { }

	// RVA: 0x841BE0 Offset: 0x8401E0 VA: 0x180841BE0
	public void .ctor() { }

}

public enum DecorFlip.AxisType // TypeDefIndex: 10325
{	// Fields
	public int value__; // 0x0
	public const DecorFlip.AxisType X = 0;
	public const DecorFlip.AxisType Y = 1;
	public const DecorFlip.AxisType Z = 2;

}

