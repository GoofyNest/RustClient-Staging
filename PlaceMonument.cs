public class PlaceMonument : ProceduralComponent // TypeDefIndex: 10535
{	// Fields
	public SpawnFilter Filter; // 0x28
	public GameObjectRef Monument; // 0x30
	private const int Attempts = 10000;

	// Methods

	// RVA: 0x9109B0 Offset: 0x90EFB0 VA: 0x1809109B0 Slot: 5
	public override void Process(uint seed) { }

	// RVA: 0x57BC40 Offset: 0x57A240 VA: 0x18057BC40
	public void .ctor() { }

}

private struct PlaceMonument.SpawnInfo // TypeDefIndex: 10536
{	// Fields
	public Prefab prefab; // 0x0
	public Vector3 position; // 0x8
	public Quaternion rotation; // 0x14
	public Vector3 scale; // 0x24

}

