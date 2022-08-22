internal struct HashSet.Slot<T> // TypeDefIndex: 3255
{	internal int hashCode; // 0x0
	internal int next; // 0x0
	internal T value; // 0x0

}

public struct HashSet.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 3256
{	private HashSet<T> _set; // 0x0
	private int _index; // 0x0
	private int _version; // 0x0
	private T _current; // 0x0

	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	internal void .ctor(HashSet<T> set) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x219D50 Offset: 0x219150 VA: 0x180219D50
	|-HashSet.Enumerator<Connection>..ctor
	|-HashSet.Enumerator<int>..ctor
	|-HashSet.Enumerator<uint>..ctor
	|
	|-RVA: 0x219DA0 Offset: 0x2191A0 VA: 0x180219DA0
	|-HashSet.Enumerator<object>..ctor
	|-HashSet.Enumerator<ulong>..ctor
	|
	|-RVA: 0x219DF0 Offset: 0x2191F0 VA: 0x180219DF0
	|-HashSet.Enumerator<Vector3>..ctor
	*/

	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF1EB0 Offset: 0xF12B0 VA: 0x1800F1EB0
	|-HashSet.Enumerator<AICoverPoint>.Dispose
	|-HashSet.Enumerator<AIMovePoint>.Dispose
	|-HashSet.Enumerator<AmbienceEmitter>.Dispose
	|-HashSet.Enumerator<AtmosphereVolume>.Dispose
	|-HashSet.Enumerator<BaseEntity>.Dispose
	|-HashSet.Enumerator<DeferredMeshDecal>.Dispose
	|-HashSet.Enumerator<Impostor>.Dispose
	|-HashSet.Enumerator<ImpostorShadows>.Dispose
	|-HashSet.Enumerator<LODComponent>.Dispose
	|-HashSet.Enumerator<ShoutcastStreamer>.Dispose
	|-HashSet.Enumerator<Connection>.Dispose
	|-HashSet.Enumerator<int>.Dispose
	|-HashSet.Enumerator<object>.Dispose
	|-HashSet.Enumerator<string>.Dispose
	|-HashSet.Enumerator<uint>.Dispose
	|-HashSet.Enumerator<ulong>.Dispose
	|-HashSet.Enumerator<GameObject>.Dispose
	|-HashSet.Enumerator<IClippable>.Dispose
	|-HashSet.Enumerator<MaskableGraphic>.Dispose
	|-HashSet.Enumerator<Text>.Dispose
	|-HashSet.Enumerator<Vector3>.Dispose
	|-HashSet.Enumerator<WaterBody>.Dispose
	|-HashSet.Enumerator<WaterCullingVolume>.Dispose
	|-HashSet.Enumerator<WaterDepthMask>.Dispose
	|-HashSet.Enumerator<WaterInteraction>.Dispose
	|-HashSet.Enumerator<WindZoneEx>.Dispose
	*/

	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x219010 Offset: 0x218410 VA: 0x180219010
	|-HashSet.Enumerator<AICoverPoint>.MoveNext
	|-HashSet.Enumerator<AIMovePoint>.MoveNext
	|-HashSet.Enumerator<AmbienceEmitter>.MoveNext
	|-HashSet.Enumerator<AtmosphereVolume>.MoveNext
	|-HashSet.Enumerator<BaseEntity>.MoveNext
	|-HashSet.Enumerator<DeferredExtensionMesh>.MoveNext
	|-HashSet.Enumerator<DeferredMeshDecal>.MoveNext
	|-HashSet.Enumerator<Impostor>.MoveNext
	|-HashSet.Enumerator<ImpostorShadows>.MoveNext
	|-HashSet.Enumerator<LODComponent>.MoveNext
	|-HashSet.Enumerator<ShoutcastStreamer>.MoveNext
	|-HashSet.Enumerator<object>.MoveNext
	|-HashSet.Enumerator<string>.MoveNext
	|-HashSet.Enumerator<Collider>.MoveNext
	|-HashSet.Enumerator<GameObject>.MoveNext
	|-HashSet.Enumerator<IClippable>.MoveNext
	|-HashSet.Enumerator<MaskableGraphic>.MoveNext
	|-HashSet.Enumerator<Text>.MoveNext
	|-HashSet.Enumerator<WaterBody>.MoveNext
	|-HashSet.Enumerator<WaterCullingVolume>.MoveNext
	|-HashSet.Enumerator<WaterDepthMask>.MoveNext
	|-HashSet.Enumerator<WaterInteraction>.MoveNext
	|-HashSet.Enumerator<WindZoneEx>.MoveNext
	|
	|-RVA: 0x2193C0 Offset: 0x2187C0 VA: 0x1802193C0
	|-HashSet.Enumerator<Connection>.MoveNext
	|
	|-RVA: 0x2192E0 Offset: 0x2186E0 VA: 0x1802192E0
	|-HashSet.Enumerator<int>.MoveNext
	|
	|-RVA: 0x218F30 Offset: 0x218330 VA: 0x180218F30
	|-HashSet.Enumerator<uint>.MoveNext
	|
	|-RVA: 0x219100 Offset: 0x218500 VA: 0x180219100
	|-HashSet.Enumerator<ulong>.MoveNext
	|
	|-RVA: 0x2191F0 Offset: 0x2185F0 VA: 0x1802191F0
	|-HashSet.Enumerator<Vector3>.MoveNext
	*/

	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF3EE0 Offset: 0xF32E0 VA: 0x1800F3EE0
	|-HashSet.Enumerator<AICoverPoint>.get_Current
	|-HashSet.Enumerator<AIMovePoint>.get_Current
	|-HashSet.Enumerator<AmbienceEmitter>.get_Current
	|-HashSet.Enumerator<AtmosphereVolume>.get_Current
	|-HashSet.Enumerator<BaseEntity>.get_Current
	|-HashSet.Enumerator<DeferredExtensionMesh>.get_Current
	|-HashSet.Enumerator<DeferredMeshDecal>.get_Current
	|-HashSet.Enumerator<Impostor>.get_Current
	|-HashSet.Enumerator<ImpostorShadows>.get_Current
	|-HashSet.Enumerator<LODComponent>.get_Current
	|-HashSet.Enumerator<ShoutcastStreamer>.get_Current
	|-HashSet.Enumerator<string>.get_Current
	|-HashSet.Enumerator<ulong>.get_Current
	|-HashSet.Enumerator<Collider>.get_Current
	|-HashSet.Enumerator<GameObject>.get_Current
	|-HashSet.Enumerator<IClippable>.get_Current
	|-HashSet.Enumerator<MaskableGraphic>.get_Current
	|-HashSet.Enumerator<Text>.get_Current
	|-HashSet.Enumerator<WaterBody>.get_Current
	|-HashSet.Enumerator<WaterCullingVolume>.get_Current
	|-HashSet.Enumerator<WaterDepthMask>.get_Current
	|-HashSet.Enumerator<WaterInteraction>.get_Current
	|-HashSet.Enumerator<WindZoneEx>.get_Current
	|-HashSet.Enumerator<object>.get_Current
	|
	|-RVA: 0xF3EB0 Offset: 0xF32B0 VA: 0x1800F3EB0
	|-HashSet.Enumerator<uint>.get_Current
	|-HashSet.Enumerator<Connection>.get_Current
	|-HashSet.Enumerator<int>.get_Current
	|
	|-RVA: 0x116A90 Offset: 0x115E90 VA: 0x180116A90
	|-HashSet.Enumerator<Vector3>.get_Current
	*/

	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2198B0 Offset: 0x218CB0 VA: 0x1802198B0
	|-HashSet.Enumerator<Connection>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x219C50 Offset: 0x219050 VA: 0x180219C50
	|-HashSet.Enumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x219BB0 Offset: 0x218FB0 VA: 0x180219BB0
	|-HashSet.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2199B0 Offset: 0x218DB0 VA: 0x1802199B0
	|-HashSet.Enumerator<uint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x219AB0 Offset: 0x218EB0 VA: 0x180219AB0
	|-HashSet.Enumerator<ulong>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2197B0 Offset: 0x218BB0 VA: 0x1802197B0
	|-HashSet.Enumerator<Vector3>.System.Collections.IEnumerator.get_Current
	*/

	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2194A0 Offset: 0x2188A0 VA: 0x1802194A0
	|-HashSet.Enumerator<Connection>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2195A0 Offset: 0x2189A0 VA: 0x1802195A0
	|-HashSet.Enumerator<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x219520 Offset: 0x218920 VA: 0x180219520
	|-HashSet.Enumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x219730 Offset: 0x218B30 VA: 0x180219730
	|-HashSet.Enumerator<uint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x219620 Offset: 0x218A20 VA: 0x180219620
	|-HashSet.Enumerator<ulong>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2196A0 Offset: 0x218AA0 VA: 0x1802196A0
	|-HashSet.Enumerator<Vector3>.System.Collections.IEnumerator.Reset
	*/

}

