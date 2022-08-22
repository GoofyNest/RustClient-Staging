public class PlayableDirector : Behaviour // TypeDefIndex: 4518
{
// Namespace: UnityEngine.Playables
[RequiredByNativeCodeAttribute] // RVA: 0xDBBD0 Offset: 0xDAFD0 VA: 0x1800DBBD0
[NativeHeaderAttribute] // RVA: 0xDBBD0 Offset: 0xDAFD0 VA: 0x1800DBBD0
[NativeHeaderAttribute] // RVA: 0xDBBD0 Offset: 0xDAFD0 VA: 0x1800DBBD0
public class PlayableDirector : Behaviour // TypeDefIndex: 4518
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private Action<PlayableDirector> played; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private Action<PlayableDirector> paused; // 0x20
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private Action<PlayableDirector> stopped; // 0x28

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2322990 Offset: 0x2320F90 VA: 0x182322990
	private void SendOnPlayableDirectorPlay() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2322940 Offset: 0x2320F40 VA: 0x182322940
	private void SendOnPlayableDirectorPause() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x23229E0 Offset: 0x2320FE0 VA: 0x1823229E0
	private void SendOnPlayableDirectorStop() { }

}

