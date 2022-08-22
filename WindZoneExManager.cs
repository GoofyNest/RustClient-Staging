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

	// RVA: 0x8F7F40 Offset: 0x8F6540 VA: 0x1808F7F40
	public static WindZoneExManager get_Instance() { }

	// RVA: 0x8F69B0 Offset: 0x8F4FB0 VA: 0x1808F69B0
	public static void Clear() { }

	// RVA: 0x8F7910 Offset: 0x8F5F10 VA: 0x1808F7910
	public static void Register(WindZoneEx zone) { }

	// RVA: 0x8F7CA0 Offset: 0x8F62A0 VA: 0x1808F7CA0
	public static void Unregister(WindZoneEx zone) { }

	// RVA: 0x8F68D0 Offset: 0x8F4ED0 VA: 0x1808F68D0
	private void Awake() { }

	// RVA: 0x8F7D20 Offset: 0x8F6320 VA: 0x1808F7D20
	private void Update() { }

	// RVA: 0x8F7320 Offset: 0x8F5920 VA: 0x1808F7320
	public void FindAndSortZones(Camera camera) { }

	// RVA: 0x8F7990 Offset: 0x8F5F90 VA: 0x1808F7990
	public void SetShaderGlobals() { }

	// RVA: 0x8F6EF0 Offset: 0x8F54F0 VA: 0x1808F6EF0
	private static Vector4 ComputeWindForce(float time, Vector4 zoneInfo, Vector4 zoneParam, Vector3 center) { }

	// RVA: 0x8F6A40 Offset: 0x8F5040 VA: 0x1808F6A40
	public static Vector4 ComputeWindForceAtLocation(Vector3 location) { }

	// RVA: 0x8F7F10 Offset: 0x8F6510 VA: 0x1808F7F10
	public void .ctor() { }

	// RVA: 0x8F7E10 Offset: 0x8F6410 VA: 0x1808F7E10
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

	// RVA: 0x8EE860 Offset: 0x8ECE60 VA: 0x1808EE860
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x83D360 Offset: 0x83B960 VA: 0x18083D360
	internal int <FindAndSortZones>b__22_0(WindZoneExManager.CurrentZoneEntry x, WindZoneExManager.CurrentZoneEntry y) { }

}

