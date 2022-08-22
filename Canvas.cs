public sealed class Canvas : Behaviour // TypeDefIndex: 4736
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private static Canvas.WillRenderCanvases willRenderCanvases; // 0x13600

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
	// RVA: 0x2308AA0 Offset: 0x23070A0 VA: 0x182308AA0
	public static void add_willRenderCanvases(Canvas.WillRenderCanvases value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2308F30 Offset: 0x2307530 VA: 0x182308F30
	public static void remove_willRenderCanvases(Canvas.WillRenderCanvases value) { }

	// RVA: 0x2308D30 Offset: 0x2307330 VA: 0x182308D30
	public RenderMode get_renderMode() { }

	// RVA: 0x2308B90 Offset: 0x2307190 VA: 0x182308B90
	public bool get_isRootCanvas() { }

	// RVA: 0x2308CA0 Offset: 0x23072A0 VA: 0x182308CA0
	public Rect get_pixelRect() { }

	// RVA: 0x2308DF0 Offset: 0x23073F0 VA: 0x182308DF0
	public float get_scaleFactor() { }

	// RVA: 0x23090C0 Offset: 0x23076C0 VA: 0x1823090C0
	public void set_scaleFactor(float value) { }

	// RVA: 0x2308CF0 Offset: 0x23072F0 VA: 0x182308CF0
	public float get_referencePixelsPerUnit() { }

	// RVA: 0x2309070 Offset: 0x2307670 VA: 0x182309070
	public void set_referencePixelsPerUnit(float value) { }

	// RVA: 0x2308C10 Offset: 0x2307210 VA: 0x182308C10
	public bool get_pixelPerfect() { }

	// RVA: 0x2308D70 Offset: 0x2307370 VA: 0x182308D70
	public int get_renderOrder() { }

	// RVA: 0x2308BD0 Offset: 0x23071D0 VA: 0x182308BD0
	public bool get_overrideSorting() { }

	// RVA: 0x2309020 Offset: 0x2307620 VA: 0x182309020
	public void set_overrideSorting(bool value) { }

	// RVA: 0x2308E70 Offset: 0x2307470 VA: 0x182308E70
	public int get_sortingOrder() { }

	// RVA: 0x2309150 Offset: 0x2307750 VA: 0x182309150
	public void set_sortingOrder(int value) { }

	// RVA: 0x2308EB0 Offset: 0x23074B0 VA: 0x182308EB0
	public int get_targetDisplay() { }

	// RVA: 0x2308E30 Offset: 0x2307430 VA: 0x182308E30
	public int get_sortingLayerID() { }

	// RVA: 0x2309110 Offset: 0x2307710 VA: 0x182309110
	public void set_sortingLayerID(int value) { }

	// RVA: 0x2308B50 Offset: 0x2307150 VA: 0x182308B50
	public AdditionalCanvasShaderChannels get_additionalShaderChannels() { }

	// RVA: 0x2308FE0 Offset: 0x23075E0 VA: 0x182308FE0
	public void set_additionalShaderChannels(AdditionalCanvasShaderChannels value) { }

	// RVA: 0x2308DB0 Offset: 0x23073B0 VA: 0x182308DB0
	public Canvas get_rootCanvas() { }

	// RVA: 0x2308EF0 Offset: 0x23074F0 VA: 0x182308EF0
	public Camera get_worldCamera() { }

	// RVA: 0x2309190 Offset: 0x2307790 VA: 0x182309190
	public void set_worldCamera(Camera value) { }

	[FreeFunctionAttribute] // RVA: 0xA5AD0 Offset: 0xA4ED0 VA: 0x1800A5AD0
	// RVA: 0x2308A40 Offset: 0x2307040 VA: 0x182308A40
	public static Material GetDefaultCanvasMaterial() { }

	[FreeFunctionAttribute] // RVA: 0xA5B90 Offset: 0xA4F90 VA: 0x1800A5B90
	// RVA: 0x2308A70 Offset: 0x2307070 VA: 0x182308A70
	public static Material GetETC1SupportedCanvasMaterial() { }

	// RVA: 0x23089F0 Offset: 0x2306FF0 VA: 0x1823089F0
	public static void ForceUpdateCanvases() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x23089F0 Offset: 0x2306FF0 VA: 0x1823089F0
	private static void SendWillRenderCanvases() { }

	// RVA: 0x18F7950 Offset: 0x18F5F50 VA: 0x1818F7950
	public void .ctor() { }

	// RVA: 0x2308C50 Offset: 0x2307250 VA: 0x182308C50
	private void get_pixelRect_Injected(out Rect ret) { }

}

public sealed class Canvas.WillRenderCanvases : MulticastDelegate // TypeDefIndex: 4737
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A85AC0 Offset: 0x1A840C0 VA: 0x181A85AC0 Slot: 12
	public virtual void Invoke() { }

	// RVA: 0x49A190 Offset: 0x498790 VA: 0x18049A190 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

