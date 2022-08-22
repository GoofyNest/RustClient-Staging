public sealed class TrackballAttribute : Attribute // TypeDefIndex: 11754
{	// Fields
	public readonly TrackballAttribute.Mode mode; // 0x10

	// Methods

	// RVA: 0xB113D0 Offset: 0xB0F9D0 VA: 0x180B113D0
	public void .ctor(TrackballAttribute.Mode mode) { }

}

public enum TrackballAttribute.Mode // TypeDefIndex: 11755
{	// Fields
	public int value__; // 0x0
	public const TrackballAttribute.Mode None = 0;
	public const TrackballAttribute.Mode Lift = 1;
	public const TrackballAttribute.Mode Gamma = 2;
	public const TrackballAttribute.Mode Gain = 3;

}

