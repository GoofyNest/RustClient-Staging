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
	|-RVA: 0x20E6B0 Offset: 0x20DAB0 VA: 0x18020E6B0
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
	|-RVA: 0xF1F30 Offset: 0xF1330 VA: 0x1800F1F30
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
	|-RVA: 0x20DEB0 Offset: 0x20D2B0 VA: 0x18020DEB0
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
	|-RVA: 0x20DEC0 Offset: 0x20D2C0 VA: 0x18020DEC0
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
	|-RVA: 0x20E880 Offset: 0x20DC80 VA: 0x18020E880
	|-NativeArray.Enumerator<BoneData>.get_Current
	|
	|-RVA: 0x20E750 Offset: 0x20DB50 VA: 0x18020E750
	|-NativeArray.Enumerator<BoneState>.get_Current
	|
	|-RVA: 0x20E6D0 Offset: 0x20DAD0 VA: 0x18020E6D0
	|-NativeArray.Enumerator<ColliderData>.get_Current
	|
	|-RVA: 0x20E850 Offset: 0x20DC50 VA: 0x18020E850
	|-NativeArray.Enumerator<ColliderState>.get_Current
	|
	|-RVA: 0x20E8E0 Offset: 0x20DCE0 VA: 0x18020E8E0
	|-NativeArray.Enumerator<byte>.get_Current
	|
	|-RVA: 0x20E6C0 Offset: 0x20DAC0 VA: 0x18020E6C0
	|-NativeArray.Enumerator<int>.get_Current
	|-NativeArray.Enumerator<uint>.get_Current
	|-NativeArray.Enumerator<half2>.get_Current
	|-NativeArray.Enumerator<Color32>.get_Current
	|
	|-RVA: 0x20E7B0 Offset: 0x20DBB0 VA: 0x18020E7B0
	|-NativeArray.Enumerator<float>.get_Current
	|
	|-RVA: 0x20E7C0 Offset: 0x20DBC0 VA: 0x18020E7C0
	|-NativeArray.Enumerator<JobHandle>.get_Current
	|-NativeArray.Enumerator<Plane>.get_Current
	|-NativeArray.Enumerator<Vector4>.get_Current
	|
	|-RVA: 0x20E780 Offset: 0x20DB80 VA: 0x18020E780
	|-NativeArray.Enumerator<float3>.get_Current
	|-NativeArray.Enumerator<BatchVisibility>.get_Current
	|
	|-RVA: 0x20E700 Offset: 0x20DB00 VA: 0x18020E700
	|-NativeArray.Enumerator<LightDataGI>.get_Current
	|
	|-RVA: 0x20E7E0 Offset: 0x20DBE0 VA: 0x18020E7E0
	|-NativeArray.Enumerator<RaycastCommand>.get_Current
	|
	|-RVA: 0x20E810 Offset: 0x20DC10 VA: 0x18020E810
	|-NativeArray.Enumerator<RaycastHit>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20E3E0 Offset: 0x20D7E0 VA: 0x18020E3E0
	|-NativeArray.Enumerator<BoneData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20E090 Offset: 0x20D490 VA: 0x18020E090
	|-NativeArray.Enumerator<BoneState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20E570 Offset: 0x20D970 VA: 0x18020E570
	|-NativeArray.Enumerator<ColliderData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20DF60 Offset: 0x20D360 VA: 0x18020DF60
	|-NativeArray.Enumerator<ColliderState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20E000 Offset: 0x20D400 VA: 0x18020E000
	|-NativeArray.Enumerator<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20E280 Offset: 0x20D680 VA: 0x18020E280
	|-NativeArray.Enumerator<int>.System.Collections.IEnumerator.get_Current
	|-NativeArray.Enumerator<uint>.System.Collections.IEnumerator.get_Current
	|-NativeArray.Enumerator<half2>.System.Collections.IEnumerator.get_Current
	|-NativeArray.Enumerator<Color32>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20E620 Offset: 0x20DA20 VA: 0x18020E620
	|-NativeArray.Enumerator<float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20DED0 Offset: 0x20D2D0 VA: 0x18020DED0
	|-NativeArray.Enumerator<JobHandle>.System.Collections.IEnumerator.get_Current
	|-NativeArray.Enumerator<Plane>.System.Collections.IEnumerator.get_Current
	|-NativeArray.Enumerator<Vector4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20E140 Offset: 0x20D540 VA: 0x18020E140
	|-NativeArray.Enumerator<float3>.System.Collections.IEnumerator.get_Current
	|-NativeArray.Enumerator<BatchVisibility>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20E310 Offset: 0x20D710 VA: 0x18020E310
	|-NativeArray.Enumerator<LightDataGI>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20E1E0 Offset: 0x20D5E0 VA: 0x18020E1E0
	|-NativeArray.Enumerator<RaycastCommand>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20E4C0 Offset: 0x20D8C0 VA: 0x18020E4C0
	|-NativeArray.Enumerator<RaycastHit>.System.Collections.IEnumerator.get_Current
	*/

}

