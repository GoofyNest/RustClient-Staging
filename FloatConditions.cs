public class FloatConditions // TypeDefIndex: 11369
{	// Fields
	public FloatConditions.Condition[] conditions; // 0x10

	// Methods

	// RVA: 0x793140 Offset: 0x791740 VA: 0x180793140
	public bool AllTrue(float val) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public struct FloatConditions.Condition // TypeDefIndex: 11370
{	// Fields
	public FloatConditions.Condition.Types type; // 0x0
	public float value; // 0x4

	// Methods

	// RVA: 0xF5370 Offset: 0xF4770 VA: 0x1800F5370
	public bool Test(float val) { }

}

public enum FloatConditions.Condition.Types // TypeDefIndex: 11371
{	// Fields
	public int value__; // 0x0
	public const FloatConditions.Condition.Types Equal = 0;
	public const FloatConditions.Condition.Types NotEqual = 1;
	public const FloatConditions.Condition.Types Higher = 2;
	public const FloatConditions.Condition.Types Lower = 3;

}
