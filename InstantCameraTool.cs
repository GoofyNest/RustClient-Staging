public class InstantCameraTool : HeldEntity // TypeDefIndex: 8584
{	// Fields
	public ItemDefinition photoItem; // 0x1F8
	public GameObjectRef screenshotEffect; // 0x200
	public SoundDefinition startPhotoSoundDef; // 0x208
	public SoundDefinition finishPhotoSoundDef; // 0x210
	[RangeAttribute] // RVA: 0xAC750 Offset: 0xABB50 VA: 0x1800AC750
	public int resolutionX; // 0x218
	[RangeAttribute] // RVA: 0xAC800 Offset: 0xABC00 VA: 0x1800AC800
	public int resolutionY; // 0x21C
	[RangeAttribute] // RVA: 0xAC920 Offset: 0xABD20 VA: 0x1800AC920
	public int quality; // 0x220
	[RangeAttribute] // RVA: 0x759D0 Offset: 0x74DD0 VA: 0x1800759D0
	public float cooldownSeconds; // 0x224
	private TimeSince _sinceLastPhoto; // 0x228
	private float cameraFOV; // 0x22C
	private CameraFocusMode _focusMode; // 0x230
	private float focalDistance; // 0x234
	private float focalDistanceSmooth; // 0x238
	private float focalDistanceTarget; // 0x23C

	// Methods

	// RVA: 0x8159D0 Offset: 0x813FD0 VA: 0x1808159D0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x814E20 Offset: 0x813420 VA: 0x180814E20 Slot: 135
	public override void EditViewAngles() { }

	// RVA: 0x8154B0 Offset: 0x813AB0 VA: 0x1808154B0 Slot: 137
	public override void OnFrame() { }

	// RVA: 0x8151D0 Offset: 0x8137D0 VA: 0x1808151D0
	private float GetAutofocusDistance() { }

	// RVA: 0x8156F0 Offset: 0x813CF0 VA: 0x1808156F0 Slot: 138
	public override void OnInput() { }

	[IteratorStateMachineAttribute] // RVA: 0xACAE0 Offset: 0xABEE0 VA: 0x1800ACAE0
	// RVA: 0x815C10 Offset: 0x814210 VA: 0x180815C10
	private IEnumerator TakePhoto() { }

	// RVA: 0x815AC0 Offset: 0x8140C0 VA: 0x180815AC0
	private void RenderCallback() { }

	// RVA: 0x815270 Offset: 0x813870 VA: 0x180815270
	private void GetScreenCallback(Texture2D texture) { }

	// RVA: 0x8152F0 Offset: 0x8138F0 VA: 0x1808152F0 Slot: 146
	public override void ModifyCamera() { }

	// RVA: 0x815060 Offset: 0x813660 VA: 0x180815060
	private void FadeOut() { }

	// RVA: 0x815410 Offset: 0x813A10 VA: 0x180815410 Slot: 141
	public override void OnDeployed() { }

	// RVA: 0x815650 Offset: 0x813C50 VA: 0x180815650 Slot: 143
	public override void OnHolstered() { }

	// RVA: 0x815C80 Offset: 0x814280 VA: 0x180815C80
	public void .ctor() { }

}

private sealed class InstantCameraTool.<TakePhoto>d__19 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 8585
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public InstantCameraTool <>4__this; // 0x20
	private int <originalNudity>5__2; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x820560 Offset: 0x81EB60 VA: 0x180820560 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x820790 Offset: 0x81ED90 VA: 0x180820790 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

