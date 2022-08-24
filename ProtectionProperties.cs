public class ProtectionProperties : ScriptableObject // TypeDefIndex: 10755
{	[TextAreaAttribute] // RVA: 0x72220 Offset: 0x71620 VA: 0x180072220
	public string comments; // 0x18
	[RangeAttribute] // RVA: 0x78180 Offset: 0x77580 VA: 0x180078180
	public float density; // 0x20
	[ArrayIndexIsEnumRanged] // RVA: 0x782B0 Offset: 0x776B0 VA: 0x1800782B0
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

