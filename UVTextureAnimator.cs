internal class UVTextureAnimator : MonoBehaviour // TypeDefIndex: 11477
{	// Fields
	public int Rows; // 0x18
	public int Columns; // 0x1C
	public float Fps; // 0x20
	public int OffsetMat; // 0x24
	public bool IsLoop; // 0x28
	public float StartDelay; // 0x2C
	private bool isInizialised; // 0x30
	private int index; // 0x34
	private int count; // 0x38
	private int allCount; // 0x3C
	private float deltaFps; // 0x40
	private bool isVisible; // 0x44
	private bool isCorutineStarted; // 0x45
	private Renderer currentRenderer; // 0x48
	private Material instanceMaterial; // 0x50

	// Methods

	// RVA: 0xA060D0 Offset: 0xA046D0 VA: 0x180A060D0
	private void Start() { }

	// RVA: 0xA05C30 Offset: 0xA04230 VA: 0x180A05C30
	private void InitDefaultVariables() { }

	// RVA: 0xA06050 Offset: 0xA04650 VA: 0x180A06050
	private void Play() { }

	// RVA: 0xA05FE0 Offset: 0xA045E0 VA: 0x180A05FE0
	private void PlayDelay() { }

	// RVA: 0xA05FB0 Offset: 0xA045B0 VA: 0x180A05FB0
	private void OnEnable() { }

	// RVA: 0xA05F60 Offset: 0xA04560 VA: 0x180A05F60
	private void OnDisable() { }

	[IteratorStateMachineAttribute] // RVA: 0xB47E0 Offset: 0xB3BE0 VA: 0x1800B47E0
	// RVA: 0xA06240 Offset: 0xA04840 VA: 0x180A06240
	private IEnumerator UpdateCorutine() { }

	// RVA: 0xA06140 Offset: 0xA04740 VA: 0x180A06140
	private void UpdateCorutineFrame() { }

	// RVA: 0xA05EB0 Offset: 0xA044B0 VA: 0x180A05EB0
	private void OnDestroy() { }

	// RVA: 0xA062B0 Offset: 0xA048B0 VA: 0x180A062B0
	public void .ctor() { }

}

private sealed class UVTextureAnimator.<UpdateCorutine>d__21 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11478
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public UVTextureAnimator <>4__this; // 0x20

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

	// RVA: 0xA00020 Offset: 0x9FE620 VA: 0x180A00020 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA00200 Offset: 0x9FE800 VA: 0x180A00200 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

