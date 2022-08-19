internal struct HashSet.Slot<T> // TypeDefIndex: 3255
{	// Fields
	internal int hashCode; // 0x0
	internal int next; // 0x0
	internal T value; // 0x0

}

public struct HashSet.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 3256
{	// Fields
	private HashSet<T> _set; // 0x0
	private int _index; // 0x0
	private int _version; // 0x0
	private T _current; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(HashSet<T> set) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21E850 Offset: 0x21DC50 VA: 0x18021E850
	|-HashSet.Enumerator<Connection>..ctor
	|-HashSet.Enumerator<int>..ctor
	|-HashSet.Enumerator<uint>..ctor
	|
	|-RVA: 0x21E8A0 Offset: 0x21DCA0 VA: 0x18021E8A0
	|-HashSet.Enumerator<object>..ctor
	|-HashSet.Enumerator<ulong>..ctor
	|
	|-RVA: 0x21E8F0 Offset: 0x21DCF0 VA: 0x18021E8F0
	|-HashSet.Enumerator<Vector3>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF1F30 Offset: 0xF1330 VA: 0x1800F1F30
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

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21DB10 Offset: 0x21CF10 VA: 0x18021DB10
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
	|-RVA: 0x21DEC0 Offset: 0x21D2C0 VA: 0x18021DEC0
	|-HashSet.Enumerator<Connection>.MoveNext
	|
	|-RVA: 0x21DDE0 Offset: 0x21D1E0 VA: 0x18021DDE0
	|-HashSet.Enumerator<int>.MoveNext
	|
	|-RVA: 0x21DA30 Offset: 0x21CE30 VA: 0x18021DA30
	|-HashSet.Enumerator<uint>.MoveNext
	|
	|-RVA: 0x21DC00 Offset: 0x21D000 VA: 0x18021DC00
	|-HashSet.Enumerator<ulong>.MoveNext
	|
	|-RVA: 0x21DCF0 Offset: 0x21D0F0 VA: 0x18021DCF0
	|-HashSet.Enumerator<Vector3>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF3F60 Offset: 0xF3360 VA: 0x1800F3F60
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
	|-RVA: 0xF3F30 Offset: 0xF3330 VA: 0x1800F3F30
	|-HashSet.Enumerator<uint>.get_Current
	|-HashSet.Enumerator<Connection>.get_Current
	|-HashSet.Enumerator<int>.get_Current
	|
	|-RVA: 0x116B10 Offset: 0x115F10 VA: 0x180116B10
	|-HashSet.Enumerator<Vector3>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21E3B0 Offset: 0x21D7B0 VA: 0x18021E3B0
	|-HashSet.Enumerator<Connection>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x21E750 Offset: 0x21DB50 VA: 0x18021E750
	|-HashSet.Enumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x21E6B0 Offset: 0x21DAB0 VA: 0x18021E6B0
	|-HashSet.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x21E4B0 Offset: 0x21D8B0 VA: 0x18021E4B0
	|-HashSet.Enumerator<uint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x21E5B0 Offset: 0x21D9B0 VA: 0x18021E5B0
	|-HashSet.Enumerator<ulong>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x21E2B0 Offset: 0x21D6B0 VA: 0x18021E2B0
	|-HashSet.Enumerator<Vector3>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21DFA0 Offset: 0x21D3A0 VA: 0x18021DFA0
	|-HashSet.Enumerator<Connection>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x21E0A0 Offset: 0x21D4A0 VA: 0x18021E0A0
	|-HashSet.Enumerator<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x21E020 Offset: 0x21D420 VA: 0x18021E020
	|-HashSet.Enumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x21E230 Offset: 0x21D630 VA: 0x18021E230
	|-HashSet.Enumerator<uint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x21E120 Offset: 0x21D520 VA: 0x18021E120
	|-HashSet.Enumerator<ulong>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x21E1A0 Offset: 0x21D5A0 VA: 0x18021E1A0
	|-HashSet.Enumerator<Vector3>.System.Collections.IEnumerator.Reset
	*/

}

