public class ProtectionProperties : ScriptableObject // TypeDefIndex: 10751
{	[TextAreaAttribute] // RVA: 0x721B0 Offset: 0x715B0 VA: 0x1800721B0
	public string comments; // 0x18
	[RangeAttribute] // RVA: 0x77EF0 Offset: 0x772F0 VA: 0x180077EF0
	public float density; // 0x20
	[ArrayIndexIsEnumRanged] // RVA: 0x77FE0 Offset: 0x773E0 VA: 0x180077FE0
	public float[] amounts; // 0x28


	public void OnValidate() { }

	public void Clear() { }

	public void Add(float amount) { }

	public void Add(DamageType index, float amount) { }

	public void Add(ProtectionProperties other, float scale) { }

	public void Add(List<Item> items, HitArea area = -1) { }

	public void Multiply(float multiplier) { }

	public void Multiply(DamageType index, float multiplier) { }

	public void Scale(DamageTypeList damageList, float ProtectionAmount = 1) { }

	public float Get(DamageType damageType) { }

	public void .ctor() { }

}

