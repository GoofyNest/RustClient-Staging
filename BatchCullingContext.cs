public struct BatchCullingContext // TypeDefIndex: 3844
{	// Fields
	public readonly NativeArray<Plane> cullingPlanes; // 0x0
	public NativeArray<BatchVisibility> batchVisibility; // 0x10
	public NativeArray<int> visibleIndices; // 0x20
	public readonly LODParameters lodParameters; // 0x30

	// Methods

	// RVA: 0x2218E0 Offset: 0x220CE0 VA: 0x1802218E0
	public void .ctor(NativeArray<Plane> inCullingPlanes, NativeArray<BatchVisibility> inOutBatchVisibility, NativeArray<int> outVisibleIndices, LODParameters inLodParameters) { }

}

