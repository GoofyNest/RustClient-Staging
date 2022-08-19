public class PlayableDirector : Behaviour // TypeDefIndex: 4518
{
// Namespace: UnityEngine.Playables
[RequiredByNativeCodeAttribute] // RVA: 0xDBB90 Offset: 0xDAF90 VA: 0x1800DBB90
[NativeHeaderAttribute] // RVA: 0xDBB90 Offset: 0xDAF90 VA: 0x1800DBB90
[NativeHeaderAttribute] // RVA: 0xDBB90 Offset: 0xDAF90 VA: 0x1800DBB90
public class PlayableDirector : Behaviour // TypeDefIndex: 4518
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	[DebuggerBrowsableAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	private Action<PlayableDirector> played; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	[DebuggerBrowsableAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	private Action<PlayableDirector> paused; // 0x20
	[DebuggerBrowsableAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	[CompilerGeneratedAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	private Action<PlayableDirector> stopped; // 0x28

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2322B50 Offset: 0x2321150 VA: 0x182322B50
	private void SendOnPlayableDirectorPlay() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2322B00 Offset: 0x2321100 VA: 0x182322B00
	private void SendOnPlayableDirectorPause() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2322BA0 Offset: 0x23211A0 VA: 0x182322BA0
	private void SendOnPlayableDirectorStop() { }

}

