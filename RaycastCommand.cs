public struct RaycastCommand // TypeDefIndex: 3935
{	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	[CompilerGeneratedAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	private Vector3 <from>k__BackingField; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	[CompilerGeneratedAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	private Vector3 <direction>k__BackingField; // 0xC
	[DebuggerBrowsableAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	[CompilerGeneratedAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	private float <distance>k__BackingField; // 0x18
	[DebuggerBrowsableAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	[CompilerGeneratedAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	private int <layerMask>k__BackingField; // 0x1C
	[DebuggerBrowsableAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	[CompilerGeneratedAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	private int <maxHits>k__BackingField; // 0x20

	// Properties
	public Vector3 from { set; }
	public Vector3 direction { set; }
	public float distance { set; }
	public int layerMask { set; }
	public int maxHits { set; }

	// Methods

	// RVA: 0x2395E0 Offset: 0x2389E0 VA: 0x1802395E0
	public void .ctor(Vector3 from, Vector3 direction, float distance = 3,402823E+38, int layerMask = -5, int maxHits = 1) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x204FB0 Offset: 0x2043B0 VA: 0x180204FB0
	public void set_from(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x212D40 Offset: 0x212140 VA: 0x180212D40
	public void set_direction(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x239620 Offset: 0x238A20 VA: 0x180239620
	public void set_distance(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x239630 Offset: 0x238A30 VA: 0x180239630
	public void set_layerMask(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1EF140 Offset: 0x1EE540 VA: 0x1801EF140
	public void set_maxHits(int value) { }

	// RVA: 0x229DB80 Offset: 0x229C180 VA: 0x18229DB80
	public static JobHandle ScheduleBatch(NativeArray<RaycastCommand> commands, NativeArray<RaycastHit> results, int minCommandsPerJob, JobHandle dependsOn) { }

	[FreeFunctionAttribute] // RVA: 0x9B520 Offset: 0x9A920 VA: 0x18009B520
	// RVA: 0x229DDA0 Offset: 0x229C3A0 VA: 0x18229DDA0
	private static JobHandle ScheduleRaycastBatch(ref JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob) { }

	// RVA: 0x229DD30 Offset: 0x229C330 VA: 0x18229DD30
	private static void ScheduleRaycastBatch_Injected(ref JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, out JobHandle ret) { }

}

