public class WindZoneExManager : MonoBehaviour // TypeDefIndex: 10701
{	// Fields
	public float maxAccumMain; // 0x18
	public float maxAccumTurbulence; // 0x1C
	public float globalMainScale; // 0x20
	public float globalTurbulenceScale; // 0x24
	public Transform testPosition; // 0x28
	private const int MaxWindZones = 8;
	private const float MaxWindZoneDistanceToCamera = 1000;
	private const float MaxWindZoneSqrDistanceToCamera = 1000000;
	private static HashSet<WindZoneEx> registeredZones; // 0x0
	private static List<WindZoneExManager.CurrentZoneEntry> currentZones; // 0x8
	private static Vector4[] windZoneInfoArray; // 0x10
	private static Vector4[] windZoneParamArray; // 0x18
	private static WindZoneExManager instance; // 0x20

	// Properties
	public static WindZoneExManager Instance { get; }

	// Methods

	// RVA: 0x8F7A30 Offset: 0x8F6030 VA: 0x1808F7A30
	public static WindZoneExManager get_Instance() { }

	// RVA: 0x8F64A0 Offset: 0x8F4AA0 VA: 0x1808F64A0
	public static void Clear() { }

	// RVA: 0x8F7400 Offset: 0x8F5A00 VA: 0x1808F7400
	public static void Register(WindZoneEx zone) { }

	// RVA: 0x8F7790 Offset: 0x8F5D90 VA: 0x1808F7790
	public static void Unregister(WindZoneEx zone) { }

	// RVA: 0x8F63C0 Offset: 0x8F49C0 VA: 0x1808F63C0
	private void Awake() { }

	// RVA: 0x8F7810 Offset: 0x8F5E10 VA: 0x1808F7810
	private void Update() { }

	// RVA: 0x8F6E10 Offset: 0x8F5410 VA: 0x1808F6E10
	public void FindAndSortZones(Camera camera) { }

	// RVA: 0x8F7480 Offset: 0x8F5A80 VA: 0x1808F7480
	public void SetShaderGlobals() { }

	// RVA: 0x8F69E0 Offset: 0x8F4FE0 VA: 0x1808F69E0
	private static Vector4 ComputeWindForce(float time, Vector4 zoneInfo, Vector4 zoneParam, Vector3 center) { }

	// RVA: 0x8F6530 Offset: 0x8F4B30 VA: 0x1808F6530
	public static Vector4 ComputeWindForceAtLocation(Vector3 location) { }

	// RVA: 0x8F7A00 Offset: 0x8F6000 VA: 0x1808F7A00
	public void .ctor() { }

	// RVA: 0x8F7900 Offset: 0x8F5F00 VA: 0x1808F7900
	private static void .cctor() { }

}

private enum WindZoneExManager.TestMode // TypeDefIndex: 10702
{	// Fields
	public int value__; // 0x0
	public const WindZoneExManager.TestMode Disabled = 0;
	public const WindZoneExManager.TestMode Low = 1;

}

private struct WindZoneExManager.CurrentZoneEntry // TypeDefIndex: 10703
{	// Fields
	public WindZoneEx zone; // 0x0
	public float distanceSqr; // 0x8

	// Methods

	// RVA: 0xF90B0 Offset: 0xF84B0 VA: 0x1800F90B0
	public void .ctor(WindZoneEx zone, float distance) { }

}

private sealed class WindZoneExManager.<>c // TypeDefIndex: 10704
{	// Fields
	public static readonly WindZoneExManager.<>c <>9; // 0x0
	public static Comparison<WindZoneExManager.CurrentZoneEntry> <>9__22_0; // 0x8

	// Methods

	// RVA: 0x8EE350 Offset: 0x8EC950 VA: 0x1808EE350
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x83CE10 Offset: 0x83B410 VA: 0x18083CE10
	internal int <FindAndSortZones>b__22_0(WindZoneExManager.CurrentZoneEntry x, WindZoneExManager.CurrentZoneEntry y) { }

}

