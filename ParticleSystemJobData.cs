public struct ParticleSystemJobData // TypeDefIndex: 4550
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	[DebuggerBrowsableAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	private readonly int <count>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	[DebuggerBrowsableAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	private readonly ParticleSystemNativeArray3 <positions>k__BackingField; // 0x8
	[DebuggerBrowsableAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	[CompilerGeneratedAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	private readonly ParticleSystemNativeArray3 <velocities>k__BackingField; // 0x38
	[DebuggerBrowsableAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	[CompilerGeneratedAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	private readonly ParticleSystemNativeArray3 <rotations>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	[DebuggerBrowsableAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	private readonly ParticleSystemNativeArray3 <rotationalSpeeds>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	[DebuggerBrowsableAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	private readonly ParticleSystemNativeArray3 <sizes>k__BackingField; // 0xC8
	[DebuggerBrowsableAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	[CompilerGeneratedAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	private readonly NativeArray<Color32> <startColors>k__BackingField; // 0xF8
	[DebuggerBrowsableAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	[CompilerGeneratedAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	private readonly NativeArray<float> <aliveTimePercent>k__BackingField; // 0x108
	[DebuggerBrowsableAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	[CompilerGeneratedAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	private readonly NativeArray<float> <inverseStartLifetimes>k__BackingField; // 0x118
	[DebuggerBrowsableAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	[CompilerGeneratedAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	private readonly NativeArray<uint> <randomSeeds>k__BackingField; // 0x128
	[CompilerGeneratedAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	[DebuggerBrowsableAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	private readonly ParticleSystemNativeArray4 <customData1>k__BackingField; // 0x138
	[CompilerGeneratedAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	[DebuggerBrowsableAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	private readonly ParticleSystemNativeArray4 <customData2>k__BackingField; // 0x178

	// Properties
	public int count { get; }
	public ParticleSystemNativeArray3 positions { get; }
	public ParticleSystemNativeArray3 velocities { get; }
	public NativeArray<float> aliveTimePercent { get; }
	public NativeArray<float> inverseStartLifetimes { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xF37A0 Offset: 0xF2BA0 VA: 0x1800F37A0
	public int get_count() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x23C020 Offset: 0x23B420 VA: 0x18023C020
	public ParticleSystemNativeArray3 get_positions() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x23C040 Offset: 0x23B440 VA: 0x18023C040
	public ParticleSystemNativeArray3 get_velocities() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x23C000 Offset: 0x23B400 VA: 0x18023C000
	public NativeArray<float> get_aliveTimePercent() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x23C010 Offset: 0x23B410 VA: 0x18023C010
	public NativeArray<float> get_inverseStartLifetimes() { }

	// RVA: 0x23BFF0 Offset: 0x23B3F0 VA: 0x18023BFF0
	internal void .ctor(ref NativeParticleData nativeData) { }

	// RVA: -1 Offset: -1
	internal NativeArray<T> CreateNativeArray<T>(void* src, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x225540 Offset: 0x224940 VA: 0x180225540
	|-ParticleSystemJobData.CreateNativeArray<float>
	|-ParticleSystemJobData.CreateNativeArray<uint>
	|-ParticleSystemJobData.CreateNativeArray<Color32>
	*/

	// RVA: 0x23BF90 Offset: 0x23B390 VA: 0x18023BF90
	internal ParticleSystemNativeArray3 CreateNativeArray3(ref NativeParticleData.Array3 ptrs, int count) { }

	// RVA: 0x23BFC0 Offset: 0x23B3C0 VA: 0x18023BFC0
	internal ParticleSystemNativeArray4 CreateNativeArray4(ref NativeParticleData.Array4 ptrs, int count) { }

}

