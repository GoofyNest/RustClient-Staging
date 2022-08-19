public class MetabolismAttribute // TypeDefIndex: 9565
{	// Fields
	public float startMin; // 0x10
	public float startMax; // 0x14
	public float min; // 0x18
	public float max; // 0x1C
	public float value; // 0x20
	internal float lastValue; // 0x24
	internal float lastGreatFraction; // 0x28
	private const float greatInterval = 0,1;

	// Properties
	public float greatFraction { get; }

	// Methods

	// RVA: 0x96AC40 Offset: 0x969240 VA: 0x18096AC40
	public float get_greatFraction() { }

	// RVA: 0x96AAE0 Offset: 0x9690E0 VA: 0x18096AAE0
	public void Reset() { }

	// RVA: 0x96A820 Offset: 0x968E20 VA: 0x18096A820
	public float Fraction() { }

	// RVA: 0x96AA10 Offset: 0x969010 VA: 0x18096AA10
	public float InverseFraction() { }

	// RVA: 0x96A770 Offset: 0x968D70 VA: 0x18096A770
	public void Add(float val) { }

	// RVA: 0x96AB90 Offset: 0x969190 VA: 0x18096AB90
	public void Subtract(float val) { }

	// RVA: 0x96A970 Offset: 0x968F70 VA: 0x18096A970
	public void Increase(float fTarget) { }

	// RVA: 0x96AA30 Offset: 0x969030 VA: 0x18096AA30
	public void MoveTowards(float fTarget, float fRate) { }

	// RVA: 0x96A8B0 Offset: 0x968EB0 VA: 0x18096A8B0
	public bool HasChanged() { }

	// RVA: 0x96A8D0 Offset: 0x968ED0 VA: 0x18096A8D0
	public bool HasGreatlyChanged() { }

	// RVA: 0x96AB80 Offset: 0x969180 VA: 0x18096AB80
	public void SetValue(float newValue) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public enum MetabolismAttribute.Type // TypeDefIndex: 9566
{	// Fields
	public int value__; // 0x0
	public const MetabolismAttribute.Type Calories = 0;
	public const MetabolismAttribute.Type Hydration = 1;
	public const MetabolismAttribute.Type Heartrate = 2;
	public const MetabolismAttribute.Type Poison = 3;
	public const MetabolismAttribute.Type Radiation = 4;
	public const MetabolismAttribute.Type Bleeding = 5;
	public const MetabolismAttribute.Type Health = 6;
	public const MetabolismAttribute.Type HealthOverTime = 7;

}

