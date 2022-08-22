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

	// RVA: 0x816070 Offset: 0x814670 VA: 0x180816070 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x8154C0 Offset: 0x813AC0 VA: 0x1808154C0 Slot: 135
	public override void EditViewAngles() { }

	// RVA: 0x815B50 Offset: 0x814150 VA: 0x180815B50 Slot: 137
	public override void OnFrame() { }

	// RVA: 0x815870 Offset: 0x813E70 VA: 0x180815870
	private float GetAutofocusDistance() { }

	// RVA: 0x815D90 Offset: 0x814390 VA: 0x180815D90 Slot: 138
	public override void OnInput() { }

	[IteratorStateMachineAttribute] // RVA: 0xACB80 Offset: 0xABF80 VA: 0x1800ACB80
	// RVA: 0x8162B0 Offset: 0x8148B0 VA: 0x1808162B0
	private IEnumerator TakePhoto() { }

	// RVA: 0x816160 Offset: 0x814760 VA: 0x180816160
	private void RenderCallback() { }

	// RVA: 0x815910 Offset: 0x813F10 VA: 0x180815910
	private void GetScreenCallback(Texture2D texture) { }

	// RVA: 0x815990 Offset: 0x813F90 VA: 0x180815990 Slot: 146
	public override void ModifyCamera() { }

	// RVA: 0x815700 Offset: 0x813D00 VA: 0x180815700
	private void FadeOut() { }

	// RVA: 0x815AB0 Offset: 0x8140B0 VA: 0x180815AB0 Slot: 141
	public override void OnDeployed() { }

	// RVA: 0x815CF0 Offset: 0x8142F0 VA: 0x180815CF0 Slot: 143
	public override void OnHolstered() { }

	// RVA: 0x816320 Offset: 0x814920 VA: 0x180816320
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

	// RVA: 0x820C00 Offset: 0x81F200 VA: 0x180820C00 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x820E30 Offset: 0x81F430 VA: 0x180820E30 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

