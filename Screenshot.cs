public struct Screenshot // TypeDefIndex: 5556
{	// Fields
	internal ScreenshotHandle Value; // 0x0

}

public class Screenshot : SingletonComponent<Screenshot> // TypeDefIndex: 11336
{	// Fields
	public string screenshotPath; // 0x18
	public int sizeMultiplier; // 0x20
	public static bool TakingScreenshot; // 0x0
	private bool takingScreenshot; // 0x24
	private string savePathName; // 0x28

	// Methods

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x4A54F0 Offset: 0x4A3AF0 VA: 0x1804A54F0
	public static void takescreenshot(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	// RVA: 0x4A5400 Offset: 0x4A3A00 VA: 0x1804A5400
	public static void takehiresscreenshot(ConsoleSystem.Arg arg) { }

	// RVA: 0x4A5320 Offset: 0x4A3920 VA: 0x1804A5320
	private void TakeScreenshotNormal() { }

	// RVA: 0x4A5290 Offset: 0x4A3890 VA: 0x1804A5290
	private void TakeHighResScreenshot() { }

	[IteratorStateMachineAttribute] // RVA: 0xA5000 Offset: 0xA4400 VA: 0x1800A5000
	// RVA: 0x4A51D0 Offset: 0x4A37D0 VA: 0x1804A51D0
	private IEnumerator SaveScreenshot(string ext, int resolutionX, int resolutionY, bool withHud, bool withoutHud) { }

	// RVA: 0x4A5000 Offset: 0x4A3600 VA: 0x1804A5000
	private void GetScreenCallback(Texture2D texture) { }

	[IteratorStateMachineAttribute] // RVA: 0xA5160 Offset: 0xA4560 VA: 0x1800A5160
	// RVA: 0x4A5110 Offset: 0x4A3710 VA: 0x1804A5110
	public static IEnumerator GetScreen(Camera camera, int resolutionX, int resolutionY, Action<Texture2D> finishedCallback, Action renderCallback, bool updateCamera = False) { }

	// RVA: 0x4A53A0 Offset: 0x4A39A0 VA: 0x1804A53A0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

private sealed class Screenshot.<SaveScreenshot>d__9 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11337
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public int resolutionX; // 0x20
	public int resolutionY; // 0x24
	public Screenshot <>4__this; // 0x28
	public bool withHud; // 0x30
	public string ext; // 0x38
	public bool withoutHud; // 0x40
	private string <path>5__2; // 0x48
	private bool <oldNametags>5__3; // 0x50
	private int <i>5__4; // 0x54

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

	// RVA: 0x4B2E80 Offset: 0x4B1480 VA: 0x1804B2E80 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4B36A0 Offset: 0x4B1CA0 VA: 0x1804B36A0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class Screenshot.<GetScreen>d__11 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11338
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Camera camera; // 0x20
	public int resolutionX; // 0x28
	public int resolutionY; // 0x2C
	public bool updateCamera; // 0x30
	public Action renderCallback; // 0x38
	public Action<Texture2D> finishedCallback; // 0x40
	private PostProcessLayer <post>5__2; // 0x48
	private RenderTexture <rt>5__3; // 0x50
	private float <screenSizeMultiple>5__4; // 0x58
	private float <originalDofBlur>5__5; // 0x5C
	private int <originalAA>5__6; // 0x60
	private RenderTexture <originalRT>5__7; // 0x68
	private int <originalMask>5__8; // 0x70
	private bool <originalBranding>5__9; // 0x74
	private bool <nvgEnabled>5__10; // 0x75

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

	// RVA: 0x4B1230 Offset: 0x4AF830 VA: 0x1804B1230 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4B1CC0 Offset: 0x4B02C0 VA: 0x1804B1CC0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

