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

	// RVA: 0x96B250 Offset: 0x969850 VA: 0x18096B250
	public float get_greatFraction() { }

	// RVA: 0x96B0F0 Offset: 0x9696F0 VA: 0x18096B0F0
	public void Reset() { }

	// RVA: 0x96AE30 Offset: 0x969430 VA: 0x18096AE30
	public float Fraction() { }

	// RVA: 0x96B020 Offset: 0x969620 VA: 0x18096B020
	public float InverseFraction() { }

	// RVA: 0x96AD80 Offset: 0x969380 VA: 0x18096AD80
	public void Add(float val) { }

	// RVA: 0x96B1A0 Offset: 0x9697A0 VA: 0x18096B1A0
	public void Subtract(float val) { }

	// RVA: 0x96AF80 Offset: 0x969580 VA: 0x18096AF80
	public void Increase(float fTarget) { }

	// RVA: 0x96B040 Offset: 0x969640 VA: 0x18096B040
	public void MoveTowards(float fTarget, float fRate) { }

	// RVA: 0x96AEC0 Offset: 0x9694C0 VA: 0x18096AEC0
	public bool HasChanged() { }

	// RVA: 0x96AEE0 Offset: 0x9694E0 VA: 0x18096AEE0
	public bool HasGreatlyChanged() { }

	// RVA: 0x96B190 Offset: 0x969790 VA: 0x18096B190
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

