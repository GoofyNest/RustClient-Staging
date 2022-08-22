public abstract class DecorComponent : PrefabAttribute // TypeDefIndex: 10321
{	// Fields
	internal bool isRoot; // 0x98

	// Methods

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Apply(ref Vector3 pos, ref Quaternion rot, ref Vector3 scale);

	// RVA: 0x841880 Offset: 0x83FE80 VA: 0x180841880 Slot: 6
	protected override void AttributeSetup(GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x841940 Offset: 0x83FF40 VA: 0x180841940 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x8419A0 Offset: 0x83FFA0 VA: 0x1808419A0
	protected void .ctor() { }

}

