public class PlaceMonument : ProceduralComponent // TypeDefIndex: 10535
{	// Fields
	public SpawnFilter Filter; // 0x28
	public GameObjectRef Monument; // 0x30
	private const int Attempts = 10000;

	// Methods

	// RVA: 0x910FD0 Offset: 0x90F5D0 VA: 0x180910FD0 Slot: 5
	public override void Process(uint seed) { }

	// RVA: 0x57BBD0 Offset: 0x57A1D0 VA: 0x18057BBD0
	public void .ctor() { }

}

private struct PlaceMonument.SpawnInfo // TypeDefIndex: 10536
{	// Fields
	public Prefab prefab; // 0x0
	public Vector3 position; // 0x8
	public Quaternion rotation; // 0x14
	public Vector3 scale; // 0x24

}

