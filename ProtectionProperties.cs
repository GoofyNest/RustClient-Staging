public class ProtectionProperties : ScriptableObject // TypeDefIndex: 10751
{	// Fields
	[TextAreaAttribute] // RVA: 0x721B0 Offset: 0x715B0 VA: 0x1800721B0
	public string comments; // 0x18
	[RangeAttribute] // RVA: 0x77EF0 Offset: 0x772F0 VA: 0x180077EF0
	public float density; // 0x20
	[ArrayIndexIsEnumRanged] // RVA: 0x77FE0 Offset: 0x773E0 VA: 0x180077FE0
	public float[] amounts; // 0x28

	// Methods

	// RVA: 0x699EB0 Offset: 0x6984B0 VA: 0x180699EB0
	public void OnValidate() { }

	// RVA: 0x699D50 Offset: 0x698350 VA: 0x180699D50
	public void Clear() { }

	// RVA: 0x699A60 Offset: 0x698060 VA: 0x180699A60
	public void Add(float amount) { }

	// RVA: 0x699BF0 Offset: 0x6981F0 VA: 0x180699BF0
	public void Add(DamageType index, float amount) { }

	// RVA: 0x699AD0 Offset: 0x6980D0 VA: 0x180699AD0
	public void Add(ProtectionProperties other, float scale) { }

	// RVA: 0x699C30 Offset: 0x698230 VA: 0x180699C30
	public void Add(List<Item> items, HitArea area = -1) { }

	// RVA: 0x699E00 Offset: 0x698400 VA: 0x180699E00
	public void Multiply(float multiplier) { }

	// RVA: 0x699E70 Offset: 0x698470 VA: 0x180699E70
	public void Multiply(DamageType index, float multiplier) { }

	// RVA: 0x699FC0 Offset: 0x6985C0 VA: 0x180699FC0
	public void Scale(DamageTypeList damageList, float ProtectionAmount = 1) { }

	// RVA: 0x699DC0 Offset: 0x6983C0 VA: 0x180699DC0
	public float Get(DamageType damageType) { }

	// RVA: 0x69A120 Offset: 0x698720 VA: 0x18069A120
	public void .ctor() { }

}

