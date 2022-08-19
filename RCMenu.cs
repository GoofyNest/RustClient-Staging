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

	// RVA: 0x69DF90 Offset: 0x69C590 VA: 0x18069DF90 Slot: 10
	public override void InitMenu(BaseEntity computer) { }

	// RVA: 0x69DF00 Offset: 0x69C500 VA: 0x18069DF00
	public ComputerStation GetOwnerComputer() { }

	// RVA: 0x69E2F0 Offset: 0x69C8F0 VA: 0x18069E2F0
	public void SetDevicesVisible(bool wants) { }

	// RVA: 0x69E3E0 Offset: 0x69C9E0 VA: 0x18069E3E0
	public void ToggleDevicePanelVisible() { }

	// RVA: 0x69D720 Offset: 0x69BD20 VA: 0x18069D720
	public void BackgroundClick() { }

	// RVA: 0x69DED0 Offset: 0x69C4D0 VA: 0x18069DED0
	public float GetInterferenceLevel() { }

	// RVA: 0x69DDB0 Offset: 0x69C3B0 VA: 0x18069DDB0
	public IRemoteControllable GetCurrentlyControllingEnt() { }

	// RVA: 0x69F0E0 Offset: 0x69D6E0 VA: 0x18069F0E0
	public bool get_RequiresMouseForControl() { }

	// RVA: 0x69E4D0 Offset: 0x69CAD0 VA: 0x18069E4D0
	public void Update() { }

	// RVA: 0x69E200 Offset: 0x69C800 VA: 0x18069E200
	public void OnDestroy() { }

	// RVA: 0x69D950 Offset: 0x69BF50 VA: 0x18069D950
	public void DelayedLODRefresh() { }

	[IteratorStateMachineAttribute] // RVA: 0xB9EA0 Offset: 0xB92A0 VA: 0x1800B9EA0
	// RVA: 0x69E2A0 Offset: 0x69C8A0 VA: 0x18069E2A0
	private IEnumerator RefreshLODs() { }

	// RVA: 0x69D630 Offset: 0x69BC30 VA: 0x18069D630
	public void AddBookmarkPressed() { }

	// RVA: 0x69DA60 Offset: 0x69C060 VA: 0x18069DA60 Slot: 16
	public override void DeletePressed(RCBookmarkEntry entry) { }

	// RVA: 0x69DBE0 Offset: 0x69C1E0 VA: 0x18069DBE0
	public void Exit() { }

	// RVA: 0x69E0E0 Offset: 0x69C6E0 VA: 0x18069E0E0 Slot: 17
	public override bool IsControlling(string identifier) { }

	// RVA: 0x69DB20 Offset: 0x69C120 VA: 0x18069DB20 Slot: 15
	public override void DisconnectPressed(RCBookmarkEntry entry) { }

	// RVA: 0x69D790 Offset: 0x69BD90 VA: 0x18069D790 Slot: 14
	public override void BookmarkPressed(RCBookmarkEntry entryPressed) { }

	// RVA: 0x69DC70 Offset: 0x69C270 VA: 0x18069DC70 Slot: 13
	public override BasePlayer.CameraMode GetCameraMode() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 11
	public override bool WantsEyeOverride() { }

	// RVA: 0x69DCB0 Offset: 0x69C2B0 VA: 0x18069DCB0 Slot: 12
	public override Transform GetCameraOverrideTransform() { }

	// RVA: 0x69F0C0 Offset: 0x69D6C0 VA: 0x18069F0C0
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

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6ACDC0 Offset: 0x6AB3C0 VA: 0x1806ACDC0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x6AD120 Offset: 0x6AB720 VA: 0x1806AD120 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

