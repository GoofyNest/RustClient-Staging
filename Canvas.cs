public sealed class Canvas : Behaviour // TypeDefIndex: 4736
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private static Canvas.WillRenderCanvases willRenderCanvases; // 0x2B104D4

	// Properties
	public RenderMode renderMode { get; }
	public bool isRootCanvas { get; }
	public Rect pixelRect { get; }
	public float scaleFactor { get; set; }
	public float referencePixelsPerUnit { get; set; }
	public bool pixelPerfect { get; }
	public int renderOrder { get; }
	public bool overrideSorting { get; set; }
	public int sortingOrder { get; set; }
	public int targetDisplay { get; }
	public int sortingLayerID { get; set; }
	public AdditionalCanvasShaderChannels additionalShaderChannels { get; set; }
	public Canvas rootCanvas { get; }
	[NativePropertyAttribute] // RVA: 0xA5D00 Offset: 0xA5100 VA: 0x1800A5D00
	public Camera worldCamera { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2309580 Offset: 0x2307B80 VA: 0x182309580
	public static void add_willRenderCanvases(Canvas.WillRenderCanvases value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2309A10 Offset: 0x2308010 VA: 0x182309A10
	public static void remove_willRenderCanvases(Canvas.WillRenderCanvases value) { }

	// RVA: 0x2309810 Offset: 0x2307E10 VA: 0x182309810
	public RenderMode get_renderMode() { }

	// RVA: 0x2309670 Offset: 0x2307C70 VA: 0x182309670
	public bool get_isRootCanvas() { }

	// RVA: 0x2309780 Offset: 0x2307D80 VA: 0x182309780
	public Rect get_pixelRect() { }

	// RVA: 0x23098D0 Offset: 0x2307ED0 VA: 0x1823098D0
	public float get_scaleFactor() { }

	// RVA: 0x2309BA0 Offset: 0x23081A0 VA: 0x182309BA0
	public void set_scaleFactor(float value) { }

	// RVA: 0x23097D0 Offset: 0x2307DD0 VA: 0x1823097D0
	public float get_referencePixelsPerUnit() { }

	// RVA: 0x2309B50 Offset: 0x2308150 VA: 0x182309B50
	public void set_referencePixelsPerUnit(float value) { }

	// RVA: 0x23096F0 Offset: 0x2307CF0 VA: 0x1823096F0
	public bool get_pixelPerfect() { }

	// RVA: 0x2309850 Offset: 0x2307E50 VA: 0x182309850
	public int get_renderOrder() { }

	// RVA: 0x23096B0 Offset: 0x2307CB0 VA: 0x1823096B0
	public bool get_overrideSorting() { }

	// RVA: 0x2309B00 Offset: 0x2308100 VA: 0x182309B00
	public void set_overrideSorting(bool value) { }

	// RVA: 0x2309950 Offset: 0x2307F50 VA: 0x182309950
	public int get_sortingOrder() { }

	// RVA: 0x2309C30 Offset: 0x2308230 VA: 0x182309C30
	public void set_sortingOrder(int value) { }

	// RVA: 0x2309990 Offset: 0x2307F90 VA: 0x182309990
	public int get_targetDisplay() { }

	// RVA: 0x2309910 Offset: 0x2307F10 VA: 0x182309910
	public int get_sortingLayerID() { }

	// RVA: 0x2309BF0 Offset: 0x23081F0 VA: 0x182309BF0
	public void set_sortingLayerID(int value) { }

	// RVA: 0x2309630 Offset: 0x2307C30 VA: 0x182309630
	public AdditionalCanvasShaderChannels get_additionalShaderChannels() { }

	// RVA: 0x2309AC0 Offset: 0x23080C0 VA: 0x182309AC0
	public void set_additionalShaderChannels(AdditionalCanvasShaderChannels value) { }

	// RVA: 0x2309890 Offset: 0x2307E90 VA: 0x182309890
	public Canvas get_rootCanvas() { }

	// RVA: 0x23099D0 Offset: 0x2307FD0 VA: 0x1823099D0
	public Camera get_worldCamera() { }

	// RVA: 0x2309C70 Offset: 0x2308270 VA: 0x182309C70
	public void set_worldCamera(Camera value) { }

	[FreeFunctionAttribute] // RVA: 0xA5AD0 Offset: 0xA4ED0 VA: 0x1800A5AD0
	// RVA: 0x2309520 Offset: 0x2307B20 VA: 0x182309520
	public static Material GetDefaultCanvasMaterial() { }

	[FreeFunctionAttribute] // RVA: 0xA5B90 Offset: 0xA4F90 VA: 0x1800A5B90
	// RVA: 0x2309550 Offset: 0x2307B50 VA: 0x182309550
	public static Material GetETC1SupportedCanvasMaterial() { }

	// RVA: 0x23094D0 Offset: 0x2307AD0 VA: 0x1823094D0
	public static void ForceUpdateCanvases() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x23094D0 Offset: 0x2307AD0 VA: 0x1823094D0
	private static void SendWillRenderCanvases() { }

	// RVA: 0x18F7330 Offset: 0x18F5930 VA: 0x1818F7330
	public void .ctor() { }

	// RVA: 0x2309730 Offset: 0x2307D30 VA: 0x182309730
	private void get_pixelRect_Injected(out Rect ret) { }

}

public sealed class Canvas.WillRenderCanvases : MulticastDelegate // TypeDefIndex: 4737
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A722B0 Offset: 0x1A708B0 VA: 0x181A722B0 Slot: 12
	public virtual void Invoke() { }

	// RVA: 0x49A190 Offset: 0x498790 VA: 0x18049A190 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

