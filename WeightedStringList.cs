public class WeightedStringList // TypeDefIndex: 6214
{	// Fields
	public List<WeightedStringList.Container> Objects; // 0x10
	private float _total; // 0x18

	// Properties
	private float Total { get; }

	// Methods

	// RVA: 0x14BDEB0 Offset: 0x14BC4B0 VA: 0x1814BDEB0
	private float get_Total() { }

	// RVA: 0x14BDC20 Offset: 0x14BC220 VA: 0x1814BDC20
	public string Get(float f) { }

	// RVA: 0x14BDBF0 Offset: 0x14BC1F0 VA: 0x1814BDBF0
	public string GetRandom() { }

	// RVA: 0x14BDE40 Offset: 0x14BC440 VA: 0x1814BDE40
	public void .ctor() { }

}

public struct WeightedStringList.Container // TypeDefIndex: 6215
{	// Fields
	public float Weight; // 0x0
	public string Object; // 0x8

}

private sealed class WeightedStringList.<>c // TypeDefIndex: 6216
{	// Fields
	public static readonly WeightedStringList.<>c <>9; // 0x0
	public static Func<WeightedStringList.Container, float> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x14BC490 Offset: 0x14BAA90 VA: 0x1814BC490
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x14BBE20 Offset: 0x14BA420 VA: 0x1814BBE20
	internal float <get_Total>b__3_0(WeightedStringList.Container x) { }

}

