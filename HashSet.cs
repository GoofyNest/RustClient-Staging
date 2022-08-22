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
	|-RVA: 0x21E7D0 Offset: 0x21DBD0 VA: 0x18021E7D0
	|-HashSet.Enumerator<Connection>..ctor
	|-HashSet.Enumerator<int>..ctor
	|-HashSet.Enumerator<uint>..ctor
	|
	|-RVA: 0x21E820 Offset: 0x21DC20 VA: 0x18021E820
	|-HashSet.Enumerator<object>..ctor
	|-HashSet.Enumerator<ulong>..ctor
	|
	|-RVA: 0x21E870 Offset: 0x21DC70 VA: 0x18021E870
	|-HashSet.Enumerator<Vector3>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
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

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21DA90 Offset: 0x21CE90 VA: 0x18021DA90
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
	|-RVA: 0x21DE40 Offset: 0x21D240 VA: 0x18021DE40
	|-HashSet.Enumerator<Connection>.MoveNext
	|
	|-RVA: 0x21DD60 Offset: 0x21D160 VA: 0x18021DD60
	|-HashSet.Enumerator<int>.MoveNext
	|
	|-RVA: 0x21D9B0 Offset: 0x21CDB0 VA: 0x18021D9B0
	|-HashSet.Enumerator<uint>.MoveNext
	|
	|-RVA: 0x21DB80 Offset: 0x21CF80 VA: 0x18021DB80
	|-HashSet.Enumerator<ulong>.MoveNext
	|
	|-RVA: 0x21DC70 Offset: 0x21D070 VA: 0x18021DC70
	|-HashSet.Enumerator<Vector3>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
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

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21E330 Offset: 0x21D730 VA: 0x18021E330
	|-HashSet.Enumerator<Connection>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x21E6D0 Offset: 0x21DAD0 VA: 0x18021E6D0
	|-HashSet.Enumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x21E630 Offset: 0x21DA30 VA: 0x18021E630
	|-HashSet.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x21E430 Offset: 0x21D830 VA: 0x18021E430
	|-HashSet.Enumerator<uint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x21E530 Offset: 0x21D930 VA: 0x18021E530
	|-HashSet.Enumerator<ulong>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x21E230 Offset: 0x21D630 VA: 0x18021E230
	|-HashSet.Enumerator<Vector3>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21DF20 Offset: 0x21D320 VA: 0x18021DF20
	|-HashSet.Enumerator<Connection>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x21E020 Offset: 0x21D420 VA: 0x18021E020
	|-HashSet.Enumerator<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x21DFA0 Offset: 0x21D3A0 VA: 0x18021DFA0
	|-HashSet.Enumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x21E1B0 Offset: 0x21D5B0 VA: 0x18021E1B0
	|-HashSet.Enumerator<uint>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x21E0A0 Offset: 0x21D4A0 VA: 0x18021E0A0
	|-HashSet.Enumerator<ulong>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x21E120 Offset: 0x21D520 VA: 0x18021E120
	|-HashSet.Enumerator<Vector3>.System.Collections.IEnumerator.Reset
	*/

}

