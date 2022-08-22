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
	|-RVA: 0x20E260 Offset: 0x20D660 VA: 0x18020E260
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
	|-RVA: 0x20DA60 Offset: 0x20CE60 VA: 0x18020DA60
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
	|-RVA: 0x20DA70 Offset: 0x20CE70 VA: 0x18020DA70
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
	|-RVA: 0x20E430 Offset: 0x20D830 VA: 0x18020E430
	|-NativeArray.Enumerator<BoneData>.get_Current
	|
	|-RVA: 0x20E300 Offset: 0x20D700 VA: 0x18020E300
	|-NativeArray.Enumerator<BoneState>.get_Current
	|
	|-RVA: 0x20E280 Offset: 0x20D680 VA: 0x18020E280
	|-NativeArray.Enumerator<ColliderData>.get_Current
	|
	|-RVA: 0x20E400 Offset: 0x20D800 VA: 0x18020E400
	|-NativeArray.Enumerator<ColliderState>.get_Current
	|
	|-RVA: 0x20E490 Offset: 0x20D890 VA: 0x18020E490
	|-NativeArray.Enumerator<byte>.get_Current
	|
	|-RVA: 0x20E270 Offset: 0x20D670 VA: 0x18020E270
	|-NativeArray.Enumerator<int>.get_Current
	|-NativeArray.Enumerator<uint>.get_Current
	|-NativeArray.Enumerator<half2>.get_Current
	|-NativeArray.Enumerator<Color32>.get_Current
	|
	|-RVA: 0x20E360 Offset: 0x20D760 VA: 0x18020E360
	|-NativeArray.Enumerator<float>.get_Current
	|
	|-RVA: 0x20E370 Offset: 0x20D770 VA: 0x18020E370
	|-NativeArray.Enumerator<JobHandle>.get_Current
	|-NativeArray.Enumerator<Plane>.get_Current
	|-NativeArray.Enumerator<Vector4>.get_Current
	|
	|-RVA: 0x20E330 Offset: 0x20D730 VA: 0x18020E330
	|-NativeArray.Enumerator<float3>.get_Current
	|-NativeArray.Enumerator<BatchVisibility>.get_Current
	|
	|-RVA: 0x20E2B0 Offset: 0x20D6B0 VA: 0x18020E2B0
	|-NativeArray.Enumerator<LightDataGI>.get_Current
	|
	|-RVA: 0x20E390 Offset: 0x20D790 VA: 0x18020E390
	|-NativeArray.Enumerator<RaycastCommand>.get_Current
	|
	|-RVA: 0x20E3C0 Offset: 0x20D7C0 VA: 0x18020E3C0
	|-NativeArray.Enumerator<RaycastHit>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20DF90 Offset: 0x20D390 VA: 0x18020DF90
	|-NativeArray.Enumerator<BoneData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20DC40 Offset: 0x20D040 VA: 0x18020DC40
	|-NativeArray.Enumerator<BoneState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20E120 Offset: 0x20D520 VA: 0x18020E120
	|-NativeArray.Enumerator<ColliderData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20DB10 Offset: 0x20CF10 VA: 0x18020DB10
	|-NativeArray.Enumerator<ColliderState>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20DBB0 Offset: 0x20CFB0 VA: 0x18020DBB0
	|-NativeArray.Enumerator<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20DE30 Offset: 0x20D230 VA: 0x18020DE30
	|-NativeArray.Enumerator<int>.System.Collections.IEnumerator.get_Current
	|-NativeArray.Enumerator<uint>.System.Collections.IEnumerator.get_Current
	|-NativeArray.Enumerator<half2>.System.Collections.IEnumerator.get_Current
	|-NativeArray.Enumerator<Color32>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20E1D0 Offset: 0x20D5D0 VA: 0x18020E1D0
	|-NativeArray.Enumerator<float>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20DA80 Offset: 0x20CE80 VA: 0x18020DA80
	|-NativeArray.Enumerator<JobHandle>.System.Collections.IEnumerator.get_Current
	|-NativeArray.Enumerator<Plane>.System.Collections.IEnumerator.get_Current
	|-NativeArray.Enumerator<Vector4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20DCF0 Offset: 0x20D0F0 VA: 0x18020DCF0
	|-NativeArray.Enumerator<float3>.System.Collections.IEnumerator.get_Current
	|-NativeArray.Enumerator<BatchVisibility>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20DEC0 Offset: 0x20D2C0 VA: 0x18020DEC0
	|-NativeArray.Enumerator<LightDataGI>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20DD90 Offset: 0x20D190 VA: 0x18020DD90
	|-NativeArray.Enumerator<RaycastCommand>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x20E070 Offset: 0x20D470 VA: 0x18020E070
	|-NativeArray.Enumerator<RaycastHit>.System.Collections.IEnumerator.get_Current
	*/

}

