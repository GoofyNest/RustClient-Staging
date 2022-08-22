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

	// RVA: 0x96AD50 Offset: 0x969350 VA: 0x18096AD50
	public float get_greatFraction() { }

	// RVA: 0x96ABF0 Offset: 0x9691F0 VA: 0x18096ABF0
	public void Reset() { }

	// RVA: 0x96A930 Offset: 0x968F30 VA: 0x18096A930
	public float Fraction() { }

	// RVA: 0x96AB20 Offset: 0x969120 VA: 0x18096AB20
	public float InverseFraction() { }

	// RVA: 0x96A880 Offset: 0x968E80 VA: 0x18096A880
	public void Add(float val) { }

	// RVA: 0x96ACA0 Offset: 0x9692A0 VA: 0x18096ACA0
	public void Subtract(float val) { }

	// RVA: 0x96AA80 Offset: 0x969080 VA: 0x18096AA80
	public void Increase(float fTarget) { }

	// RVA: 0x96AB40 Offset: 0x969140 VA: 0x18096AB40
	public void MoveTowards(float fTarget, float fRate) { }

	// RVA: 0x96A9C0 Offset: 0x968FC0 VA: 0x18096A9C0
	public bool HasChanged() { }

	// RVA: 0x96A9E0 Offset: 0x968FE0 VA: 0x18096A9E0
	public bool HasGreatlyChanged() { }

	// RVA: 0x96AC90 Offset: 0x969290 VA: 0x18096AC90
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

