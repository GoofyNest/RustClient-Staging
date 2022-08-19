public class WeightedStringList // TypeDefIndex: 6214
{	// Fields
	public List<WeightedStringList.Container> Objects; // 0x10
	private float _total; // 0x18

	// Properties
	private float Total { get; }

	// Methods

	// RVA: 0x14BEB20 Offset: 0x14BD120 VA: 0x1814BEB20
	private float get_Total() { }

	// RVA: 0x14BE890 Offset: 0x14BCE90 VA: 0x1814BE890
	public string Get(float f) { }

	// RVA: 0x14BE860 Offset: 0x14BCE60 VA: 0x1814BE860
	public string GetRandom() { }

	// RVA: 0x14BEAB0 Offset: 0x14BD0B0 VA: 0x1814BEAB0
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

	// RVA: 0x14BD100 Offset: 0x14BB700 VA: 0x1814BD100
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x14BCA90 Offset: 0x14BB090 VA: 0x1814BCA90
	internal float <get_Total>b__3_0(WeightedStringList.Container x) { }

}

