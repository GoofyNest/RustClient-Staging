public struct BatchCullingContext // TypeDefIndex: 3844
{	// Fields
	public readonly NativeArray<Plane> cullingPlanes; // 0x0
	public NativeArray<BatchVisibility> batchVisibility; // 0x10
	public NativeArray<int> visibleIndices; // 0x20
	public readonly LODParameters lodParameters; // 0x30

	// Methods

	// RVA: 0x221860 Offset: 0x220C60 VA: 0x180221860
	public void .ctor(NativeArray<Plane> inCullingPlanes, NativeArray<BatchVisibility> inOutBatchVisibility, NativeArray<int> outVisibleIndices, LODParameters inLodParameters) { }

}

