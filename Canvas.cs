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
	// RVA: 0x2308D60 Offset: 0x2307360 VA: 0x182308D60
	public static void add_willRenderCanvases(Canvas.WillRenderCanvases value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x23091F0 Offset: 0x23077F0 VA: 0x1823091F0
	public static void remove_willRenderCanvases(Canvas.WillRenderCanvases value) { }

	// RVA: 0x2308FF0 Offset: 0x23075F0 VA: 0x182308FF0
	public RenderMode get_renderMode() { }

	// RVA: 0x2308E50 Offset: 0x2307450 VA: 0x182308E50
	public bool get_isRootCanvas() { }

	// RVA: 0x2308F60 Offset: 0x2307560 VA: 0x182308F60
	public Rect get_pixelRect() { }

	// RVA: 0x23090B0 Offset: 0x23076B0 VA: 0x1823090B0
	public float get_scaleFactor() { }

	// RVA: 0x2309380 Offset: 0x2307980 VA: 0x182309380
	public void set_scaleFactor(float value) { }

	// RVA: 0x2308FB0 Offset: 0x23075B0 VA: 0x182308FB0
	public float get_referencePixelsPerUnit() { }

	// RVA: 0x2309330 Offset: 0x2307930 VA: 0x182309330
	public void set_referencePixelsPerUnit(float value) { }

	// RVA: 0x2308ED0 Offset: 0x23074D0 VA: 0x182308ED0
	public bool get_pixelPerfect() { }

	// RVA: 0x2309030 Offset: 0x2307630 VA: 0x182309030
	public int get_renderOrder() { }

	// RVA: 0x2308E90 Offset: 0x2307490 VA: 0x182308E90
	public bool get_overrideSorting() { }

	// RVA: 0x23092E0 Offset: 0x23078E0 VA: 0x1823092E0
	public void set_overrideSorting(bool value) { }

	// RVA: 0x2309130 Offset: 0x2307730 VA: 0x182309130
	public int get_sortingOrder() { }

	// RVA: 0x2309410 Offset: 0x2307A10 VA: 0x182309410
	public void set_sortingOrder(int value) { }

	// RVA: 0x2309170 Offset: 0x2307770 VA: 0x182309170
	public int get_targetDisplay() { }

	// RVA: 0x23090F0 Offset: 0x23076F0 VA: 0x1823090F0
	public int get_sortingLayerID() { }

	// RVA: 0x23093D0 Offset: 0x23079D0 VA: 0x1823093D0
	public void set_sortingLayerID(int value) { }

	// RVA: 0x2308E10 Offset: 0x2307410 VA: 0x182308E10
	public AdditionalCanvasShaderChannels get_additionalShaderChannels() { }

	// RVA: 0x23092A0 Offset: 0x23078A0 VA: 0x1823092A0
	public void set_additionalShaderChannels(AdditionalCanvasShaderChannels value) { }

	// RVA: 0x2309070 Offset: 0x2307670 VA: 0x182309070
	public Canvas get_rootCanvas() { }

	// RVA: 0x23091B0 Offset: 0x23077B0 VA: 0x1823091B0
	public Camera get_worldCamera() { }

	// RVA: 0x2309450 Offset: 0x2307A50 VA: 0x182309450
	public void set_worldCamera(Camera value) { }

	[FreeFunctionAttribute] // RVA: 0xA5AD0 Offset: 0xA4ED0 VA: 0x1800A5AD0
	// RVA: 0x2308D00 Offset: 0x2307300 VA: 0x182308D00
	public static Material GetDefaultCanvasMaterial() { }

	[FreeFunctionAttribute] // RVA: 0xA5B90 Offset: 0xA4F90 VA: 0x1800A5B90
	// RVA: 0x2308D30 Offset: 0x2307330 VA: 0x182308D30
	public static Material GetETC1SupportedCanvasMaterial() { }

	// RVA: 0x2308CB0 Offset: 0x23072B0 VA: 0x182308CB0
	public static void ForceUpdateCanvases() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2308CB0 Offset: 0x23072B0 VA: 0x182308CB0
	private static void SendWillRenderCanvases() { }

	// RVA: 0x18F7C10 Offset: 0x18F6210 VA: 0x1818F7C10
	public void .ctor() { }

	// RVA: 0x2308F10 Offset: 0x2307510 VA: 0x182308F10
	private void get_pixelRect_Injected(out Rect ret) { }

}

public sealed class Canvas.WillRenderCanvases : MulticastDelegate // TypeDefIndex: 4737
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A85D80 Offset: 0x1A84380 VA: 0x181A85D80 Slot: 12
	public virtual void Invoke() { }

	// RVA: 0x49A190 Offset: 0x498790 VA: 0x18049A190 Slot: 13
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

