public struct ParticleSystemJobData // TypeDefIndex: 4550
{	[CompilerGeneratedAttribute] // RVA: 0x70950 Offset: 0x6FD50 VA: 0x180070950
	[DebuggerBrowsableAttribute] // RVA: 0x70950 Offset: 0x6FD50 VA: 0x180070950
	private readonly int <count>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x70950 Offset: 0x6FD50 VA: 0x180070950
	[DebuggerBrowsableAttribute] // RVA: 0x70950 Offset: 0x6FD50 VA: 0x180070950
	private readonly ParticleSystemNativeArray3 <positions>k__BackingField; // 0x8
	[DebuggerBrowsableAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	[CompilerGeneratedAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	private readonly ParticleSystemNativeArray3 <velocities>k__BackingField; // 0x38
	[DebuggerBrowsableAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	[CompilerGeneratedAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	private readonly ParticleSystemNativeArray3 <rotations>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x70950 Offset: 0x6FD50 VA: 0x180070950
	[DebuggerBrowsableAttribute] // RVA: 0x70950 Offset: 0x6FD50 VA: 0x180070950
	private readonly ParticleSystemNativeArray3 <rotationalSpeeds>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x70950 Offset: 0x6FD50 VA: 0x180070950
	[DebuggerBrowsableAttribute] // RVA: 0x70950 Offset: 0x6FD50 VA: 0x180070950
	private readonly ParticleSystemNativeArray3 <sizes>k__BackingField; // 0xC8
	[DebuggerBrowsableAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	[CompilerGeneratedAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	private readonly NativeArray<Color32> <startColors>k__BackingField; // 0xF8
	[DebuggerBrowsableAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	[CompilerGeneratedAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	private readonly NativeArray<float> <aliveTimePercent>k__BackingField; // 0x108
	[DebuggerBrowsableAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	[CompilerGeneratedAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	private readonly NativeArray<float> <inverseStartLifetimes>k__BackingField; // 0x118
	[DebuggerBrowsableAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	[CompilerGeneratedAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	private readonly NativeArray<uint> <randomSeeds>k__BackingField; // 0x128
	[CompilerGeneratedAttribute] // RVA: 0x70950 Offset: 0x6FD50 VA: 0x180070950
	[DebuggerBrowsableAttribute] // RVA: 0x70950 Offset: 0x6FD50 VA: 0x180070950
	private readonly ParticleSystemNativeArray4 <customData1>k__BackingField; // 0x138
	[CompilerGeneratedAttribute] // RVA: 0x70950 Offset: 0x6FD50 VA: 0x180070950
	[DebuggerBrowsableAttribute] // RVA: 0x70950 Offset: 0x6FD50 VA: 0x180070950
	private readonly ParticleSystemNativeArray4 <customData2>k__BackingField; // 0x178

	public int count { get; }
	public ParticleSystemNativeArray3 positions { get; }
	public ParticleSystemNativeArray3 velocities { get; }
	public NativeArray<float> aliveTimePercent { get; }
	public NativeArray<float> inverseStartLifetimes { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public int get_count() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public ParticleSystemNativeArray3 get_positions() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public ParticleSystemNativeArray3 get_velocities() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public NativeArray<float> get_aliveTimePercent() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public NativeArray<float> get_inverseStartLifetimes() { }

	internal void .ctor(ref NativeParticleData nativeData) { }

	internal NativeArray<T> CreateNativeArray<T>(void* src, int count) { }
	/* GenericInstMethod :
	|
	|-ParticleSystemJobData.CreateNativeArray<float>
	|-ParticleSystemJobData.CreateNativeArray<uint>
	|-ParticleSystemJobData.CreateNativeArray<Color32>
	*/

	internal ParticleSystemNativeArray3 CreateNativeArray3(ref NativeParticleData.Array3 ptrs, int count) { }

	internal ParticleSystemNativeArray4 CreateNativeArray4(ref NativeParticleData.Array4 ptrs, int count) { }

}

