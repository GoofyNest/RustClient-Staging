public abstract class TerrainModifier : PrefabAttribute // TypeDefIndex: 10578
{	// Fields
	public float Opacity; // 0x98
	public float Radius; // 0x9C
	public float Fade; // 0xA0

	// Methods

	// RVA: 0x114D0B0 Offset: 0x114B6B0 VA: 0x18114D0B0
	public void Apply(Vector3 pos, float scale) { }

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract void Apply(Vector3 position, float opacity, float radius, float fade);

	// RVA: 0x114D110 Offset: 0x114B710 VA: 0x18114D110 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x113C110 Offset: 0x113A710 VA: 0x18113C110
	protected void .ctor() { }

}

