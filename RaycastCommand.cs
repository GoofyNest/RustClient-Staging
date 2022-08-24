public struct RaycastCommand // TypeDefIndex: 3935
{	[DebuggerBrowsableAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	[CompilerGeneratedAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	private Vector3 <from>k__BackingField; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	[CompilerGeneratedAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	private Vector3 <direction>k__BackingField; // 0xC
	[DebuggerBrowsableAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	[CompilerGeneratedAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	private float <distance>k__BackingField; // 0x18
	[DebuggerBrowsableAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	[CompilerGeneratedAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	private int <layerMask>k__BackingField; // 0x1C
	[DebuggerBrowsableAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	[CompilerGeneratedAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	private int <maxHits>k__BackingField; // 0x20

	public Vector3 from { set; }
	public Vector3 direction { set; }
	public float distance { set; }
	public int layerMask { set; }
	public int maxHits { set; }


	public void .ctor(Vector3 from, Vector3 direction, float distance = 3,402823E+38, int layerMask = -5, int maxHits = 1) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void set_from(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void set_direction(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void set_distance(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void set_layerMask(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void set_maxHits(int value) { }

	public static JobHandle ScheduleBatch(NativeArray<RaycastCommand> commands, NativeArray<RaycastHit> results, int minCommandsPerJob, JobHandle dependsOn) { }

	[FreeFunctionAttribute] // RVA: 0x9B690 Offset: 0x9AA90 VA: 0x18009B690
	private static JobHandle ScheduleRaycastBatch(ref JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob) { }

	private static void ScheduleRaycastBatch_Injected(ref JobsUtility.JobScheduleParameters parameters, void* commands, int commandLen, void* result, int resultLen, int minCommandsPerJob, out JobHandle ret) { }

}

