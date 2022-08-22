public struct NativeArray.Enumerator<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 3325
{	// Fields
	private NativeArray<T> m_Array; // 0x0
	private int m_Index; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ref NativeArray<T> array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20E630 Offset: 0x20DA30 VA: 0x18020E630
	|-NativeArray.Enumerator<BoneData>..ctor
	|-NativeArray.Enumerator<BoneState>..ctor
	|-NativeArray.Enumerator<ColliderData>..ctor
	|-NativeArray.Enumerator<ColliderState>..ctor
	|-NativeArray.Enumerator<byte>..ctor
	|-NativeArray.Enumerator<int>..ctor
	|-NativeArray.Enumerator<float>..ctor
	|-NativeArray.Enumerator<uint>..ctor
	|-NativeArray.Enumerator<JobHandle>..ctor
	|-NativeArray.Enumerator<float3>..ctor
	|-NativeArray.Enumerator<half2>..ctor
	|-NativeArray.Enumerator<Color32>..ctor
	|-NativeArray.Enumerator<LightDataGI>..ctor
	|-NativeArray.Enumerator<Plane>..ctor
	|-NativeArray.Enumerator<RaycastCommand>..ctor
	|-NativeArray.Enumerator<RaycastHit>..ctor
	|-NativeArray.Enumerator<BatchVisibility>..ctor
	|-NativeArray.Enumerator<Vector4>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF1EB0 Offset: 0xF12B0 VA: 0x1800F1EB0
	|-NativeArray.Enumerator<BoneData>.Dispose
	|-NativeArray.Enumerator<BoneState>.Dispose
	|-NativeArray.Enumerator<ColliderData>.Dispose
	|-NativeArray.Enumerator<ColliderState>.Dispose
	|-NativeArray.Enumerator<byte>.Dispose
	|-NativeArray.Enumerator<int>.Dispose
	|-NativeArray.Enumerator<float>.Dispose
	|-NativeArray.Enumerator<uint>.Dispose
	|-NativeArray.Enumerator<JobHandle>.Dispose
	|-NativeArray.Enumerator<float3>.Dispose
	|-NativeArray.Enumerator<half2>.Dispose
	|-NativeArray.Enumerator<Color32>.Dispose
	|-NativeArray.Enumerator<LightDataGI>.Dispose
	|-NativeArray.Enumerator<Plane>.Dispose
	|-NativeArray.Enumerator<RaycastCommand>.Dispose
	|-NativeArray.Enumerator<RaycastHit>.Dispose
	|-NativeArray.Enumerator<BatchVisibility>.Dispose
	|-NativeArray.Enumerator<Vector4>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20DE30 Offset: 0x20D230 VA: 0x18020DE30
	|-NativeArray.Enumerator<BoneData>.MoveNext
	|-NativeArray.Enumerator<BoneState>.MoveNext
	|-NativeArray.Enumerator<ColliderData>.MoveNext
	|-NativeArray.Enumerator<ColliderState>.MoveNext
	|-NativeArray.Enumerator<byte>.MoveNext
	|-NativeArray.Enumerator<int>.MoveNext
	|-NativeArray.Enumerator<float>.MoveNext
	|-NativeArray.Enumerator<uint>.MoveNext
	|-NativeArray.Enumerator<JobHandle>.MoveNext
	|-NativeArray.Enumerator<float3>.MoveNext
	|-NativeArray.Enumerator<half2>.MoveNext
	|-NativeArray.Enumerator<Color32>.MoveNext
	|-NativeArray.Enumerator<LightDataGI>.MoveNext
	|-NativeArray.Enumerator<Plane>.MoveNext
	|-NativeArray.Enumerator<RaycastCommand>.MoveNext
	|-NativeArray.Enumerator<RaycastHit>.MoveNext
	|-NativeArray.Enumerator<BatchVisibility>.MoveNext
	|-NativeArray.Enumerator<Vector4>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20DE40 Offset: 0x20D240 VA: 0x18020DE40
	|-NativeArray.Enumerator<BoneData>.Reset
	|-NativeArray.Enumerator<BoneState>.Reset
	|-NativeArray.Enumerator<ColliderData>.Reset
	|-NativeArray.Enumerator<ColliderState>.Reset
	|-NativeArray.Enumerator<byte>.Reset
	|-NativeArray.Enumerator<int>.Reset
	|-NativeArray.Enumerator<float>.Reset
	|-NativeArray.Enumerator<uint>.Reset
	|-NativeArray.Enumerator<JobHandle>.Reset
	|-NativeArray.Enumerator<float3>.Reset
	|-NativeArray.Enumerator<half2>.Reset
	|-NativeArray.Enumerator<Color32>.Reset
	|-NativeArray.Enumerator<LightDataGI>.Reset
	|-NativeArray.Enumerator<Plane>.Reset
	|-NativeArray.Enumerator<RaycastCommand>.Reset
	|-NativeArray.Enumerator<RaycastHit>.Reset
	|-NativeArray.Enumerator<BatchVisibility>.Reset
	|-NativeArray.Enumerator<Vector4>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20E800 Offset: 0x20DC00 VA: 0x18020E800
	|-NativeArray.Enumerator<BoneData>.get_Current
	|
	|-RVA: 0x20E6D0 Offset: 0x20DAD0 VA: 0x18020E6D0
	|-NativeArray.Enumerator<BoneState>.get_Current
	|
	|-RVA: 0x20E650 Offset: 0x20DA50 VA: 0x18020E650
	|-NativeArray.Enumerator<ColliderData>.get_Current
	|
	|-RVA: 0x20E7D0 Offset: 0x20DBD0 VA: 0x18020E7D0
	|-NativeArray.Enumerator<ColliderState>.get_Current
	|
	|-RVA: 0x20E860 Offset: 0x20DC60 VA: 0x18020E860
	|-NativeArray.Enumerator<byte>.get_Current
	|
	|-RVA: 0x20E640 Offset: 0x20DA40 VA: 0x18020E640
	|-NativeArray.Enumerator<int>.get_Current
	|-NativeArray.Enumerator<uint>.get_Current
	|-NativeArray.Enumerator<half2>.get_Current
	|-NativeArray.Enumerator<Color32>.get_Current
	|
	|-RVA: 0x20E730 Offset: 0x20DB30 VA: 0x18020E730
	|-NativeArray.Enumerator<float>.get_Current
	|
	|-RVA: 0x20E740 Offset: 0x20DB40 VA: 0x18020E740
	|-NativeArray.Enumerator<JobHandle>.get_Current
	|-NativeArray.Enumerator<Plane>.get_Current
	|-NativeArray.Enumerator<Vector4>.get_Current
	|
	|-RVA: 0x20E700 Offset: 0x20DB00 VA: 0x18020E700
	|-NativeArray.Enumerator<float3>.get_Current
	|-NativeArray.Enumerator<BatchVisibility>.get_Current
	|
	|-RVA: 0x20E680 Offset: 0x20DA80 VA: 0x18020E680
	|-NativeArray.Enumerator<LightDataGI>.get_Current
	|
	|-RVA: 0x20E760 Offset: 0x20DB60 VA: 0x18020E760
	|-NativeArray.Enumerator<RaycastCommand>.get_Current
	|
	|-RVA: 0x20E790 Offset: 0x20DB90 VA: 0x18020E790
	|-NativeArray.Enumerator<RaycastHit>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20E360 Offset: 0x20D760 VA: 0x18020E360
	|-NativeArray.Enumerator<BoneData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20E010 Offset: 0x20D410 VA: 0x18020E010
	|-NativeArray.Enumerator<BoneState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20E4F0 Offset: 0x20D8F0 VA: 0x18020E4F0
	|-NativeArray.Enumerator<ColliderData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20DEE0 Offset: 0x20D2E0 VA: 0x18020DEE0
	|-NativeArray.Enumerator<ColliderState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20DF80 Offset: 0x20D380 VA: 0x18020DF80
	|-NativeArray.Enumerator<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20E200 Offset: 0x20D600 VA: 0x18020E200
	|-NativeArray.Enumerator<int>.System.Collections.IEnumerator.get_Current
	|-NativeArray.Enumerator<uint>.System.Collections.IEnumerator.get_Current
	|-NativeArray.Enumerator<half2>.System.Collections.IEnumerator.get_Current
	|-NativeArray.Enumerator<Color32>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20E5A0 Offset: 0x20D9A0 VA: 0x18020E5A0
	|-NativeArray.Enumerator<float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20DE50 Offset: 0x20D250 VA: 0x18020DE50
	|-NativeArray.Enumerator<JobHandle>.System.Collections.IEnumerator.get_Current
	|-NativeArray.Enumerator<Plane>.System.Collections.IEnumerator.get_Current
	|-NativeArray.Enumerator<Vector4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20E0C0 Offset: 0x20D4C0 VA: 0x18020E0C0
	|-NativeArray.Enumerator<float3>.System.Collections.IEnumerator.get_Current
	|-NativeArray.Enumerator<BatchVisibility>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20E290 Offset: 0x20D690 VA: 0x18020E290
	|-NativeArray.Enumerator<LightDataGI>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20E160 Offset: 0x20D560 VA: 0x18020E160
	|-NativeArray.Enumerator<RaycastCommand>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20E440 Offset: 0x20D840 VA: 0x18020E440
	|-NativeArray.Enumerator<RaycastHit>.System.Collections.IEnumerator.get_Current
	*/

}

