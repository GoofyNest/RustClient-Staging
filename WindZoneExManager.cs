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

	// RVA: 0x8F7920 Offset: 0x8F5F20 VA: 0x1808F7920
	public static WindZoneExManager get_Instance() { }

	// RVA: 0x8F6390 Offset: 0x8F4990 VA: 0x1808F6390
	public static void Clear() { }

	// RVA: 0x8F72F0 Offset: 0x8F58F0 VA: 0x1808F72F0
	public static void Register(WindZoneEx zone) { }

	// RVA: 0x8F7680 Offset: 0x8F5C80 VA: 0x1808F7680
	public static void Unregister(WindZoneEx zone) { }

	// RVA: 0x8F62B0 Offset: 0x8F48B0 VA: 0x1808F62B0
	private void Awake() { }

	// RVA: 0x8F7700 Offset: 0x8F5D00 VA: 0x1808F7700
	private void Update() { }

	// RVA: 0x8F6D00 Offset: 0x8F5300 VA: 0x1808F6D00
	public void FindAndSortZones(Camera camera) { }

	// RVA: 0x8F7370 Offset: 0x8F5970 VA: 0x1808F7370
	public void SetShaderGlobals() { }

	// RVA: 0x8F68D0 Offset: 0x8F4ED0 VA: 0x1808F68D0
	private static Vector4 ComputeWindForce(float time, Vector4 zoneInfo, Vector4 zoneParam, Vector3 center) { }

	// RVA: 0x8F6420 Offset: 0x8F4A20 VA: 0x1808F6420
	public static Vector4 ComputeWindForceAtLocation(Vector3 location) { }

	// RVA: 0x8F78F0 Offset: 0x8F5EF0 VA: 0x1808F78F0
	public void .ctor() { }

	// RVA: 0x8F77F0 Offset: 0x8F5DF0 VA: 0x1808F77F0
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

	// RVA: 0x8EE240 Offset: 0x8EC840 VA: 0x1808EE240
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x83CD00 Offset: 0x83B300 VA: 0x18083CD00
	internal int <FindAndSortZones>b__22_0(WindZoneExManager.CurrentZoneEntry x, WindZoneExManager.CurrentZoneEntry y) { }

}

