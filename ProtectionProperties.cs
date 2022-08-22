public class ProtectionProperties : ScriptableObject // TypeDefIndex: 10751
{	// Fields
	[TextAreaAttribute] // RVA: 0x721B0 Offset: 0x715B0 VA: 0x1800721B0
	public string comments; // 0x18
	[RangeAttribute] // RVA: 0x77EF0 Offset: 0x772F0 VA: 0x180077EF0
	public float density; // 0x20
	[ArrayIndexIsEnumRanged] // RVA: 0x77FE0 Offset: 0x773E0 VA: 0x180077FE0
	public float[] amounts; // 0x28

	// Methods

	// RVA: 0x699DA0 Offset: 0x6983A0 VA: 0x180699DA0
	public void OnValidate() { }

	// RVA: 0x699C40 Offset: 0x698240 VA: 0x180699C40
	public void Clear() { }

	// RVA: 0x699950 Offset: 0x697F50 VA: 0x180699950
	public void Add(float amount) { }

	// RVA: 0x699AE0 Offset: 0x6980E0 VA: 0x180699AE0
	public void Add(DamageType index, float amount) { }

	// RVA: 0x6999C0 Offset: 0x697FC0 VA: 0x1806999C0
	public void Add(ProtectionProperties other, float scale) { }

	// RVA: 0x699B20 Offset: 0x698120 VA: 0x180699B20
	public void Add(List<Item> items, HitArea area = -1) { }

	// RVA: 0x699CF0 Offset: 0x6982F0 VA: 0x180699CF0
	public void Multiply(float multiplier) { }

	// RVA: 0x699D60 Offset: 0x698360 VA: 0x180699D60
	public void Multiply(DamageType index, float multiplier) { }

	// RVA: 0x699EB0 Offset: 0x6984B0 VA: 0x180699EB0
	public void Scale(DamageTypeList damageList, float ProtectionAmount = 1) { }

	// RVA: 0x699CB0 Offset: 0x6982B0 VA: 0x180699CB0
	public float Get(DamageType damageType) { }

	// RVA: 0x69A010 Offset: 0x698610 VA: 0x18069A010
	public void .ctor() { }

}

