public class ProtectionProperties : ScriptableObject // TypeDefIndex: 10755
{	[TextAreaAttribute] // RVA: 0x72390 Offset: 0x71790 VA: 0x180072390
	public string comments; // 0x18
	[RangeAttribute] // RVA: 0x77AC0 Offset: 0x76EC0 VA: 0x180077AC0
	public float density; // 0x20
	[ArrayIndexIsEnumRanged] // RVA: 0x77B70 Offset: 0x76F70 VA: 0x180077B70
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

