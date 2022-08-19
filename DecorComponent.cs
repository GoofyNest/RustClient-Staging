public abstract class DecorComponent : PrefabAttribute // TypeDefIndex: 10321
{	// Fields
	internal bool isRoot; // 0x98

	// Methods

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Apply(ref Vector3 pos, ref Quaternion rot, ref Vector3 scale);

	// RVA: 0x841770 Offset: 0x83FD70 VA: 0x180841770 Slot: 6
	protected override void AttributeSetup(GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x841830 Offset: 0x83FE30 VA: 0x180841830 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x841890 Offset: 0x83FE90 VA: 0x180841890
	protected void .ctor() { }

}

