public struct ParticleSystemJobData // TypeDefIndex: 4550
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private readonly int <count>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private readonly ParticleSystemNativeArray3 <positions>k__BackingField; // 0x8
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private readonly ParticleSystemNativeArray3 <velocities>k__BackingField; // 0x38
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private readonly ParticleSystemNativeArray3 <rotations>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private readonly ParticleSystemNativeArray3 <rotationalSpeeds>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private readonly ParticleSystemNativeArray3 <sizes>k__BackingField; // 0xC8
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private readonly NativeArray<Color32> <startColors>k__BackingField; // 0xF8
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private readonly NativeArray<float> <aliveTimePercent>k__BackingField; // 0x108
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private readonly NativeArray<float> <inverseStartLifetimes>k__BackingField; // 0x118
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private readonly NativeArray<uint> <randomSeeds>k__BackingField; // 0x128
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private readonly ParticleSystemNativeArray4 <customData1>k__BackingField; // 0x138
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private readonly ParticleSystemNativeArray4 <customData2>k__BackingField; // 0x178

	// Properties
	public int count { get; }
	public ParticleSystemNativeArray3 positions { get; }
	public ParticleSystemNativeArray3 velocities { get; }
	public NativeArray<float> aliveTimePercent { get; }
	public NativeArray<float> inverseStartLifetimes { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xF3720 Offset: 0xF2B20 VA: 0x1800F3720
	public int get_count() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x23BFA0 Offset: 0x23B3A0 VA: 0x18023BFA0
	public ParticleSystemNativeArray3 get_positions() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x23BFC0 Offset: 0x23B3C0 VA: 0x18023BFC0
	public ParticleSystemNativeArray3 get_velocities() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x23BF80 Offset: 0x23B380 VA: 0x18023BF80
	public NativeArray<float> get_aliveTimePercent() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x23BF90 Offset: 0x23B390 VA: 0x18023BF90
	public NativeArray<float> get_inverseStartLifetimes() { }

	// RVA: 0x23BF70 Offset: 0x23B370 VA: 0x18023BF70
	internal void .ctor(ref NativeParticleData nativeData) { }

	// RVA: -1 Offset: -1
	internal NativeArray<T> CreateNativeArray<T>(void* src, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2254C0 Offset: 0x2248C0 VA: 0x1802254C0
	|-ParticleSystemJobData.CreateNativeArray<float>
	|-ParticleSystemJobData.CreateNativeArray<uint>
	|-ParticleSystemJobData.CreateNativeArray<Color32>
	*/

	// RVA: 0x23BF10 Offset: 0x23B310 VA: 0x18023BF10
	internal ParticleSystemNativeArray3 CreateNativeArray3(ref NativeParticleData.Array3 ptrs, int count) { }

	// RVA: 0x23BF40 Offset: 0x23B340 VA: 0x18023BF40
	internal ParticleSystemNativeArray4 CreateNativeArray4(ref NativeParticleData.Array4 ptrs, int count) { }

}

