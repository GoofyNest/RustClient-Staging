public class PlaceCliffs : ProceduralComponent // TypeDefIndex: 10529
{	// Fields
	public SpawnFilter Filter; // 0x28
	public string ResourceFolder; // 0x30
	public int RetryMultiplier; // 0x38
	public int CutoffSlope; // 0x3C
	public float MinScale; // 0x40
	public float MaxScale; // 0x44
	private static int target_count; // 0x0
	private static int target_length; // 0x4
	private static float min_scale_delta; // 0x8
	private static int max_scale_attempts; // 0xC
	private static int min_rotation; // 0x10
	private static int max_rotation; // 0x14
	private static int rotation_delta; // 0x18
	private static float offset_c; // 0x1C
	private static float offset_l; // 0x20
	private static float offset_r; // 0x24
	private static Vector3[] offsets; // 0x28

	// Methods

	// RVA: 0x90E4C0 Offset: 0x90CAC0 VA: 0x18090E4C0 Slot: 5
	public override void Process(uint seed) { }

	// RVA: 0x90E3D0 Offset: 0x90C9D0 VA: 0x18090E3D0
	private PlaceCliffs.CliffPlacement PlaceMale(Prefab[] prefabs, ref uint seed, Prefab parentPrefab, Vector3 parentPos, Quaternion parentRot, Vector3 parentScale) { }

	// RVA: 0x90E2E0 Offset: 0x90C8E0 VA: 0x18090E2E0
	private PlaceCliffs.CliffPlacement PlaceFemale(Prefab[] prefabs, ref uint seed, Prefab parentPrefab, Vector3 parentPos, Quaternion parentRot, Vector3 parentScale) { }

	// RVA: -1 Offset: -1
	private PlaceCliffs.CliffPlacement Place<ParentSocketType, ChildSocketType>(Prefab[] prefabs, ref uint seed, Prefab parentPrefab, Vector3 parentPos, Quaternion parentRot, Vector3 parentScale, int parentAngle = 0, int parentCount = 0, int parentScore = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125D960 Offset: 0x125BF60 VA: 0x18125D960
	|-PlaceCliffs.Place<DecorSocketFemale, DecorSocketMale>
	|-PlaceCliffs.Place<DecorSocketMale, DecorSocketFemale>
	|-PlaceCliffs.Place<object, object>
	*/

	// RVA: 0x90F4E0 Offset: 0x90DAE0 VA: 0x18090F4E0
	public void .ctor() { }

	// RVA: 0x90F1C0 Offset: 0x90D7C0 VA: 0x18090F1C0
	private static void .cctor() { }

}

private class PlaceCliffs.CliffPlacement // TypeDefIndex: 10530
{	// Fields
	public int count; // 0x10
	public int score; // 0x14
	public Prefab prefab; // 0x18
	public Vector3 pos; // 0x20
	public Quaternion rot; // 0x2C
	public Vector3 scale; // 0x3C
	public PlaceCliffs.CliffPlacement next; // 0x48

	// Methods

	// RVA: 0x905930 Offset: 0x903F30 VA: 0x180905930
	public void .ctor() { }

}

private sealed class PlaceCliffs.<>c // TypeDefIndex: 10531
{	// Fields
	public static readonly PlaceCliffs.<>c <>9; // 0x0
	public static Func<Prefab, bool> <>9__17_0; // 0x8
	public static Func<Prefab, bool> <>9__17_1; // 0x10
	public static Func<Prefab, bool> <>9__17_2; // 0x18

	// Methods

	// RVA: 0x920D80 Offset: 0x91F380 VA: 0x180920D80
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x9208B0 Offset: 0x91EEB0 VA: 0x1809208B0
	internal bool <Process>b__17_0(Prefab prefab) { }

	// RVA: 0x9209E0 Offset: 0x91EFE0 VA: 0x1809209E0
	internal bool <Process>b__17_1(Prefab prefab) { }

	// RVA: 0x920A60 Offset: 0x91F060 VA: 0x180920A60
	internal bool <Process>b__17_2(Prefab prefab) { }

}

