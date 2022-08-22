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

	// RVA: 0x69E0A0 Offset: 0x69C6A0 VA: 0x18069E0A0 Slot: 10
	public override void InitMenu(BaseEntity computer) { }

	// RVA: 0x69E010 Offset: 0x69C610 VA: 0x18069E010
	public ComputerStation GetOwnerComputer() { }

	// RVA: 0x69E400 Offset: 0x69CA00 VA: 0x18069E400
	public void SetDevicesVisible(bool wants) { }

	// RVA: 0x69E4F0 Offset: 0x69CAF0 VA: 0x18069E4F0
	public void ToggleDevicePanelVisible() { }

	// RVA: 0x69D830 Offset: 0x69BE30 VA: 0x18069D830
	public void BackgroundClick() { }

	// RVA: 0x69DFE0 Offset: 0x69C5E0 VA: 0x18069DFE0
	public float GetInterferenceLevel() { }

	// RVA: 0x69DEC0 Offset: 0x69C4C0 VA: 0x18069DEC0
	public IRemoteControllable GetCurrentlyControllingEnt() { }

	// RVA: 0x69F1F0 Offset: 0x69D7F0 VA: 0x18069F1F0
	public bool get_RequiresMouseForControl() { }

	// RVA: 0x69E5E0 Offset: 0x69CBE0 VA: 0x18069E5E0
	public void Update() { }

	// RVA: 0x69E310 Offset: 0x69C910 VA: 0x18069E310
	public void OnDestroy() { }

	// RVA: 0x69DA60 Offset: 0x69C060 VA: 0x18069DA60
	public void DelayedLODRefresh() { }

	[IteratorStateMachineAttribute] // RVA: 0xB9F40 Offset: 0xB9340 VA: 0x1800B9F40
	// RVA: 0x69E3B0 Offset: 0x69C9B0 VA: 0x18069E3B0
	private IEnumerator RefreshLODs() { }

	// RVA: 0x69D740 Offset: 0x69BD40 VA: 0x18069D740
	public void AddBookmarkPressed() { }

	// RVA: 0x69DB70 Offset: 0x69C170 VA: 0x18069DB70 Slot: 16
	public override void DeletePressed(RCBookmarkEntry entry) { }

	// RVA: 0x69DCF0 Offset: 0x69C2F0 VA: 0x18069DCF0
	public void Exit() { }

	// RVA: 0x69E1F0 Offset: 0x69C7F0 VA: 0x18069E1F0 Slot: 17
	public override bool IsControlling(string identifier) { }

	// RVA: 0x69DC30 Offset: 0x69C230 VA: 0x18069DC30 Slot: 15
	public override void DisconnectPressed(RCBookmarkEntry entry) { }

	// RVA: 0x69D8A0 Offset: 0x69BEA0 VA: 0x18069D8A0 Slot: 14
	public override void BookmarkPressed(RCBookmarkEntry entryPressed) { }

	// RVA: 0x69DD80 Offset: 0x69C380 VA: 0x18069DD80 Slot: 13
	public override BasePlayer.CameraMode GetCameraMode() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 11
	public override bool WantsEyeOverride() { }

	// RVA: 0x69DDC0 Offset: 0x69C3C0 VA: 0x18069DDC0 Slot: 12
	public override Transform GetCameraOverrideTransform() { }

	// RVA: 0x69F1D0 Offset: 0x69D7D0 VA: 0x18069F1D0
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

	// RVA: 0x6ACED0 Offset: 0x6AB4D0 VA: 0x1806ACED0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6AD230 Offset: 0x6AB830 VA: 0x1806AD230 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

