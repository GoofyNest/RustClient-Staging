public abstract class DecorComponent : PrefabAttribute // TypeDefIndex: 10321
{	// Fields
	internal bool isRoot; // 0x98

	// Methods

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Apply(ref Vector3 pos, ref Quaternion rot, ref Vector3 scale);

	// RVA: 0x841DD0 Offset: 0x8403D0 VA: 0x180841DD0 Slot: 6
	protected override void AttributeSetup(GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x841E90 Offset: 0x840490 VA: 0x180841E90 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x841EF0 Offset: 0x8404F0 VA: 0x180841EF0
	protected void .ctor() { }

}

