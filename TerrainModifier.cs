public abstract class TerrainModifier : PrefabAttribute // TypeDefIndex: 10578
{	// Fields
	public float Opacity; // 0x98
	public float Radius; // 0x9C
	public float Fade; // 0xA0

	// Methods

	// RVA: 0x114DDE0 Offset: 0x114C3E0 VA: 0x18114DDE0
	public void Apply(Vector3 pos, float scale) { }

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract void Apply(Vector3 position, float opacity, float radius, float fade);

	// RVA: 0x114DE40 Offset: 0x114C440 VA: 0x18114DE40 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x113CE40 Offset: 0x113B440 VA: 0x18113CE40
	protected void .ctor() { }

}

