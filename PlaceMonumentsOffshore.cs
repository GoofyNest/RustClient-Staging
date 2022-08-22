public class PlaceMonumentsOffshore : ProceduralComponent // TypeDefIndex: 10542
{	// Fields
	public string ResourceFolder; // 0x28
	public int TargetCount; // 0x30
	public int MinDistanceFromTerrain; // 0x34
	public int MaxDistanceFromTerrain; // 0x38
	public int DistanceBetweenMonuments; // 0x3C
	[FormerlySerializedAsAttribute] // RVA: 0xDA320 Offset: 0xD9720 VA: 0x1800DA320
	public int MinWorldSize; // 0x40
	private const int Candidates = 10;
	private const int Attempts = 10000;

	// Methods

	// RVA: 0x9113F0 Offset: 0x90F9F0 VA: 0x1809113F0 Slot: 5
	public override void Process(uint seed) { }

	// RVA: 0x9111E0 Offset: 0x90F7E0 VA: 0x1809111E0
	private bool CheckRadius(List<PlaceMonumentsOffshore.SpawnInfo> spawns, Vector3 pos, float radius) { }

	// RVA: 0x911F50 Offset: 0x910550 VA: 0x180911F50
	public void .ctor() { }

}

private struct PlaceMonumentsOffshore.SpawnInfo // TypeDefIndex: 10543
{	// Fields
	public Prefab prefab; // 0x0
	public Vector3 position; // 0x8
	public Quaternion rotation; // 0x14
	public Vector3 scale; // 0x24

}

private sealed class PlaceMonumentsOffshore.<>c // TypeDefIndex: 10544
{	// Fields
	public static readonly PlaceMonumentsOffshore.<>c <>9; // 0x0
	public static Func<string, string> <>9__9_0; // 0x8

	// Methods

	// RVA: 0x920D20 Offset: 0x91F320 VA: 0x180920D20
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x920AE0 Offset: 0x91F0E0 VA: 0x180920AE0
	internal string <Process>b__9_0(string folder) { }

}

