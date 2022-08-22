public class InstantCameraTool : HeldEntity // TypeDefIndex: 8584
{	// Fields
	public ItemDefinition photoItem; // 0x1F8
	public GameObjectRef screenshotEffect; // 0x200
	public SoundDefinition startPhotoSoundDef; // 0x208
	public SoundDefinition finishPhotoSoundDef; // 0x210
	[RangeAttribute] // RVA: 0xAC790 Offset: 0xABB90 VA: 0x1800AC790
	public int resolutionX; // 0x218
	[RangeAttribute] // RVA: 0xAC8A0 Offset: 0xABCA0 VA: 0x1800AC8A0
	public int resolutionY; // 0x21C
	[RangeAttribute] // RVA: 0xACA20 Offset: 0xABE20 VA: 0x1800ACA20
	public int quality; // 0x220
	[RangeAttribute] // RVA: 0x75A70 Offset: 0x74E70 VA: 0x180075A70
	public float cooldownSeconds; // 0x224
	private TimeSince _sinceLastPhoto; // 0x228
	private float cameraFOV; // 0x22C
	private CameraFocusMode _focusMode; // 0x230
	private float focalDistance; // 0x234
	private float focalDistanceSmooth; // 0x238
	private float focalDistanceTarget; // 0x23C

	// Methods

	// RVA: 0x815AE0 Offset: 0x8140E0 VA: 0x180815AE0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x814F30 Offset: 0x813530 VA: 0x180814F30 Slot: 135
	public override void EditViewAngles() { }

	// RVA: 0x8155C0 Offset: 0x813BC0 VA: 0x1808155C0 Slot: 137
	public override void OnFrame() { }

	// RVA: 0x8152E0 Offset: 0x8138E0 VA: 0x1808152E0
	private float GetAutofocusDistance() { }

	// RVA: 0x815800 Offset: 0x813E00 VA: 0x180815800 Slot: 138
	public override void OnInput() { }

	[IteratorStateMachineAttribute] // RVA: 0xACB80 Offset: 0xABF80 VA: 0x1800ACB80
	// RVA: 0x815D20 Offset: 0x814320 VA: 0x180815D20
	private IEnumerator TakePhoto() { }

	// RVA: 0x815BD0 Offset: 0x8141D0 VA: 0x180815BD0
	private void RenderCallback() { }

	// RVA: 0x815380 Offset: 0x813980 VA: 0x180815380
	private void GetScreenCallback(Texture2D texture) { }

	// RVA: 0x815400 Offset: 0x813A00 VA: 0x180815400 Slot: 146
	public override void ModifyCamera() { }

	// RVA: 0x815170 Offset: 0x813770 VA: 0x180815170
	private void FadeOut() { }

	// RVA: 0x815520 Offset: 0x813B20 VA: 0x180815520 Slot: 141
	public override void OnDeployed() { }

	// RVA: 0x815760 Offset: 0x813D60 VA: 0x180815760 Slot: 143
	public override void OnHolstered() { }

	// RVA: 0x815D90 Offset: 0x814390 VA: 0x180815D90
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

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x820670 Offset: 0x81EC70 VA: 0x180820670 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x8208A0 Offset: 0x81EEA0 VA: 0x1808208A0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

