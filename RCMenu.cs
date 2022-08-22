public class RCMenu : ComputerMenu // TypeDefIndex: 8687
{	// Fields
	public Image backgroundOpaque; // 0x58
	public InputField newBookmarkEntryField; // 0x60
	public NeedsCursor needsCursor; // 0x68
	public float hiddenOffset; // 0x70
	public RectTransform devicesPanel; // 0x78
	private Vector3 initialDevicesPosition; // 0x80
	public static bool isControllingCamera; // 0x0
	public CanvasGroup overExposure; // 0x90
	public CanvasGroup interference; // 0x98
	public float interferenceFadeDuration; // 0xA0
	public Text timeText; // 0xA8
	public Text watchedDurationText; // 0xB0
	public Text deviceNameText; // 0xB8
	public Text noSignalText; // 0xC0
	public SoundDefinition bookmarkPressedSoundDef; // 0xC8
	public GameObject[] hideIfStatic; // 0xD0
	private float startWatchingTime; // 0xD8
	private float noSignalDuration; // 0xDC
	private bool devicePanelVisible; // 0xE0

	// Properties
	public bool RequiresMouseForControl { get; }

	// Methods

	// RVA: 0x69E030 Offset: 0x69C630 VA: 0x18069E030 Slot: 10
	public override void InitMenu(BaseEntity computer) { }

	// RVA: 0x69DFA0 Offset: 0x69C5A0 VA: 0x18069DFA0
	public ComputerStation GetOwnerComputer() { }

	// RVA: 0x69E390 Offset: 0x69C990 VA: 0x18069E390
	public void SetDevicesVisible(bool wants) { }

	// RVA: 0x69E480 Offset: 0x69CA80 VA: 0x18069E480
	public void ToggleDevicePanelVisible() { }

	// RVA: 0x69D7C0 Offset: 0x69BDC0 VA: 0x18069D7C0
	public void BackgroundClick() { }

	// RVA: 0x69DF70 Offset: 0x69C570 VA: 0x18069DF70
	public float GetInterferenceLevel() { }

	// RVA: 0x69DE50 Offset: 0x69C450 VA: 0x18069DE50
	public IRemoteControllable GetCurrentlyControllingEnt() { }

	// RVA: 0x69F180 Offset: 0x69D780 VA: 0x18069F180
	public bool get_RequiresMouseForControl() { }

	// RVA: 0x69E570 Offset: 0x69CB70 VA: 0x18069E570
	public void Update() { }

	// RVA: 0x69E2A0 Offset: 0x69C8A0 VA: 0x18069E2A0
	public void OnDestroy() { }

	// RVA: 0x69D9F0 Offset: 0x69BFF0 VA: 0x18069D9F0
	public void DelayedLODRefresh() { }

	[IteratorStateMachineAttribute] // RVA: 0xB9F40 Offset: 0xB9340 VA: 0x1800B9F40
	// RVA: 0x69E340 Offset: 0x69C940 VA: 0x18069E340
	private IEnumerator RefreshLODs() { }

	// RVA: 0x69D6D0 Offset: 0x69BCD0 VA: 0x18069D6D0
	public void AddBookmarkPressed() { }

	// RVA: 0x69DB00 Offset: 0x69C100 VA: 0x18069DB00 Slot: 16
	public override void DeletePressed(RCBookmarkEntry entry) { }

	// RVA: 0x69DC80 Offset: 0x69C280 VA: 0x18069DC80
	public void Exit() { }

	// RVA: 0x69E180 Offset: 0x69C780 VA: 0x18069E180 Slot: 17
	public override bool IsControlling(string identifier) { }

	// RVA: 0x69DBC0 Offset: 0x69C1C0 VA: 0x18069DBC0 Slot: 15
	public override void DisconnectPressed(RCBookmarkEntry entry) { }

	// RVA: 0x69D830 Offset: 0x69BE30 VA: 0x18069D830 Slot: 14
	public override void BookmarkPressed(RCBookmarkEntry entryPressed) { }

	// RVA: 0x69DD10 Offset: 0x69C310 VA: 0x18069DD10 Slot: 13
	public override BasePlayer.CameraMode GetCameraMode() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 11
	public override bool WantsEyeOverride() { }

	// RVA: 0x69DD50 Offset: 0x69C350 VA: 0x18069DD50 Slot: 12
	public override Transform GetCameraOverrideTransform() { }

	// RVA: 0x69F160 Offset: 0x69D760 VA: 0x18069F160
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

private sealed class RCMenu.<RefreshLODs>d__31 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 8688
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18

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

	// RVA: 0x6ACE60 Offset: 0x6AB460 VA: 0x1806ACE60 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6AD1C0 Offset: 0x6AB7C0 VA: 0x1806AD1C0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

