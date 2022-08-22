public abstract class TerrainModifier : PrefabAttribute // TypeDefIndex: 10578
{	// Fields
	public float Opacity; // 0x98
	public float Radius; // 0x9C
	public float Fade; // 0xA0

	// Methods

	// RVA: 0x114D370 Offset: 0x114B970 VA: 0x18114D370
	public void Apply(Vector3 pos, float scale) { }

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract void Apply(Vector3 position, float opacity, float radius, float fade);

	// RVA: 0x114D3D0 Offset: 0x114B9D0 VA: 0x18114D3D0 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x113C3D0 Offset: 0x113A9D0 VA: 0x18113C3D0
	protected void .ctor() { }

}

