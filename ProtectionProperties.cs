public class ProtectionProperties : ScriptableObject // TypeDefIndex: 10751
{	// Fields
	[TextAreaAttribute] // RVA: 0x721B0 Offset: 0x715B0 VA: 0x1800721B0
	public string comments; // 0x18
	[RangeAttribute] // RVA: 0x77EF0 Offset: 0x772F0 VA: 0x180077EF0
	public float density; // 0x20
	[ArrayIndexIsEnumRanged] // RVA: 0x77FE0 Offset: 0x773E0 VA: 0x180077FE0
	public float[] amounts; // 0x28

	// Methods

	// RVA: 0x699E40 Offset: 0x698440 VA: 0x180699E40
	public void OnValidate() { }

	// RVA: 0x699CE0 Offset: 0x6982E0 VA: 0x180699CE0
	public void Clear() { }

	// RVA: 0x6999F0 Offset: 0x697FF0 VA: 0x1806999F0
	public void Add(float amount) { }

	// RVA: 0x699B80 Offset: 0x698180 VA: 0x180699B80
	public void Add(DamageType index, float amount) { }

	// RVA: 0x699A60 Offset: 0x698060 VA: 0x180699A60
	public void Add(ProtectionProperties other, float scale) { }

	// RVA: 0x699BC0 Offset: 0x6981C0 VA: 0x180699BC0
	public void Add(List<Item> items, HitArea area = -1) { }

	// RVA: 0x699D90 Offset: 0x698390 VA: 0x180699D90
	public void Multiply(float multiplier) { }

	// RVA: 0x699E00 Offset: 0x698400 VA: 0x180699E00
	public void Multiply(DamageType index, float multiplier) { }

	// RVA: 0x699F50 Offset: 0x698550 VA: 0x180699F50
	public void Scale(DamageTypeList damageList, float ProtectionAmount = 1) { }

	// RVA: 0x699D50 Offset: 0x698350 VA: 0x180699D50
	public float Get(DamageType damageType) { }

	// RVA: 0x69A0B0 Offset: 0x6986B0 VA: 0x18069A0B0
	public void .ctor() { }

}

