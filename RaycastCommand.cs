public struct RaycastCommand // TypeDefIndex: 3935
{	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private Vector3 <from>k__BackingField; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private Vector3 <direction>k__BackingField; // 0xC
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private float <distance>k__BackingField; // 0x18
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private int <layerMask>k__BackingField; // 0x1C
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private int <maxHits>k__BackingField; // 0x20

	// Properties
	public Vector3 from { set; }
	public Vector3 direction { set; }
	public float distance { set; }
	public int layerMask { set; }
	public int maxHits { set; }

	// Methods

	// RVA: 0x239560 Offset: 0x238960 VA: 0x180239560
	public void .ctor(Vector3 from, Vector3 direction, float distance = 3,402823E+38, int layerMask = -5, int maxHits = 1) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x204F30 Offset: 0x204330 VA: 0x180204F30
	public void set_from(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x212CC0 Offset: 0x2120C0 VA: 0x180212CC0
	public void set_direction(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2395A0 Offset: 0x2389A0 VA: 0x1802395A0
	public void set_distance(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2395B0 Offset: 0x2389B0 VA: 0x1802395B0
	public void set_layerMask(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1EF0C0 Offset: 0x1EE4C0 VA: 0x1801EF0C0
	public void set_maxHits(int value) { }

	// RVA: 0x229D9C0 Offset: 0x229BFC0 VA: 0x18229D9C0
	public static JobHandle ScheduleBatch(NativeArray<RaycastCommand> commands, NativeArray<RaycastHit> results, int minCommandsPerJob, JobHandle dependsOn) { }

	[FreeFunctionAttribute] // RVA: 0x9B5B0 Offset: 0x9A9B0 VA: 0x18009B5B0
	// RVA: 0x229DBE0 Offset: 0x229C1E0 VA: 0x18229DBE0
	private static JobHandle ScheduleRaycastBatch(ref JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob) { }

	// RVA: 0x229DB70 Offset: 0x229C170 VA: 0x18229DB70
	private static void ScheduleRaycastBatch_Injected(ref JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, out JobHandle ret) { }

}

